﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;

namespace nylium.Generators {

    [Generator]
    public class BlockGenerator : ISourceGenerator {

        private const string blockBase = @"
using System;

namespace nylium.Core.Blocks.Foo {{

    public class {0} {{

        static {0}() {{
            Id = ""{1}"";
            DefaultState = {2};
            MinimumState = {3};
            MaximumState = {4};
        }}

        public {0}(dynamic prop) : base((object) prop) {{
            {5}
        }}

        public {0}(ushort state) : base(state) {{
            {6}
        }}
    }}
}}";

        private dynamic json;

        public void Execute(GeneratorExecutionContext context) {
            TextInfo ti = new CultureInfo("en-US", false).TextInfo;

            foreach(dynamic block in json) {
                string id = block.Key;
                ushort defaultState = 0;

                string propIfs = "";
                string stateIfs = "";

                foreach(dynamic state in block.Value.states) {
                    if(state.ContainsKey("default")) {
                        if(state.@default) defaultState = state.id;
                    }

                    StringBuilder @if = new("if(");
                    StringBuilder if1 = new("if(state == ");
                    if1.Append((int) state.id);
                    if1.Append(") {");

                    if(state.ContainsKey("properties")) {
                        foreach(dynamic property in state.properties) {
                            @if.Append("prop.");
                            @if.Append(property.Key);
                            @if.Append(" == ");

                            if1.Append(" Properties.");
                            if1.Append(property.Key);
                            if1.Append(" = ");

                            if(property.Value == "true" || property.Value == "false") {
                                @if.Append(bool.Parse((string) property.Value));
                                if1.Append(bool.Parse((string) property.Value));
                            } else if(((string) property.Value).All(char.IsDigit)) {
                                @if.Append(int.Parse((string) property.Value));
                                if1.Append(int.Parse((string) property.Value));
                            } else {
                                @if.Append((string) property.Value);

                                @if.Append("\"");
                                @if.Append((string) property.Value);
                                @if.Append("\"");

                                if1.Append("\"");
                                if1.Append((string) property.Value);
                                if1.Append("\"");
                            }

                            @if.Append(" && ");
                            @if.Append(";");
                        }

                        string str = @if.ToString().Substring(0, @if.Length - 4);
                        str += ") State = " + state.id + ";\n";

                        propIfs += str;
                    } else {
                        propIfs += "State = " + state.id + ";";
                    }

                    if1.Append(" }");
                    string str1 = if1.ToString();

                    stateIfs += str1;
                }

                string source = string.Format(blockBase,
                    "Block" + ti.ToTitleCase(id.Replace("minecraft:", "").Replace("_", " ")).Replace(" ", ""),
                    id, defaultState, 0, 0, propIfs, stateIfs);

                context.AddSource(id.Replace("minecraft:", ""), SourceText.From(source, Encoding.UTF8));
            }
        }

        public void Initialize(GeneratorInitializationContext context) {
#if DEBUG
            if(!Debugger.IsAttached) {
                Debugger.Launch();
            }
#endif

            //Assembly jil = Assembly.LoadFrom("C:\\Jil.dll");
            //Type type = jil.GetType("Jil.JSON", true, true);
            //MethodInfo deserializeDynamic = type.GetMethod("DeserializeDynamic", new Type[] {
            //    typeof(string)
            //});

            //Sigil.OptimizationOptions _ = Sigil.OptimizationOptions.None;
            //Debug.WriteLine(_);

            using(MemoryStream compressedStream = new((byte[]) Properties.Resources.ResourceManager.GetObject("blocks"))) {
                using(GZipStream zipStream = new(compressedStream, CompressionMode.Decompress)) {
                    using(MemoryStream resultStream = new()) {
                        zipStream.CopyTo(resultStream);

                        string str = Encoding.UTF8.GetString(resultStream.ToArray());
                        //json = deserializeDynamic.Invoke(null, new object[] { Encoding.UTF8.GetString(resultStream.ToArray()) });
                        json = Jil.JSON.DeserializeDynamic(str);
                    }
                }
            }

            //string str = Encoding.UTF8.GetString((byte[]) Properties.Resources.ResourceManager.GetObject("blocks1"));
            //json = Jil.JSON.DeserializeDynamic(str);
        }
    }
}