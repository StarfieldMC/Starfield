using System.IO;
using nylium.Core.Blocks;
using nylium.Utilities;

namespace nylium.Core.Networking.Packet.Client.Play {

    [Packet(0x1B, ProtocolState.Play, PacketSide.Client)]
    public class CP1BPlayerDigging : MinecraftPacket {

        public ActionType Status { get; }
        public Position.Int Location { get; }
        public Blocks.Block.Face Face { get; }

        public CP1BPlayerDigging(Stream stream) : base(stream) {
            Status = (ActionType) ReadVarInt();
            Location = ReadPosition();
            Face = (Blocks.Block.Face) ReadByte();
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