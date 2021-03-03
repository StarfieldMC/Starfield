using System.IO;
using fNbt;

namespace nylium.Networking.DataTypes {

    public class NBT : DataType<NbtFile> {

        public NBT() : base(null) { }
        public NBT(NbtFile value) : base(value) { }

        public override void Read(Stream stream, out int bytesRead) {
            NbtFile file = new NbtFile();
            bytesRead = (int) file.LoadFromStream(stream, NbtCompression.AutoDetect);

            Value = file;
        }

        public override void Write(Stream stream) {
            // TODO benchmark zlib, gzip and none
            Value.SaveToStream(stream, NbtCompression.ZLib);
        }
    }
}
