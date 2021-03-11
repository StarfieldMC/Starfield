using System;

namespace nylium.Networking.Packets.Server.Play {

    [Packet(0x3F, ProtocolState.Play, PacketSide.Server)]
    public class SP3FHeldItemChange : Packet {

        public sbyte Slot { get; }

        public SP3FHeldItemChange(sbyte slot) {
            Slot = slot;

            DataTypes.Byte @byte = new(slot);
            @byte.Write(Data);
        }
    }
}