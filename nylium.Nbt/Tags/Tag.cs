using System.IO;
using System.Text;
using nylium.Extensions;

namespace nylium.Nbt.Tags {

    public class Tag<T> {

        public Type TagType { get; set; }

        public string Name { get; set; }
        public T Value { get; set; }

        public Tag(Type type) {
            TagType = type;
        }

        public Tag(Type type, string name, T value) {
            TagType = type;
            Name = name;
            Value = value;
        }

        public virtual void Read(Stream stream, bool payloadOnly = false) {
            if(!payloadOnly) {
                TagType = (Type) stream.ReadByte();

                byte[] buffer = new byte[2];
                stream.Read(buffer, 0, buffer.Length);

                ushort nameLength = buffer.ReadBigEndianUS();

                if(nameLength > 0) {
                    buffer = new byte[nameLength];
                    stream.Read(buffer, 0, buffer.Length);

                    Name = Encoding.UTF8.GetString(buffer);
                }
            }
        }

        public virtual void Write(Stream stream, bool payloadOnly = false) {
            if(!payloadOnly) {
                stream.WriteByte((byte) TagType);
                stream.Write(((ushort) Name.Length).WriteBigEndian());
                stream.Write(Encoding.UTF8.GetBytes(Name));
            }
        }

        public enum Type : int {

            TAG_End,
            TAG_Byte,
            TAG_Short,
            TAG_Int,
            TAG_Long,
            TAG_Float,
            TAG_Double,
            TAG_Byte_Array,
            TAG_String,
            TAG_List,
            TAG_Compound,
            TAG_Int_Array,
            TAG_Long_Array
        }
    }
}
