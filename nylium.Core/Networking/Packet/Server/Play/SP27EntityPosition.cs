namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x27, ProtocolState.Play, PacketSide.Server)]
    public class SP27EntityPosition : MinecraftPacket {

        public int EntityId { get; }
        public short DeltaX { get; }
        public short DeltaY { get; }
        public short DeltaZ { get; }
        public bool OnGround { get; }

        public SP27EntityPosition(MinecraftClient client, int entityId, short deltaX, short deltaY, short deltaZ, bool onGround) : base(client) {
            EntityId = Data.WriteVarInt(entityId);
            DeltaX = Data.WriteShort(deltaX);
            DeltaY = Data.WriteShort(deltaY);
            DeltaZ = Data.WriteShort(deltaZ);
            OnGround = Data.WriteBoolean(onGround);
        }
    }
}