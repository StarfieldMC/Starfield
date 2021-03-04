using fNbt.Tags;
using nylium.Networking.DataTypes;
using nylium.Utilities;
using U = nylium.Utilities;
using DT = nylium.Networking.DataTypes;
using fNbt;

namespace nylium.Networking.Packets.Server.Play {

    [Packet(0x24, ProtocolState.PLAY, PacketSide.SERVER)]
    public class SP24JoinGame : Packet {
        
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

            Int eId = new Int(entityId);
            Boolean hc = new Boolean(isHardcore);
            UByte gm = new UByte((byte) (sbyte) gamemode);
            Byte pGm = new Byte((sbyte) gamemode);
            VarInt wc = new VarInt(worldNames.Length);
            Array<U.Identifier, DT.Identifier> wns = new Array<U.Identifier, DT.Identifier>(worldNames);
            NBT dc = new NBT(new NbtFile(dimensionCodec));
            NBT d = new NBT(new NbtFile(dimension));
            DT.Identifier wn = new DT.Identifier(worldName);
            Long hs = new Long(hashedSeed);
            VarInt mp = new VarInt(maxPlayers);
            VarInt vd = new VarInt(viewDistance);
            Boolean rdi = new Boolean(reducedDebugInfo);

            eId.Write(Data);
            hc.Write(Data);
            gm.Write(Data);
            pGm.Write(Data);
            wc.Write(Data);
            wns.Write(Data);
            dc.Write(Data);
            d.Write(Data);
            wn.Write(Data);
            hs.Write(Data);
            mp.Write(Data);
            vd.Write(Data);
            rdi.Write(Data);
            rdi.Value = enableRespawnScreen;
            rdi.Write(Data);
            rdi.Value = isDebug;
            rdi.Write(Data);
            rdi.Value = isFlat;
            rdi.Write(Data);
        }
    }
}
