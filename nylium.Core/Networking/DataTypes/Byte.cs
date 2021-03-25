using System.IO;

namespace nylium.Core.Networking.DataTypes {

    public class Byte : DataType<sbyte> {

        public Byte() : base(0) { }
        public Byte(sbyte value) : base(value) { }
        public Byte(Stream stream) : base(0) { Read(stream); }

        public override void Read(Stream stream) {
            byte[] read = new byte[1];
            stream.Read(read, 0, 1);

            Value = (sbyte) read[0];
        }

        public override void Write(Stream stream) {
            stream.WriteByte((byte) Value);
        }
    }
}
