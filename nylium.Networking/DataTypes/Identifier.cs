using System.IO;
using U = nylium.Utilities;

namespace nylium.Networking.DataTypes {

    public class Identifier : DataType<U.Identifier> {

        public Identifier() : base(new U.Identifier("minecraft", "none")) { }
        public Identifier(U.Identifier value) : base(value) { }

        public override int Read(Stream stream) {
            String str = new String();
            int bytesRead = str.Read(stream);

            string[] arr = str.Value.Split(":");
            Value = new U.Identifier(arr[0], arr[1]);

            return bytesRead;
        }

        public override void Write(Stream stream) {
            String str = new String(Value.Namespace + ":" + Value.Id);
            str.Write(stream);
        }
    }
}
