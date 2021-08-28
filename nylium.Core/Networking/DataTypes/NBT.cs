using System.IO;
using nylium.Nbt;

namespace nylium.Core.Networking.DataTypes {

    public class NBT : DataType<NBTFile> {

        public NBT() : base(null) { }
        public NBT(NBTFile value) : base(value) { }
        public NBT(Stream stream) : base(null) { Read(stream); }

        public override void Read(Stream stream) {
            Value = new NBTFile().Read(stream);
        }

        public override void Write(Stream stream) {
            Value.Write(stream);
        }
    }
}
