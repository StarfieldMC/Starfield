using System.IO;

namespace nylium.Networking.DataTypes {

    public class UByte : DataType<byte> {

        public UByte() : base(0) { }
        public UByte(byte value) : base(value) { }

        public override void Read(Stream stream, out int bytesRead) {
            bytesRead = 0;
            byte[] read = new byte[1];

            stream.Read(read, 0, 1);
            bytesRead++;

            Value = read[0];
        }

        public override void Write(Stream stream) {
            stream.WriteByte(Value);
        }
    }
}
