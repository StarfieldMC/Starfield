using fNbt.Tags;
using nylium.Core.DataTypes;
using nylium.Utilities;
using U = nylium.Utilities;
using DT = nylium.Core.DataTypes;
using fNbt;

namespace nylium.Core.Packet.Server.Play {

    [Packet(0x24, ProtocolState.Play, PacketSide.Server)]
    public class SP24JoinGame : NetworkPacket {
        
        public int EntityId { get; }
        public bool IsHardcore { get; }
        public Gamemode Gamemode { get; }
        public Gamemode PreviousGamemode { get; }
        public U.Identifier[] WorldNames { get; }
        public NbtCompound DimensionCodec { get; }
        public NbtCompound Dimension { get; }
        public U.Identifier WorldName { get; }
        public long HashedSeed { get; }
        public int MaxPlayers { get; }
        public int ViewDistance { get; }
        public bool ReducedDebugInfo { get; }
        public bool EnableRespawnScreen { get; }
        public bool IsDebug { get; }
        public bool IsFlat { get; }

        public SP24JoinGame(int entityId, bool isHardcore, Gamemode gamemode, Gamemode previousGamemode, U.Identifier[] worldNames,
            NbtCompound dimensionCodec, NbtCompound dimension, U.Identifier worldName, long hashedSeed, int maxPlayers, int viewDistance,
            bool reducedDebugInfo, bool enableRespawnScreen, bool isDebug, bool isFlat) {

            EntityId = entityId;
            IsHardcore = isHardcore;
            Gamemode = gamemode;
            PreviousGamemode = previousGamemode;
            WorldNames = worldNames;
            DimensionCodec = dimensionCodec;
            Dimension = dimension;
            WorldName = worldName;
            HashedSeed = hashedSeed;
            MaxPlayers = maxPlayers;
            ViewDistance = viewDistance;
            ReducedDebugInfo = reducedDebugInfo;
            EnableRespawnScreen = enableRespawnScreen;
            IsDebug = isDebug;
            IsFlat = isFlat;

            WriteInt(entityId);
            WriteBoolean(isHardcore);
            WriteUnsignedByte((byte) gamemode);
            WriteByte((sbyte) previousGamemode);
            WriteVarInt(worldNames.Length);

            Array<U.Identifier, DT.Identifier> array = new(worldNames);
            array.Write(Data);

            NBT nbt = new(new NbtFile(dimensionCodec));
            nbt.Write(Data);

            nbt.Value = new NbtFile(dimension);
            nbt.Write(Data);

            DT.Identifier identifier = new(worldName);
            identifier.Write(Data);

            WriteLong(hashedSeed);
            WriteVarInt(maxPlayers);
            WriteVarInt(viewDistance);
            WriteBoolean(reducedDebugInfo);
            WriteBoolean(enableRespawnScreen);
            WriteBoolean(isDebug);
            WriteBoolean(isFlat);
        }
    }
}
