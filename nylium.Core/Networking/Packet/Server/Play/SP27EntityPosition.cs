using System;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x27, ProtocolState.Play, PacketSide.Server)]
    public class SP27EntityPosition : MinecraftPacket {

        public int EntityId { get; }
        public short DeltaX { get; }
        public short DeltaY { get; }
        public short DeltaZ { get; }
        public bool OnGround { get; }

        public SP27EntityPosition(int entityId, short deltaX, short deltaY, short deltaZ, bool onGround) {
            EntityId = entityId;
            DeltaX = deltaX;
            DeltaY = deltaY;
            DeltaZ = deltaZ;
            OnGround = onGround;

            WriteVarInt(entityId);
            WriteShort(deltaX);
            WriteShort(deltaY);
            WriteShort(deltaZ);
            WriteBoolean(onGround);
        }
    }
}