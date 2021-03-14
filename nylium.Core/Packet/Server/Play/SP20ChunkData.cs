using fNbt;
using fNbt.Tags;
using nylium.Core.DataTypes;

namespace nylium.Core.Packet.Server.Play {

    [Packet(0x20, ProtocolState.Play, PacketSide.Server)]
    public class SP20ChunkData : NetworkPacket {

        public int ChunkX { get; }
        public int ChunkZ { get; }
        public bool FullChunk { get; }
        public int PrimaryBitMask { get; }
        public NbtCompound Heightmaps { get; }
        public int[] Biomes { get; }

#pragma warning disable 0108
        public sbyte[] Data { get; }
#pragma warning restore 0108

        public NbtCompound[] BlockEntities { get; }

        public SP20ChunkData(int chunkX, int chunkZ, bool fullChunk, int primaryBitMask,
            NbtCompound heightmaps, int[] biomes, sbyte[] data, NbtCompound[] blockEntities) {

            ChunkX = chunkX;
            ChunkZ = chunkZ;
            FullChunk = fullChunk;
            PrimaryBitMask = primaryBitMask;
            Heightmaps = heightmaps;
            Biomes = biomes;
            Data = data;
            BlockEntities = blockEntities;

            Int _int = new(chunkX);
            _int.Write(base.Data);

            _int.Value = chunkZ;
            _int.Write(base.Data);

            Boolean boolean = new(fullChunk);
            boolean.Write(base.Data);

            VarInt varInt = new(primaryBitMask);
            varInt.Write(base.Data);

            base.Data.Write(new NbtFile(heightmaps).SaveToBuffer(NbtCompression.None));

            varInt.Value = biomes.Length;
            varInt.Write(base.Data);

            Array<int, VarInt> array = new(biomes);
            array.Write(base.Data);

            varInt.Value = data.Length;
            varInt.Write(base.Data);

            ByteArray byteArray = new(data);
            byteArray.Write(base.Data);

            varInt.Value = blockEntities.Length;
            varInt.Write(base.Data);

            for(int i = 0; i < blockEntities.Length; i++) {
                base.Data.Write(new NbtFile(blockEntities[i]).SaveToBuffer(NbtCompression.None));
            }
        }
    }
}
