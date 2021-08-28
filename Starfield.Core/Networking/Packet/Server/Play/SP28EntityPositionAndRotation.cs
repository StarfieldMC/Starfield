namespace Starfield.Core.Networking.Packet.Server.Play {

    [Packet(0x28, ProtocolState.Play, PacketSide.Server)]
    public class SP28EntityPositionAndRotation : MinecraftPacket {

        public int EntityId { get; }
        public short DeltaX { get; }
        public short DeltaY { get; }
        public short DeltaZ { get; }
        public float Yaw { get; }
        public float Pitch { get; }
        public bool OnGround { get; }

        public SP28EntityPositionAndRotation(MinecraftClient client, int entityId,
            short deltaX, short deltaY, short deltaZ, float yaw, float pitch, bool onGround) : base(client) {

            EntityId = Data.WriteVarInt(entityId);
            DeltaX = Data.WriteShort(deltaX);
            DeltaY = Data.WriteShort(deltaY);
            DeltaZ = Data.WriteShort(deltaZ);
            Yaw = Data.WriteAngle(yaw);
            Pitch = Data.WriteAngle(pitch);
            OnGround = Data.WriteBoolean(onGround);
        }
    }
}