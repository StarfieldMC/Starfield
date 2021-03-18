using System;
using nylium.Utilities;

namespace nylium.Core.Packet.Server.Play {

    [Packet(0x07, ProtocolState.Play, PacketSide.Server)]
    public class SP07AcknowledgePlayerDigging : NetworkPacket {

        public Position.Int Location { get; }
        public int Block { get; }
        public ActionType Status { get; }
        public bool Successful { get; }

        public SP07AcknowledgePlayerDigging(Position.Int location, int block, ActionType status, bool successful) {
            Location = location;
            Block = block;
            Status = status;
            Successful = successful;

            WritePosition(location);
            WriteVarInt(block);
            WriteVarInt((int) status);
            WriteBoolean(successful);
        }

        public enum ActionType : int {

            StartedDigging,
            CancelledDigging,
            FinishedDigging
        }
    }
}