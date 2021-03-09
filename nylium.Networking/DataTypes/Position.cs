using System.IO;
using nylium.Extensions;
using U = nylium.Utilities;

namespace nylium.Networking.DataTypes {

    public class Position : DataType<U.Position.Int> {

        public Position() : base(null) { }
        public Position(U.Position.Int value) : base(value) { }

        public override int Read(Stream stream) {
            byte[] read = new byte[8];
            int bytesRead = stream.Read(read, 0, 8);

            ulong val = read.ReadBigEndianUL();

            int x = (int) (val >> 38);
            int y = (int) (val & 0xFFF);
            int z = (int) ((val << 26 >> 38));

            if(x >= (2 ^ 25)) { x -= 2 ^ 26; }
            if(y >= (2 ^ 11)) { y -= 2 ^ 12; }
            if(z >= (2 ^ 25)) { z -= 2 ^ 26; }

            Value = new U.Position.Int(x, y, z);
            return bytesRead;
        }

        public override void Write(Stream stream) {
            stream.Write((((Value.X & 0x3FFFFFF) << 38) | ((Value.Z & 0x3FFFFFF) << 12) | (Value.Y & 0xFFF)).WriteBigEndian());
        }
    }
}
