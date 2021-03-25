using System.IO;
using nylium.Core.Entity.Inventories;
using nylium.Utilities;

namespace nylium.Core.Networking.DataTypes {

    public class Slot : DataType<Inventory.Slot> {

        public Slot() : base(null) { }
        public Slot(Inventory.Slot value) : base(value) { }
        public Slot(Stream stream) : base(null) { Read(stream); }

        public override void Read(Stream stream) {
            Boolean boolean = new(stream);
            VarInt itemId = new(stream);
            Byte @byte = new(stream);

            NBT nbt = null;

            if(!NBTUtils.IsTagEnd(stream)) {
                nbt = new NBT(stream);
            }

            Value = new Inventory.Slot(boolean.Value, itemId.Value, @byte.Value, nbt?.Value);
        }

        public override void Write(Stream stream) {
            new Boolean(Value.Present).Write(stream);
            new VarInt(Value.Item.Id).Write(stream);
            new Byte(Value.Count).Write(stream);
            new NBT(Value.NBT).Write(stream);
        }
    }
}
