using System;
using System.IO;
using nylium.Extensions;

namespace nylium.Core.DataTypes {

    public class UShort : DataType<ushort> {

        public UShort() : base(0) { }
        public UShort(ushort value) : base(value) { }
        public UShort(Stream stream) : base(0) { Read(stream); }

        public override int Read(Stream stream) {
            byte[] read = new byte[2];
            int bytesRead = stream.Read(read, 0, 2);

            Value = read.ReadBigEndianUS();
            return bytesRead;
        }

        public override void Write(Stream stream) {
            byte[] bytes = Value.WriteBigEndian();
            stream.Write(bytes);
        }
    }
}
