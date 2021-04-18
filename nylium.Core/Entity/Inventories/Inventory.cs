using nylium.Core.Items;
using nylium.Nbt.Tags;

namespace nylium.Core.Entity.Inventories {

    public class Inventory {

        public BaseEntity Parent { get; }

        public Slot[] Slots { get; set; }
        public int HeldSlot { get; set; }

        public Inventory(BaseEntity parent, int slotCount) {
            Parent = parent;
            Slots = new Slot[slotCount];
        }

        public Inventory(BaseEntity parent, Slot[] slots, int heldSlot) {
            Parent = parent;
            Slots = slots;
            HeldSlot = heldSlot;
        }

        public class Slot {

            public static Slot Empty { get; } = new Slot(false, null, 0, null);

            public bool Present { get; }
            public Item Item { get; }
            public sbyte Count { get; }
            public TagCompound NBT { get; }

            public Slot(bool present, Item item, sbyte count, TagCompound nbt) {
                Present = present;
                Item = item;
                Count = count;
                NBT = nbt;
            }

            public Slot(bool present, int itemId, sbyte count, TagCompound nbt) {
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