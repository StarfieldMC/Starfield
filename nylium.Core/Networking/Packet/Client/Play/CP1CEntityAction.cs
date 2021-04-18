using System.IO;

namespace nylium.Core.Networking.Packet.Client.Play {

    [Packet(0x1C, ProtocolState.Play, PacketSide.Client)]
    public class CP1CEntityAction : MinecraftPacket {

        public int EntityId { get; }
        public ActionType Action { get; }
        public int JumpBoost { get; }

        public CP1CEntityAction(MinecraftClient client, Stream stream) : base(client, stream) {
            EntityId = Data.ReadVarInt();
            Action = (ActionType) Data.ReadVarInt();
            JumpBoost = Data.ReadVarInt();
        }
        
        public enum ActionType : int {

            StartSneaking,
            StopSneaking,
            LeaveBed,
            StartSprinting,
            StopSprinting,
            StartJumpWithHorse,
            StopJumpWithHorse,
            OpenHorseInventory,
            StartFlyingWithElytra
        }
    }
}