using System.Linq;
using Starfield.Core;
using Starfield.Generators;

namespace Starfield.Launch {

    class Program {

        static void Main(string[] args) {
            if(args.Length > 0) {
                if(args[0] == "--generate-blocks") {
                    BlockGenerator.Run(args.Skip(1).ToArray());
                    return;
                } else if(args[0] == "--generate-items") {
                    ItemGenerator.Run(args.Skip(1).ToArray());
                    return;
                }
            }
            
            Nylium.Run(args);

            //NBTFile nbt = new(new System.IO.FileStream("D:\\poo.nbt", System.IO.FileMode.OpenOrCreate), new("root") {
            //    new TagByte("byteTest", 127),
            //    new TagList<TagString>("stringList", new System.Collections.Generic.List<TagString>() {
            //        new(null, "a"),
            //        new(null, "b"),
            //        new(null, "c"),
            //        new(null, "d"),
            //        new(null, "e"),
            //        new(null, "f"),
            //    }),
            //    new TagShort("short_TEST", -43),
            //    new TagByteArray("byteArray", new byte[] { 1, 2, 75, 9 }),
            //    new TagString("hello", "Hello world!"),
            //    new TagCompound("nested_compound") {
            //        new TagShort("shortval", 3232),
            //        new TagString("compoundhello", "Hello from a nested compound!"),
            //        new TagCompound("also_nested") {
            //            new TagString("msg", "fard")
            //        }
            //    },
            //    new TagDouble("PI", System.Math.PI),
            //    new TagLongArray("longarr", new long[] {
            //        long.MaxValue, long.MinValue, long.MaxValue / 2
            //    })
            //});
            //nbt.Write();
            //nbt.Dispose();

            //nbt = new(new System.IO.FileStream("D:\\poo.nbt", System.IO.FileMode.Open));
            //nbt.Read();

            //System.Console.WriteLine(nbt.Root.Get<TagByte>("byteTest").Value);

            //System.Collections.Generic.IList<TagString> list = nbt.Root.Get<TagList<TagString>>("stringList").Value;

            //foreach(TagString tag in list) {
            //    System.Console.WriteLine(tag.Value);
            //}

            //System.Console.WriteLine(nbt.Root.Get<TagShort>("short_TEST").Value);
            //System.Console.WriteLine(nbt.Root.Get<TagByteArray>("byteArray").Value);
            //System.Console.WriteLine(nbt.Root.Get<TagString>("hello").Value);
            //System.Console.WriteLine(nbt.Root.Get<TagCompound>("nested_compound").Get<TagShort>("shortval").Value);
            //System.Console.WriteLine(nbt.Root.Get<TagCompound>("nested_compound").Get<TagString>("compoundhello").Value);
            //System.Console.WriteLine(nbt.Root.Get<TagCompound>("nested_compound").Get<TagCompound>("also_nested").Get<TagString>("msg").Value);
            //System.Console.WriteLine(nbt.Root.Get<TagDouble>("PI").Value);
            //System.Console.WriteLine(nbt.Root.Get<TagLongArray>("longarr").Value);
        }
    }
}
