using nylium.Utilities;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x07, ProtocolState.Play, PacketSide.Server)]
    public class SP07AcknowledgePlayerDigging : MinecraftPacket {

        public Position.Int Location { get; }
        public int Block { get; }
        public ActionType Status { get; }
        public bool Successful { get; }

        public SP07AcknowledgePlayerDigging(MinecraftClient client, Position.Int location, int block, ActionType status, bool successful) : base(client) {
            Location = Data.WritePosition(location);
            Block = Data.WriteVarInt(block);
            Status = (ActionType) Data.WriteVarInt((int) status);
            Successful = Data.WriteBoolean(successful);
        }

        public enum ActionType : int {

            StartedDigging,
            CancelledDigging,
            FinishedDigging
        }
    }
}