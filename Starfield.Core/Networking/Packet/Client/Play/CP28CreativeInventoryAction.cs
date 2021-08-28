using System.IO;
using Starfield.Core.Entity.Inventories;

namespace Starfield.Core.Networking.Packet.Client.Play {

    [Packet(0x28, ProtocolState.Play, PacketSide.Client)]
    public class CP28CreativeInventoryAction : MinecraftPacket {

        public short Slot { get; }
        public Inventory.Slot ClickedItem { get; }

        public CP28CreativeInventoryAction(MinecraftClient client, Stream stream) : base(client, stream) {
            Slot = Data.ReadShort();
            ClickedItem = Data.ReadSlot();
        }
    }
}