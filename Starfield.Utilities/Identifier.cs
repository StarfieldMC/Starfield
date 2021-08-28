using System;

namespace Starfield.Utilities {

    public class Identifier {

        public string Namespace { get; }
        public string Id { get; }

        public Identifier(string @namespace, string id) {
            Namespace = string.IsNullOrWhiteSpace(@namespace) ? "minecraft" : @namespace;
            Id = id;
        }

        public Identifier(string id) {
            if(id.Contains(':')) {
                string[] split = id.Split(':');

                Namespace = split[0];
                Id = split[1];
            } else {
                Namespace = "minecraft";
                Id = id;
            }
        }

        public override string ToString() {
            return Namespace + ":" + Id;
        }

        public override bool Equals(object? obj) {
            if(obj == null) return false;
            if(obj is Identifier id) return id.Namespace == Namespace && id.Id == Id;
            return base.Equals(obj);
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 17;
                hash = (hash * 23) + Namespace.GetHashCode();
                hash = (hash * 23) + Id.GetHashCode();
                
                return hash;
            }
        }
    }
}
