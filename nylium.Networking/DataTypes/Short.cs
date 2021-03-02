using System;
using System.IO;
using nylium.Extensions;

namespace nylium.Networking.DataTypes {

    public class Short : DataType<short> {

        public Short() : base(0) { }
        public Short(short value) : base(value) { }

        public override void Read(Stream stream, out int bytesRead) {
            bytesRead = 0;
            byte[] read = new byte[2];

            stream.Read(read, 0, 2);
            bytesRead += 2;

            Value = read.ReadBigEndianS();
        }

        public override void Write(Stream stream) {
            byte[] bytes = Value.WriteBigEndian();

            stream.Write(bytes);
        }
    }
}
