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

        public SP24JoinGame(MinecraftClient client, int entityId, bool isHardcore, Gamemode gamemode, Gamemode previousGamemode, Identifier[] worldNames,
            TagCompound dimensionCodec, TagCompound dimension, Identifier worldName, long hashedSeed, int maxPlayers, int viewDistance,
            bool reducedDebugInfo, bool enableRespawnScreen, bool isDebug, bool isFlat) : base(client) {

            EntityId = Data.WriteInt(entityId);
            IsHardcore = Data.WriteBoolean(isHardcore);
            Gamemode = (Gamemode) Data.WriteUnsignedByte((byte) gamemode);
            PreviousGamemode = (Gamemode) Data.WriteByte((sbyte) previousGamemode);
            Data.WriteVarInt(worldNames.Length);
            WorldNames = Data.WriteArray<Identifier, DataTypes.Identifier>(worldNames);
            DimensionCodec = Data.WriteNBT(new NBTFile(dimensionCodec)).Root;
            Dimension = Data.WriteNBT(new NBTFile(dimension)).Root;
            WorldName = Data.WriteIdentifier(worldName);
            HashedSeed = Data.WriteLong(hashedSeed);
            MaxPlayers = Data.WriteVarInt(maxPlayers);
            ViewDistance = Data.WriteVarInt(viewDistance);
            ReducedDebugInfo = Data.WriteBoolean(reducedDebugInfo);
            EnableRespawnScreen = Data.WriteBoolean(enableRespawnScreen);
            IsDebug = Data.WriteBoolean(isDebug);
            IsFlat = Data.WriteBoolean(isFlat);
        }
    }
}
