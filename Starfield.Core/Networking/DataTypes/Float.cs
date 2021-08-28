using System.IO;
using Starfield.Extensions;

namespace Starfield.Core.Networking.DataTypes {

    public class Float : DataType<float> {

        public Float() : base(0) { }
        public Float(float value) : base(value) { }
        public Float(Stream stream) : base(0) { Read(stream); }

        public override void Read(Stream stream) {
            byte[] read = new byte[4];
            stream.Read(read, 0, 4);

            Value = read.ReadBigEndianF();
        }

        public override void Write(Stream stream) {
            stream.Write(Value.WriteBigEndian());
        }
    }
}
