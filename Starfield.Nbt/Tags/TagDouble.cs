using System.IO;
using Starfield.Extensions;

namespace Starfield.Nbt.Tags {

    public class TagDouble : Tag<double> {

        public TagDouble() : base(Type.TAG_Double) { }
        public TagDouble(string name, double value) : base(Type.TAG_Double, name, value) { }

        public override void Read(Stream stream, bool payloadOnly = false) {
            base.Read(stream, payloadOnly);

            byte[] buffer = new byte[8];
            stream.Read(buffer, 0, buffer.Length);

            Value = buffer.ReadBigEndianD();
        }

        public override void Write(Stream stream, bool payloadOnly = false) {
            base.Write(stream, payloadOnly);
            stream.Write(Value.WriteBigEndian());
        }
    }
}
