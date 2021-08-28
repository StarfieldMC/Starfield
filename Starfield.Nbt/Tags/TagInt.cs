using System.IO;
using Starfield.Extensions;

namespace Starfield.Nbt.Tags {

    public class TagInt : Tag<int> {

        public TagInt() : base(Type.TAG_Int) { }
        public TagInt(string name, int value) : base(Type.TAG_Int, name, value) { }

        public override void Read(Stream stream, bool payloadOnly = false) {
            base.Read(stream, payloadOnly);

            byte[] buffer = new byte[4];
            stream.Read(buffer, 0, buffer.Length);

            Value = buffer.ReadBigEndianI();
        }

        public override void Write(Stream stream, bool payloadOnly = false) {
            base.Write(stream, payloadOnly);
            stream.Write(Value.WriteBigEndian());
        }
    }
}
