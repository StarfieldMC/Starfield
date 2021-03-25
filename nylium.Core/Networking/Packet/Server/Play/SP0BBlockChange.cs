using System;
using System.IO;
using nylium.Extensions;
using nylium.Utilities;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x0B, ProtocolState.Play, PacketSide.Server)]
    public class SP0BBlockChange : MinecraftPacket {

        public Position.Int Location { get; }
        public int BlockId { get; }

        public SP0BBlockChange(Position.Int location, int blockId) {
            Location = location;
            BlockId = blockId;

            WritePosition(location);
            WriteVarInt(blockId);
        }
    }
}