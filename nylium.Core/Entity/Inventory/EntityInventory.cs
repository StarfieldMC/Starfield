using fNbt;
using nylium.Core.Item;
using Serilog;

namespace nylium.Core.Entity.Inventory {

    public class EntityInventory {

        public GameEntity Parent { get; }

        public Slot[] Slots { get; set; }
        public int HeldSlot { get; set; }

        public GameItem HeldItem {
            get {
                return Slots[HeldSlot].IsEmpty() ? null : Slots[HeldSlot].Item;
            }
        }

        public EntityInventory(GameEntity parent, int slotCount) {
            Parent = parent;
            Slots = new Slot[slotCount];
        }

        public EntityInventory(GameEntity parent, Slot[] slots, int heldSlot) {
            Parent = parent;
            Slots = slots;
            HeldSlot = heldSlot;
        }

        public class Slot {

            public static Slot Empty { get; } = new Slot(false, null, 0, null);

            public bool Present { get; }
            public GameItem Item { get; }
            public sbyte Count { get; }
            public NbtFile NBT { get; }

            public Slot(bool present, GameItem item, sbyte count, NbtFile nbt) {
                Present = present;
                Item = item;
                Count = count;
                NBT = nbt;
            }

            public Slot(bool present, int itemId, sbyte count, NbtFile nbt) {
                Present = present;
                Item = (itemId == 0 || itemId == -1) ? null : new(this, itemId);
                Count = count;
                NBT = nbt;
            }

            public bool IsEmpty() {
                return Present == false || Item == null || Count == 0;
            }
        }
    }
}