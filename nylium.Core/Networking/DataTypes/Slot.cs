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
            
            if(boolean.Value) {
                VarInt itemId = new(stream);
                Byte @byte = new(stream);

                NBT nbt = null;

                if(!NBTUtils.IsTagEnd(stream)) {
                    nbt = new NBT(stream);
                }

                Value = new Inventory.Slot(boolean.Value, itemId.Value, @byte.Value, nbt?.Value);
            } else {
                Value = Inventory.Slot.Empty;
            }
        }

        public override void Write(Stream stream) {
            new Boolean(Value.Present).Write(stream);
            
            if(Value.Present) {
                new VarInt(Value.Item.Id).Write(stream);
                new Byte(Value.Count).Write(stream);
                
                if(Value.NBT == null) {
                    stream.WriteByte(0x00); // TAG_END
                } else {
                    new NBT(Value.NBT).Write(stream);
                }
            }
        }
    }
}
