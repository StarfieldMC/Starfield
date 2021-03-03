using System;
using System.IO;
using nylium.Extensions;

namespace nylium.Networking.DataTypes {

    public class Short : DataType<short> {

        public Short() : base(0) { }
        public Short(short value) : base(value) { }

        public override int Read(Stream stream) {
            byte[] read = new byte[2];
            int bytesRead = stream.Read(read, 0, 2);

            Value = read.ReadBigEndianS();
            return bytesRead;
        }

        public override void Write(Stream stream) {
            byte[] bytes = Value.WriteBigEndian();

            stream.Write(bytes);
        }
    }
}
