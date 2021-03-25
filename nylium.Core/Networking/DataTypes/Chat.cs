using System.IO;
using Jil;

namespace nylium.Core.Networking.DataTypes {

    public class Chat : DataType<dynamic> {

        public Chat() : base(null) { }
        public Chat(dynamic json) : base(null) { Value = json; }
        public Chat(Stream stream) : base(null) { Read(stream); }

        public override void Read(Stream stream) {
            Value = JSON.DeserializeDynamic(new String(stream).Value);
        }

        public override void Write(Stream stream) {
            new String(JSON.SerializeDynamic(Value)).Write(stream);
        }
    }
}
