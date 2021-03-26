using System;
using nylium.Core.Entity.Inventories;
using nylium.Core.Networking.DataTypes;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x13, ProtocolState.Play, PacketSide.Server)]
    public class SP13WindowItems : MinecraftPacket {

        public byte WindowId { get; }
        public Inventory.Slot[] SlotData { get; }

        public SP13WindowItems(byte windowId, Inventory.Slot[] slotData) {
            WindowId = windowId;
            SlotData = slotData;

            WriteUnsignedByte(windowId);
            WriteShort((short) slotData.Length);
            WriteArray<Inventory.Slot, Slot>(slotData);
        }
    }
}