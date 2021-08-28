using Starfield.Core.Entity.Inventories;
using Starfield.Core.Networking.DataTypes;

namespace Starfield.Core.Networking.Packet.Server.Play {

    [Packet(0x13, ProtocolState.Play, PacketSide.Server)]
    public class SP13WindowItems : MinecraftPacket {

        public byte WindowId { get; }
        public Inventory.Slot[] SlotData { get; }

        public SP13WindowItems(MinecraftClient client, byte windowId, Inventory.Slot[] slotData) : base(client) {
            WindowId = Data.WriteUnsignedByte(windowId);
            Data.WriteShort((short) slotData.Length);
            SlotData = Data.WriteArray<Inventory.Slot, Slot>(slotData);
        }
    }
}