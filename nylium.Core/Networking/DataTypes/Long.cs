using System.IO;
using nylium.Extensions;

namespace nylium.Core.Networking.DataTypes {

    public class Long : DataType<long> {

        public Long() : base(0) { }
        public Long(long value) : base(value) { }
        public Long(Stream stream) : base(0) { Read(stream); }

        public override void Read(Stream stream) {
            byte[] read = new byte[8];
            stream.Read(read, 0, 8);

            Value = read.ReadBigEndianL();
        }

        public override void Write(Stream stream) {
            stream.Write(Value.WriteBigEndian());
        }
    }
}
