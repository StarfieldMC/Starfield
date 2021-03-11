using System.IO;
using System.Text;

namespace nylium.Networking.DataTypes {

    public class String : DataType<string> {

        public String() : base(null) { }
        public String(string value) : base(value) { }
        public String(Stream stream) : base(null) { Read(stream); }

        public override int Read(Stream stream) {
            VarInt length = new();
            int bytesRead = length.Read(stream);

            byte[] read = new byte[length.Value];

            bytesRead += stream.Read(read, 0, length.Value);

            Value = Encoding.UTF8.GetString(read);
            return bytesRead;
        }

        public override void Write(Stream stream) {
            byte[] bytes = Encoding.UTF8.GetBytes(Value);

            new VarInt(bytes.Length).Write(stream);
            stream.Write(bytes);
        }
    }
}
