using System.IO;
using nylium.Extensions;

namespace nylium.Networking.DataTypes {

    public class Double : DataType<double> {

        public Double() : base(0) { }
        public Double(double value) : base(value) { }

        public override void Read(Stream stream, out int bytesRead) {
            bytesRead = 0;
            byte[] read = new byte[8];

            stream.Read(read, 0, 8);
            bytesRead += 8;

            Value = read.ReadBigEndianD();
        }

        public override void Write(Stream stream) {
            byte[] bytes = Value.WriteBigEndian();
            stream.Write(bytes);
        }
    }
}
