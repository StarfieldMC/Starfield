using System.IO;
using nylium.Core.Entity.Inventories;

namespace nylium.Core.Networking.Packet.Client.Play {

    [Packet(0x28, ProtocolState.Play, PacketSide.Client)]
    public class CP28CreativeInventoryAction : MinecraftPacket {

        public short Slot { get; }
        public Inventory.Slot ClickedItem { get; }

        public CP28CreativeInventoryAction(Stream stream) : base(stream) {
            Slot = ReadShort();
            ClickedItem = ReadSlot();
        }
    }
}