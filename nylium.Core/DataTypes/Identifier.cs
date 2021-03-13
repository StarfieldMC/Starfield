using System.IO;
using U = nylium.Utilities;

namespace nylium.Core.DataTypes {

    public class Identifier : DataType<U.Identifier> {

        public Identifier() : base(null) { }
        public Identifier(U.Identifier value) : base(value) { }
        public Identifier(Stream stream) : base(null) { Read(stream); }

        public override int Read(Stream stream) {
            String str = new();
            int bytesRead = str.Read(stream);

            string[] arr = str.Value.Split(":");
            Value = new U.Identifier(arr[0], arr[1]);

            return bytesRead;
        }

        public override void Write(Stream stream) {
            String str = new(Value.ToString());
            str.Write(stream);
        }
    }
}
