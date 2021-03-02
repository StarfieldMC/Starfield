using System.IO;

namespace nylium.Networking.DataTypes {

    public class Byte : DataType<sbyte> {

        public Byte() : base(0) { }
        public Byte(sbyte value) : base(value) { }

        public override void Read(Stream stream, out int bytesRead) {
            bytesRead = 0;
            byte[] read = new byte[1];

            stream.Read(read, 0, 1);
            bytesRead++;

            Value = (sbyte) read[0];
        }

        public override void Write(Stream stream) {
            stream.WriteByte((byte) Value);
        }
    }
}
