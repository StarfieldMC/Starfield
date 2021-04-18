namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x40, ProtocolState.Play, PacketSide.Server)]
    public class SP40UpdateViewPosition : MinecraftPacket {

        public int ChunkX { get; }
        public int ChunkZ { get; }

        public SP40UpdateViewPosition(MinecraftClient client, int chunkX, int chunkZ) : base(client) {
            ChunkX = Data.WriteVarInt(chunkX);
            ChunkZ = Data.WriteVarInt(chunkZ);
        }
    }
}