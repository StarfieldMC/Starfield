using nylium.Core.Networking.DataTypes;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x36, ProtocolState.Play, PacketSide.Server)]
    public class SP36DestroyEntities : MinecraftPacket {

        public int[] EntityIds { get; }

        public SP36DestroyEntities(MinecraftClient client, int[] entityIds) : base(client) {
            Data.WriteVarInt(entityIds.Length);
            EntityIds = Data.WriteArray<int, VarInt>(entityIds);
        }
    }
}