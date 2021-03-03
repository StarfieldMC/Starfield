using System;
using fNbt;

namespace nylium.Core.Inventory {

    public class InventorySlot {

        public int ItemId { get; }
        public sbyte Count { get; }
        public NbtFile NBT { get; }

        public InventorySlot(int itemId, sbyte count, NbtFile nbt) {
            ItemId = itemId;
            Count = count;
            NBT = nbt;
        }
    }
}
