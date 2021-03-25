using System;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x3A, ProtocolState.Play, PacketSide.Server)]
    public class SP3AEntityHeadLook : MinecraftPacket {

        public int EntityId { get; }
        public float HeadYaw { get; }

        public SP3AEntityHeadLook(int entityId, float headYaw) {
            EntityId = entityId;
            HeadYaw = headYaw;

            WriteVarInt(entityId);
            WriteAngle(headYaw);
        }
    }
}