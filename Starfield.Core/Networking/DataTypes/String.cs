﻿using System.IO;
using System.Text;

namespace Starfield.Core.Networking.DataTypes {

    public class String : DataType<string> {

        public String() : base(null) { }
        public String(string value) : base(value) { }
        public String(Stream stream) : base(null) { Read(stream); }

        public override void Read(Stream stream) {
            VarInt length = new(stream);

            byte[] read = new byte[length.Value];
            stream.Read(read, 0, length.Value);

            Value = Encoding.UTF8.GetString(read);
        }

        public override void Write(Stream stream) {
            byte[] bytes = Encoding.UTF8.GetBytes(Value);

            new VarInt(bytes.Length).Write(stream);
            stream.Write(bytes);
        }
    }
}
