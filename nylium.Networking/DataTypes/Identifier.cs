using System.IO;

namespace nylium.Networking.DataTypes {

    public class Identifier : DataType<ResourceLocation> {

        public Identifier() : base(new ResourceLocation("minecraft", "none")) { }
        public Identifier(ResourceLocation value) : base(value) { }

        public override void Read(Stream stream, out int bytesRead) {
            String str = new String();
            str.Read(stream, out bytesRead);

            string[] arr = str.Value.Split(":");
            Value = new ResourceLocation(arr[0], arr[1]);
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
