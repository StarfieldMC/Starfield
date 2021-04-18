using nylium.Nbt;
using nylium.Nbt.Tags;
using nylium.Utilities;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x24, ProtocolState.Play, PacketSide.Server)]
    public class SP24JoinGame : MinecraftPacket {
        
        public int EntityId { get; }
        public bool IsHardcore { get; }
        public Gamemode Gamemode { get; }
        public Gamemode PreviousGamemode { get; }
        public Identifier[] WorldNames { get; }
        public TagCompound DimensionCodec { get; }
        public TagCompound Dimension { get; }
        public Identifier WorldName { get; }
        public long HashedSeed { get; }
        public int MaxPlayers { get; }
        public int ViewDistance { get; }
        public bool ReducedDebugInfo { get; }
        public bool EnableRespawnScreen { get; }
        public bool IsDebug { get; }
        public bool IsFlat { get; }

        public SP24JoinGame(int entityId, bool isHardcore, Gamemode gamemode, Gamemode previousGamemode, Identifier[] worldNames,
            TagCompound dimensionCodec, TagCompound dimension, Identifier worldName, long hashedSeed, int maxPlayers, int viewDistance,
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

            WriteArray<Identifier, DataTypes.Identifier>(worldNames);

            WriteNBT(new NBTFile(dimensionCodec));
            WriteNBT(new NBTFile(dimension));

            WriteIdentifier(worldName);
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
