using Starfield.Nbt;
using Starfield.Nbt.Tags;
using Starfield.Core.Networking.DataTypes;

namespace Starfield.Core.Networking.Packet.Server.Play {

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

        public SP20ChunkData(MinecraftClient client, int chunkX, int chunkZ, bool fullChunk, int primaryBitMask,
            TagCompound heightmaps, int[] biomes, sbyte[] data, TagCompound[] blockEntities) : base(client) {

            ChunkX = base.Data.WriteInt(chunkX);
            ChunkZ = base.Data.WriteInt(chunkZ);
            FullChunk = base.Data.WriteBoolean(fullChunk);
            PrimaryBitMask = base.Data.WriteVarInt(primaryBitMask);
            Heightmaps = base.Data.WriteNBT(new NBTFile(heightmaps)).Root;

            if(fullChunk) {
                base.Data.WriteVarInt(biomes.Length);
                Biomes = base.Data.WriteArray<int, VarInt>(biomes);
            }

            base.Data.WriteVarInt(data.Length);
            Data = base.Data.WriteByteArray(data);
            base.Data.WriteVarInt(blockEntities.Length);
            BlockEntities = blockEntities;

            for(int i = 0; i < blockEntities.Length; i++) {
                base.Data.WriteNBT(new NBTFile(blockEntities[i]));
            }
        }
    }
}
