﻿using System;
using nylium.Core.DataTypes;
using U = nylium.Utilities;

namespace nylium.Core.Packet.Server.Play {

    [Packet(0x42, ProtocolState.Play, PacketSide.Server)]
    public class SP42SpawnPosition : NetworkPacket {

        public U.Position.Int Location { get; }

        public SP42SpawnPosition(U.Position.Int location) {
            Location = location;

            WritePosition(location);
        }
    }
}