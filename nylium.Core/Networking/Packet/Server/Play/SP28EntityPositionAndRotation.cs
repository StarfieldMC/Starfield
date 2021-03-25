using System;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x28, ProtocolState.Play, PacketSide.Server)]
    public class SP28EntityPositionAndRotation : MinecraftPacket {

        public int EntityId { get; }
        public short DeltaX { get; }
        public short DeltaY { get; }
        public short DeltaZ { get; }
        public float Yaw { get; }
        public float Pitch { get; }
        public bool OnGround { get; }

        public SP28EntityPositionAndRotation(int entityId, short deltaX, short deltaY, short deltaZ, float yaw, float pitch, bool onGround) {
            EntityId = entityId;
            DeltaX = deltaX;
            DeltaY = deltaY;
            DeltaZ = deltaZ;
            Yaw = yaw;
            Pitch = pitch;
            OnGround = onGround;

            WriteVarInt(entityId);
            WriteShort(deltaX);
            WriteShort(deltaY);
            WriteShort(deltaZ);
            WriteAngle(yaw);
            WriteAngle(pitch);
            WriteBoolean(onGround);
        }
    }
}