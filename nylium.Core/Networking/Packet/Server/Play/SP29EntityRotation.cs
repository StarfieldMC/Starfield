using System;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x29, ProtocolState.Play, PacketSide.Server)]
    public class SP29EntityRotation : MinecraftPacket {

        public int EntityId { get; }
        public float Yaw { get; }
        public float Pitch { get; }
        public bool OnGround { get; }

        public SP29EntityRotation(int entityId, float yaw, float pitch, bool onGround) {
            EntityId = entityId;
            Yaw = yaw;
            Pitch = pitch;
            OnGround = onGround;

            WriteVarInt(entityId);
            WriteAngle(yaw);
            WriteAngle(pitch);
            WriteBoolean(onGround);
        }
    }
}