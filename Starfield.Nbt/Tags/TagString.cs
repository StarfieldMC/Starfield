using System.IO;
using System.Text;
using Starfield.Extensions;

namespace Starfield.Nbt.Tags {

    public class TagString : Tag<string> {

        public TagString() : base(Type.TAG_String) { }
        public TagString(string name, string value) : base(Type.TAG_String, name, value) { }

        public override void Read(Stream stream, bool payloadOnly = false) {
            base.Read(stream, payloadOnly);

            byte[] buffer = new byte[2];
            stream.Read(buffer, 0, buffer.Length);

            ushort length = buffer.ReadBigEndianUS();

            buffer = new byte[length];
            stream.Read(buffer, 0, buffer.Length);

            Value = Encoding.UTF8.GetString(buffer);
        }

        public override void Write(Stream stream, bool payloadOnly = false) {
            base.Write(stream, payloadOnly);
            stream.Write(((ushort) Value.Length).WriteBigEndian());
            stream.Write(Encoding.UTF8.GetBytes(Value));
        }
    }
}
