using System;
using System.IO;
using nylium.Extensions;

namespace nylium.Networking.DataTypes {

    public class UShort : DataType<ushort> {

        public UShort() : base(0) { }
        public UShort(ushort value) : base(value) { }

        public override void Read(Stream stream, out int bytesRead) {
            bytesRead = 0;
            byte[] read = new byte[2];

            stream.Read(read, 0, 2);
            bytesRead += 2;

            Value = read.ReadBigEndianUS();
        }

        public override void Write(Stream stream) {
            byte[] bytes = Value.WriteBigEndianU();
            stream.Write(bytes);
        }
    }
}
