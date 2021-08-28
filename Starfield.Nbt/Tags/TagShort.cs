using System.IO;
using Starfield.Extensions;

namespace Starfield.Nbt.Tags {

    public class TagShort : Tag<short> {

        public TagShort() : base(Type.TAG_Short) { }
        public TagShort(string name, short value) : base(Type.TAG_Short, name, value) { }

        public override void Read(Stream stream, bool payloadOnly = false) {
            base.Read(stream, payloadOnly);

            byte[] buffer = new byte[2];
            stream.Read(buffer, 0, buffer.Length);

            Value = buffer.ReadBigEndianS();
        }

        public override void Write(Stream stream, bool payloadOnly = false) {
            base.Write(stream, payloadOnly);
            stream.Write(Value.WriteBigEndian());
        }
    }
}
