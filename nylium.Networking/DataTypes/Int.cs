using System.IO;
using nylium.Extensions;

namespace nylium.Networking.DataTypes {

    public class Int : DataType<int> {

        public Int() : base(0) { }
        public Int(int value) : base(value) { }

        public override void Read(Stream stream, out int bytesRead) {
            bytesRead = 0;
            byte[] read = new byte[4];

            stream.Read(read, 0, 4);
            bytesRead += 4;

            Value = read.ReadBigEndianI();
        }

        public override void Write(Stream stream) {
            byte[] bytes = Value.WriteBigEndian();
            stream.Write(bytes);
        }
    }
}
