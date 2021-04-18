using System.IO;
using nylium.Extensions;

namespace nylium.Nbt.Tags {

    public class TagByteArray : Tag<byte[]> {

        public TagByteArray() : base(Type.TAG_Byte_Array) { }
        public TagByteArray(string name, byte[] value) : base(Type.TAG_Byte_Array, name, value) { }

        public override void Read(Stream stream, bool payloadOnly = false) {
            base.Read(stream, payloadOnly);

            byte[] buffer = new byte[4];
            stream.Read(buffer, 0, buffer.Length);

            int length = buffer.ReadBigEndianI();

            Value = new byte[length];
            stream.Read(Value, 0, Value.Length);
        }

        public override void Write(Stream stream, bool payloadOnly = false) {
            base.Write(stream, payloadOnly);
            stream.Write(Value.Length.WriteBigEndian());
            stream.Write(Value);
        }
    }
}
