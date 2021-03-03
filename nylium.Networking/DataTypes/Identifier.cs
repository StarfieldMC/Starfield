using System.IO;

namespace nylium.Networking.DataTypes {

    public class Identifier : DataType<ResourceLocation> {

        public Identifier() : base(new ResourceLocation("minecraft", "none")) { }
        public Identifier(ResourceLocation value) : base(value) { }

        public override int Read(Stream stream) {
            String str = new String();
            int bytesRead = str.Read(stream);

            string[] arr = str.Value.Split(":");
            Value = new ResourceLocation(arr[0], arr[1]);

            return bytesRead;
        }

        public override void Write(Stream stream) {
            String str = new String(Value.Namespace + ":" + Value.Id);
            str.Write(stream);
        }
    }

    public class ResourceLocation {

        public string Namespace { get; set; }
        public string Id { get; set; }

        public ResourceLocation(string _namespace, string id) {
            Namespace = _namespace;
            Id = id;
        }
    }
}
