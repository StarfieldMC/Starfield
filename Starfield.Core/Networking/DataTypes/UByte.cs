using System.IO;

namespace Starfield.Core.Networking.DataTypes {

    public class UByte : DataType<byte> {

        public UByte() : base(0) { }
        public UByte(byte value) : base(value) { }
        public UByte(Stream stream) : base(0) { Read(stream); }

        public override void Read(Stream stream) {
            byte[] read = new byte[1];
            stream.Read(read, 0, 1);

            Value = read[0];
        }

        public override void Write(Stream stream) {
            stream.WriteByte(Value);
        }
    }
}
