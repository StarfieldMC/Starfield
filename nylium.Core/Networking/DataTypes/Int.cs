using System.IO;
using nylium.Extensions;

namespace nylium.Core.Networking.DataTypes {

    public class Int : DataType<int> {

        public Int() : base(0) { }
        public Int(int value) : base(value) { }
        public Int(Stream stream) : base(0) { Read(stream); }

        public override void Read(Stream stream) {
            byte[] read = new byte[4];
            stream.Read(read, 0, 4);

            Value = read.ReadBigEndianI();
        }

        public override void Write(Stream stream) {
            stream.Write(Value.WriteBigEndian());
        }
    }
}
