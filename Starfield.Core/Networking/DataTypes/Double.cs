using System.IO;
using Starfield.Extensions;

namespace Starfield.Core.Networking.DataTypes {

    public class Double : DataType<double> {

        public Double() : base(0) { }
        public Double(double value) : base(value) { }
        public Double(Stream stream) : base(0) { Read(stream); }

        public override void Read(Stream stream) {
            byte[] read = new byte[8];
            stream.Read(read, 0, 8);

            Value = read.ReadBigEndianD();
        }

        public override void Write(Stream stream) {
            stream.Write(Value.WriteBigEndian());
        }
    }
}
