﻿using System;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x3F, ProtocolState.Play, PacketSide.Server)]
    public class SP3FHeldItemChange : NetworkPacket {

        public sbyte Slot { get; }

        public SP3FHeldItemChange(sbyte slot) {
            Slot = slot;

            WriteByte(slot);
        }
    }
}