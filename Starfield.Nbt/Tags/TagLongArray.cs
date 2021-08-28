using System.IO;
using Starfield.Extensions;

namespace Starfield.Nbt.Tags {

    public class TagLongArray : Tag<long[]> {

        public TagLongArray() : base(Type.TAG_Long_Array) { }
        public TagLongArray(string name, long[] value) : base(Type.TAG_Long_Array, name, value) { }

        public override void Read(Stream stream, bool payloadOnly = false) {
            base.Read(stream, payloadOnly);

            byte[] buffer = new byte[4];
            stream.Read(buffer, 0, buffer.Length);

            int length = buffer.ReadBigEndianI();
            Value = new long[length];
            buffer = new byte[8];

            int i = 0;

            while(i < length) {
                stream.Read(buffer, 0, buffer.Length);
                Value[i] = buffer.ReadBigEndianL();

                i++;
            }
        }

        public override void Write(Stream stream, bool payloadOnly = false) {
            base.Write(stream, payloadOnly);
            stream.Write(Value.Length.WriteBigEndian());

            for(int i = 0; i < Value.Length; i++) {
                stream.Write(Value[i].WriteBigEndian());
            }
        }
    }
}
