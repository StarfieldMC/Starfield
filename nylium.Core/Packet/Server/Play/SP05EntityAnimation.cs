using System;

namespace nylium.Core.Packet.Server.Play {

    [Packet(0x05, ProtocolState.Play, PacketSide.Server)]
    public class SP05EntityAnimation : NetworkPacket {

        public int EntityId { get; }
        public AnimationType Animation { get; }

        public SP05EntityAnimation(int entityId, AnimationType animation) {
            EntityId = entityId;
            Animation = animation;

            WriteVarInt(entityId);
            WriteUnsignedByte((byte) Animation);
        }

        public enum AnimationType : byte {

            SwingMainArm,
            TakeDamage,
            LeaveBed,
            SwingOffhand,
            CriticalEffect,
            MagicCriticalEffect
        }
    }
}