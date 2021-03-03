using System.IO;
using Jil;
using nylium.Utilities;

namespace nylium.Networking.DataTypes {

    public class Chat : DataType<dynamic> {

        public Chat() : base(null) { }

        public override void Read(Stream stream, out int bytesRead) {
            String @string = new String();
            @string.Read(stream, out bytesRead);

            Value = JSON.DeserializeDynamic(@string.Value);
        }

        public override void Write(Stream stream) {
            String @string = new String(JSON.SerializeDynamic(Value));
            @string.Write(stream);
        }

        // awful hack because you can't use dynamic variables in base constructor or something
        public void SetValue(dynamic value) {
            Value = value;
        }
    }
}
