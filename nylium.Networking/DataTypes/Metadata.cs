using System;
using System.IO;

namespace nylium.Networking.DataTypes {

    public class Metadata {

        public class Entity {

            public Entry[] Entries { get; set; }

            public Entity(params Entry[] entries) {
                Entries = entries;
            }

            public class Entry {

                public byte Index { get; }
                public Type Type { get; }
                public dynamic Value { get; }

                public Entry(byte index, Type type, dynamic value) {
                    Index = index;
                    Type = type;
                    Value = value;
                }
            }
        }
    }

    // i dont know how the hell to do this properly
    public class EntityMetadata : DataType<Metadata.Entity> {

        public EntityMetadata() : base(null) { }
        public EntityMetadata(Metadata.Entity value) : base(value) { }

        public override void Read(Stream stream, out int bytesRead) {
            bytesRead = 0;
            MemoryStream _stream = new MemoryStream();
            byte[] read = new byte[1] { 0x00 };
            int offset = 0;

            while(read[0] != 0xff) {
                stream.Read(read, offset, 1);
                ReadEntry(read[0], offset);
            }

            
        }

        private void ReadEntry(byte b, int offset) {
            if(b == 0xff) return;


        }

        public override void Write(Stream stream) {
            throw new NotImplementedException();
        }
    }
}
