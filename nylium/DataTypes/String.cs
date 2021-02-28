using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace nylium.DataTypes {

    class String : DataType<string> {

        public String() : base("") { }
        public String(string value) : base(value) { }

        public override void Read(Stream stream, out int bytesRead) {
            bytesRead = 0;
            byte[] read = new byte[1];

            VarInt length = new VarInt();
            length.Read(stream, out bytesRead);

            do {
                stream.Read(read, 0, 1);
            } while(read.Length != length.Value);

            Value = Encoding.UTF8.GetString(read);
        }

        public override void Write(Stream stream) {
            byte[] bytes = Encoding.UTF8.GetBytes(Value);

            new VarInt(Encoding.UTF8.GetByteCount(Value)).Write(stream);
            stream.Write(bytes);
        }
    }
}
