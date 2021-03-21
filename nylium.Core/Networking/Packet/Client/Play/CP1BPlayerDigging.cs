using System.IO;
using nylium.Core.Block;
using nylium.Utilities;

namespace nylium.Core.Networking.Packet.Client.Play {

    [Packet(0x1B, ProtocolState.Play, PacketSide.Client)]
    public class CP1BPlayerDigging : NetworkPacket {

        public ActionType Status { get; }
        public Position.Int Location { get; }
        public GameBlock.Face Face { get; }

        public CP1BPlayerDigging(Stream stream) : base(stream) {
            Status = (ActionType) ReadVarInt();
            Location = ReadPosition();
            Face = (GameBlock.Face) ReadByte();
        }

        public enum ActionType : int {

            StartedDigging,
            CancelledDigging,
            FinishedDigging,
            DropItemStack,
            DropItem,
            FinishEating,
            SwapItem
        }
    }
}