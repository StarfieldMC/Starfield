using System;
using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Server.Play {

    [Packet(0x40, ProtocolState.Play, PacketSide.Server)]
    public class SP40UpdateViewPosition : Packet {

        public int ChunkX { get; }
        public int ChunkZ { get; }

        public SP40UpdateViewPosition(int chunkX, int chunkZ) {
            ChunkX = chunkX;
            ChunkZ = chunkZ;

            VarInt varInt = new(chunkX);
            varInt.Write(Data);

            varInt.Value = chunkZ;
            varInt.Write(Data);
        }
    }
}