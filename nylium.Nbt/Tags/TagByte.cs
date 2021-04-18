using System.IO;

namespace nylium.Nbt.Tags {

    public class TagByte : Tag<byte> {

        public TagByte() : base(Type.TAG_Byte) { }
        public TagByte(string name, byte value) : base(Type.TAG_Byte, name, value) { }

        public override void Read(Stream stream, bool payloadOnly = false) {
            base.Read(stream, payloadOnly);
            Value = (byte) stream.ReadByte();
        }

        public override void Write(Stream stream, bool payloadOnly = false) {
            base.Write(stream, payloadOnly);
            stream.WriteByte(Value);
        }
    }
}
