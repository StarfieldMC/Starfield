using System.IO;
using fNbt;

namespace nylium.Networking.DataTypes {

    public class NBT : DataType<NbtFile> {

        public NBT() : base(null) { }
        public NBT(NbtFile value) : base(value) { }

        public override int Read(Stream stream) {
            NbtFile file = new NbtFile();
            int bytesRead = (int) file.LoadFromStream(stream, NbtCompression.AutoDetect);

            Value = file;
            return bytesRead;
        }

        public override void Write(Stream stream) {
            // TODO benchmark zlib, gzip and none
            Value.SaveToStream(stream, NbtCompression.ZLib);
        }
    }
}
