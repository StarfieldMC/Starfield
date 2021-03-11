using System;

namespace nylium.Utilities {

    public class Identifier {

        public string Namespace { get; set; }
        public string Id { get; set; }

        public Identifier(string _namespace, string id) {
            Namespace = _namespace;
            Id = id;
        }

        public Identifier(string id) {
            Id = id;
        }

        public override string ToString() {
            return string.IsNullOrWhiteSpace(Namespace) ? Id : Namespace + ":" + Id;
        }
    }
}
