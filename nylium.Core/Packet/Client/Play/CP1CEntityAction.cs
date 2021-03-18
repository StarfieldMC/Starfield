using System.IO;

namespace nylium.Core.Packet.Client.Play {

    [Packet(0x1C, ProtocolState.Play, PacketSide.Client)]
    public class CP1CEntityAction : NetworkPacket {

        public int EntityId { get; }
        public ActionType Action { get; }
        public int JumpBoost { get; }

        public CP1CEntityAction(Stream stream) : base(stream) {
            EntityId = ReadVarInt();
            Action = (ActionType) ReadVarInt();
            JumpBoost = ReadVarInt();
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