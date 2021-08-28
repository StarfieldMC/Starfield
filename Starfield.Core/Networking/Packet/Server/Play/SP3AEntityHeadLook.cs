namespace Starfield.Core.Networking.Packet.Server.Play {

    [Packet(0x3A, ProtocolState.Play, PacketSide.Server)]
    public class SP3AEntityHeadLook : MinecraftPacket {

        public int EntityId { get; }
        public float HeadYaw { get; }

        public SP3AEntityHeadLook(MinecraftClient client, int entityId, float headYaw) : base(client) {
            EntityId = Data.WriteVarInt(entityId);
            HeadYaw = Data.WriteAngle(headYaw);
        }
    }
}