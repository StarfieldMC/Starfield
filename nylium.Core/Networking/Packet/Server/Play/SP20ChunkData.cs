using nylium.Core.Networking.DataTypes;
using nylium.Nbt;
using nylium.Nbt.Tags;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x20, ProtocolState.Play, PacketSide.Server)]
    public class SP20ChunkData : MinecraftPacket {

        public int ChunkX { get; }
        public int ChunkZ { get; }
        public bool FullChunk { get; }
        public int PrimaryBitMask { get; }
        public TagCompound Heightmaps { get; }
        public int[] Biomes { get; }

#pragma warning disable 0108
        public sbyte[] Data { get; }
#pragma warning restore 0108

        public TagCompound[] BlockEntities { get; }

        public SP20ChunkData(int chunkX, int chunkZ, bool fullChunk, int primaryBitMask,
            TagCompound heightmaps, int[] biomes, sbyte[] data, TagCompound[] blockEntities) {

            ChunkX = chunkX;
            ChunkZ = chunkZ;
            FullChunk = fullChunk;
            PrimaryBitMask = primaryBitMask;
            Heightmaps = heightmaps;
            Biomes = biomes;
            Data = data;
            BlockEntities = blockEntities;

            WriteInt(chunkX);
            WriteInt(chunkZ);
            WriteBoolean(fullChunk);
            WriteVarInt(primaryBitMask);

            WriteNBT(new NBTFile(heightmaps));

            WriteVarInt(biomes.Length);
            WriteArray<int, VarInt>(biomes);

            WriteVarInt(data.Length);
            WriteByteArray(data);

            WriteVarInt(blockEntities.Length);

            for(int i = 0; i < blockEntities.Length; i++) {
                WriteNBT(new NBTFile(blockEntities[i]));
            }
        }
    }
}
