using System;
using nylium.Core.DataTypes;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x40, ProtocolState.Play, PacketSide.Server)]
    public class SP40UpdateViewPosition : NetworkPacket {

        public int ChunkX { get; }
        public int ChunkZ { get; }

        public SP40UpdateViewPosition(int chunkX, int chunkZ) {
            ChunkX = chunkX;
            ChunkZ = chunkZ;

            WriteVarInt(chunkX);
            WriteVarInt(chunkZ);
        }
    }
}