using System.IO;
using Starfield.Extensions;

namespace Starfield.Core.Networking.DataTypes {

    public class Short : DataType<short> {

        public Short() : base(0) { }
        public Short(short value) : base(value) { }
        public Short(Stream stream) : base(0) { Read(stream); }

        public override void Read(Stream stream) {
            byte[] read = new byte[2];
            stream.Read(read, 0, 2);

            Value = read.ReadBigEndianS();
        }

        public override void Write(Stream stream) {
            stream.Write(Value.WriteBigEndian());
        }
    }
}
