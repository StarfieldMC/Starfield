namespace Starfield.Core.Networking.Packet.Server.Play {

    [Packet(0x29, ProtocolState.Play, PacketSide.Server)]
    public class SP29EntityRotation : MinecraftPacket {

        public int EntityId { get; }
        public float Yaw { get; }
        public float Pitch { get; }
        public bool OnGround { get; }

        public SP29EntityRotation(MinecraftClient client, int entityId, float yaw, float pitch, bool onGround) : base(client) {
            EntityId = Data.WriteVarInt(entityId);
            Yaw = Data.WriteAngle(yaw);
            Pitch = Data.WriteAngle(pitch);
            OnGround = Data.WriteBoolean(onGround);
        }
    }
}