namespace Starfield.Core.Networking.Packet.Server.Play {

    [Packet(0x05, ProtocolState.Play, PacketSide.Server)]
    public class SP05EntityAnimation : MinecraftPacket {

        public int EntityId { get; }
        public AnimationType Animation { get; }

        public SP05EntityAnimation(MinecraftClient client, int entityId, AnimationType animation) : base(client) {
            EntityId = Data.WriteVarInt(entityId);
            Animation = (AnimationType) Data.WriteUnsignedByte((byte) animation);
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