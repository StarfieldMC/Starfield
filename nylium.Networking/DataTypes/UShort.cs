using System;
using System.IO;
using System.Linq;

namespace nylium.Networking.DataTypes {

    class UShort : DataType<ushort> {

        public UShort() : base(0) { }
        public UShort(ushort value) : base(value) { }

        public override void Read(Stream stream, out int bytesRead) {
            bytesRead = 0;
            byte[] read = new byte[2];

            stream.Read(read, 0, 2);
            bytesRead += 2;

            Value = (ushort) ((read[0] << 8) | read[1]); // reverse
        }

        public override void Write(Stream stream) {
            stream.Write(BitConverter.GetBytes(Value).Reverse().ToArray());
        }
    }
}
