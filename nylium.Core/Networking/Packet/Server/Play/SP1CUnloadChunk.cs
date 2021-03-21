using System;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x1C, ProtocolState.Play, PacketSide.Server)]
    public class SP1CUnloadChunk : NetworkPacket {

        public int ChunkX { get; }
        public int ChunkZ { get; }

        public SP1CUnloadChunk(int chunkX, int chunkZ) {
            ChunkX = chunkX;
            ChunkZ = chunkZ;

            WriteInt(ChunkX);
            WriteInt(ChunkZ);
        }
    }
}