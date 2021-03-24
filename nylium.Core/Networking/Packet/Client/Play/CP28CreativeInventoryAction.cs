using System.IO;
using nylium.Core.Entity.Inventory;

namespace nylium.Core.Networking.Packet.Client.Play {

    [Packet(0x28, ProtocolState.Play, PacketSide.Client)]
    public class CP28CreativeInventoryAction : NetworkPacket {

        public short Slot { get; }
        public EntityInventory.Slot ClickedItem { get; }

        public CP28CreativeInventoryAction(Stream stream) : base(stream) {
            Slot = ReadShort();
            ClickedItem = ReadSlot();
        }
    }
}