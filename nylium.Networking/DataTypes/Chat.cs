using System.IO;
using Jil;
using nylium.Utilities;

namespace nylium.Networking.DataTypes {

    public class Chat : DataType<dynamic> {

        public Chat() : base(null) { }

        public override int Read(Stream stream) {
            String @string = new String();
            int bytesRead = @string.Read(stream);

            Value = JSON.DeserializeDynamic(@string.Value);
            return bytesRead;
        }

        public override void Write(Stream stream) {
            String @string = new String(Value);
            @string.Write(stream);
        }

        // awful hack because you can't use dynamic variables in base constructor or something
        // TODO find a better way to do this
        public void SetValue(dynamic value) {
            Value = value;
        }
    }
}
