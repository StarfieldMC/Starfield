using System.IO;
using nylium.Extensions;

namespace nylium.Nbt.Tags {

    public class TagLong : Tag<long> {

        public TagLong() : base(Type.TAG_Long) { }
        public TagLong(string name, long value) : base(Type.TAG_Long, name, value) { }

        public override void Read(Stream stream, bool payloadOnly = false) {
            base.Read(stream, payloadOnly);

            byte[] buffer = new byte[8];
            stream.Read(buffer, 0, buffer.Length);

            Value = buffer.ReadBigEndianL();
        }

        public override void Write(Stream stream, bool payloadOnly = false) {
            base.Write(stream, payloadOnly);
            stream.Write(Value.WriteBigEndian());
        }
    }
}
