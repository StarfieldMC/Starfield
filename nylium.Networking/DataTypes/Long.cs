using System.IO;
using nylium.Extensions;

namespace nylium.Networking.DataTypes {

    public class Long : DataType<long> {

        public Long() : base(0) { }
        public Long(long value) : base(value) { }
        public Long(Stream stream) : base(0) { Read(stream); }

        public override int Read(Stream stream) {
            byte[] read = new byte[8];
            int bytesRead = stream.Read(read, 0, 8);

            Value = read.ReadBigEndianL();
            return bytesRead;
        }

        public override void Write(Stream stream) {
            byte[] bytes = Value.WriteBigEndian();
            stream.Write(bytes);
        }
    }
}
