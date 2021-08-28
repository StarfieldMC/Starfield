namespace Starfield.Core.Networking.Packet.Server.Play {

    [Packet(0x56, ProtocolState.Play, PacketSide.Server)]
    public class SP56EntityTeleport : MinecraftPacket {

        public int EntityId { get; }
        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        public float Yaw { get; }
        public float Pitch { get; }
        public bool OnGround { get; }

        public SP56EntityTeleport(MinecraftClient client, int entityId, double x, double y, double z,
            float yaw, float pitch, bool onGround) : base(client) {

            EntityId = Data.WriteVarInt(entityId);
            X = Data.WriteDouble(x);
            Y = Data.WriteDouble(y);
            Z = Data.WriteDouble(z);
            Yaw = Data.WriteAngle(yaw);
            Pitch = Data.WriteAngle(pitch);
            OnGround = Data.WriteBoolean(onGround);
        }
    }
}