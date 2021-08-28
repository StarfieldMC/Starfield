namespace Starfield.Core.Networking.Packet.Server.Play {

    [Packet(0x1C, ProtocolState.Play, PacketSide.Server)]
    public class SP1CUnloadChunk : MinecraftPacket {

        public int ChunkX { get; }
        public int ChunkZ { get; }

        public SP1CUnloadChunk(MinecraftClient client, int chunkX, int chunkZ) : base(client) {
            ChunkX = Data.WriteInt(chunkX);
            ChunkZ = Data.WriteInt(chunkZ);
        }
    }
}