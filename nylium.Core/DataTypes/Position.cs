using System;
using System.Buffers.Binary;
using System.IO;
using nylium.Extensions;
using U = nylium.Utilities;

namespace nylium.Core.DataTypes {

    public class Position : DataType<U.Position.Int> {

        public Position() : base(null) { }
        public Position(U.Position.Int value) : base(value) { }
        public Position(Stream stream) : base(null) { Read(stream); }

        public override int Read(Stream stream) {
            byte[] read = new byte[8];
            int bytesRead = stream.Read(read, 0, 8);

            long val = BinaryPrimitives.ReadInt64BigEndian(read);

            int x = (int) (val >> 38);
            int y = (int) (val & 0xFFF);
            int z = (int) ((val << 26 >> 38));

            Value = new U.Position.Int(x, y, z);
            return bytesRead;
        }

        public override void Write(Stream stream) {
            byte[] b = new byte[8];

            long encoded = (long) (Value.X & 0x3FFFFFF) << 38;
            encoded |= (long) (Value.Z & 0x3FFFFFF) << 12;
            encoded |= (long) (Value.Y & 0xFFF);

            BinaryPrimitives.WriteInt64BigEndian(b, encoded);

            stream.Write(b);
        }
    }
}
