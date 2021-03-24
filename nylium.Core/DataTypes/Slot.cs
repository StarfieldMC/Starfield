using System.IO;
using nylium.Core.Entity.Inventory;
using nylium.Utilities;

namespace nylium.Core.DataTypes {

    public class Slot : DataType<EntityInventory.Slot> {

        public Slot() : base(null) { }
        public Slot(EntityInventory.Slot value) : base(value) { }
        public Slot(Stream stream) : base(null) { Read(stream); }

        public override int Read(Stream stream) {
            Boolean boolean = new();
            int bytesRead = boolean.Read(stream);

            VarInt itemId = new();
            bytesRead += itemId.Read(stream);

            Byte @byte = new();
            bytesRead += @byte.Read(stream);

            NBT nbt = null;

            if(!NBTUtils.IsTagEnd(stream)) {
                nbt = new NBT();
                bytesRead += nbt.Read(stream);
            }

            Value = new EntityInventory.Slot(boolean.Value, itemId.Value, @byte.Value, nbt?.Value);
            return bytesRead;
        }

        public override void Write(Stream stream) {
            Boolean boolean = new(Value.Present);
            boolean.Write(stream);

            VarInt varInt = new(Value.Item.Id);
            varInt.Write(stream);

            Byte @byte = new(Value.Count);
            @byte.Write(stream);

            NBT nbt = new(Value.NBT);
            nbt.Write(stream);
        }
    }
}
