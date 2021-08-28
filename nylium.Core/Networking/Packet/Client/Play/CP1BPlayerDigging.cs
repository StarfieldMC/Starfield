using System.IO;
using nylium.Utilities;

namespace nylium.Core.Networking.Packet.Client.Play {

    [Packet(0x1B, ProtocolState.Play, PacketSide.Client)]
    public class CP1BPlayerDigging : MinecraftPacket {

        public ActionType Status { get; }
        public Position.Int Location { get; }
        public Face Face { get; }

        public CP1BPlayerDigging(MinecraftClient client, Stream stream) : base(client, stream) {
            Status = (ActionType) Data.ReadVarInt();
            Location = Data.ReadPosition();
            Face = (Face) Data.ReadByte();
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