using System.IO;
using nylium.Extensions;

namespace nylium.Nbt.Tags {

    public class TagIntArray : Tag<int[]> {

        public TagIntArray() : base(Type.TAG_Int_Array) { }
        public TagIntArray(string name, int[] value) : base(Type.TAG_Int_Array, name, value) { }

        public override void Read(Stream stream, bool payloadOnly = false) {
            base.Read(stream, payloadOnly);

            byte[] buffer = new byte[4];
            stream.Read(buffer, 0, buffer.Length);

            int length = buffer.ReadBigEndianI();
            Value = new int[length];

            int i = 0;

            while(i < length) {
                stream.Read(buffer, 0, buffer.Length);
                Value[i] = buffer.ReadBigEndianI();

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
