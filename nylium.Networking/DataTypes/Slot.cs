using System.IO;
using nylium.Core.Entity.Inventory;
using nylium.Utilities;

namespace nylium.Networking.DataTypes {

    public class Slot : DataType<InventorySlot> {

        public Slot() : base(null) { }
        public Slot(InventorySlot value) : base(value) { }

        public override int Read(Stream stream) {
            Boolean boolean = new Boolean();
            int bytesRead = boolean.Read(stream);

            if(boolean.Value) {
                VarInt itemId = new VarInt();
                bytesRead += itemId.Read(stream);

                Byte count = new Byte();
                bytesRead += count.Read(stream);

                NBT nbt = null;

                if(!NBTUtils.IsTagEnd(stream)) {
                    nbt = new NBT();
                    bytesRead += nbt.Read(stream);
                }

                Value = new InventorySlot(itemId.Value, count.Value, nbt?.Value);
            } else {
                Value = null;
            }

            return bytesRead;
        }

        public override void Write(Stream stream) {
            throw new System.NotImplementedException();
        }
    }
}
