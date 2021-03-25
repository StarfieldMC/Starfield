using System.IO;
using fNbt;

namespace nylium.Core.Networking.DataTypes {

    public class NBT : DataType<NbtFile> {

        public NBT() : base(null) { }
        public NBT(NbtFile value) : base(value) { }
        public NBT(Stream stream) : base(null) { Read(stream); }

        public override void Read(Stream stream) {
            NbtFile file = new();
            file.LoadFromStream(stream, NbtCompression.AutoDetect);

            Value = file;
        }

        public override void Write(Stream stream) {
            Value.SaveToStream(stream, NbtCompression.None);
        }
    }
}
