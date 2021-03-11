using System.IO;
using nylium.Extensions;

namespace nylium.Networking.DataTypes {

    public class Double : DataType<double> {

        public Double() : base(0) { }
        public Double(double value) : base(value) { }
        public Double(Stream stream) : base(0) { Read(stream); }

        public override int Read(Stream stream) {
            byte[] read = new byte[8];
            int bytesRead = stream.Read(read, 0, 8);

            Value = read.ReadBigEndianD();

            return bytesRead;
        }

        public override void Write(Stream stream) {
            byte[] bytes = Value.WriteBigEndian();
            stream.Write(bytes);
        }
    }
}
