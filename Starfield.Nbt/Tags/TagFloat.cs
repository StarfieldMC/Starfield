using System.IO;
using Starfield.Extensions;

namespace Starfield.Nbt.Tags {

    public class TagFloat : Tag<float> {

        public TagFloat() : base(Type.TAG_Float) { }
        public TagFloat(string name, float value) : base(Type.TAG_Float, name, value) { }

        public override void Read(Stream stream, bool payloadOnly = false) {
            base.Read(stream, payloadOnly);

            byte[] buffer = new byte[4];
            stream.Read(buffer, 0, buffer.Length);

            Value = buffer.ReadBigEndianF();
        }

        public override void Write(Stream stream, bool payloadOnly = false) {
            base.Write(stream, payloadOnly);
            stream.Write(Value.WriteBigEndian());
        }
    }
}
