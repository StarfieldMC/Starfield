using System.IO;

namespace Starfield.Core.Networking.DataTypes {

    public class Identifier : DataType<Utilities.Identifier> {

        public Identifier() : base(null) { }
        public Identifier(Utilities.Identifier value) : base(value) { }
        public Identifier(Stream stream) : base(null) { Read(stream); }

        public override void Read(Stream stream) {
            String str = new();
            str.Read(stream);

            string[] arr = str.Value.Split(":");
            Value = new Utilities.Identifier(arr[0], arr[1]);
        }

        public override void Write(Stream stream) {
            new String(Value.ToString()).Write(stream);
        }
    }
}
