using System.IO;

namespace Starfield.Nbt.Tags {

    public class TagEnd : Tag<object> {

        public TagEnd() : base(Type.TAG_Byte) { }

        public override void Read(Stream stream, bool payloadOnly = false) { }
        public override void Write(Stream stream, bool payloadOnly = false) { }
    }
}
