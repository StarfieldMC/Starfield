using System;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x2A, ProtocolState.Play, PacketSide.Server)]
    public class SP2AEntityMovement : NetworkPacket {

        public int EntityId { get; }

        public SP2AEntityMovement(int entityId) {
            EntityId = entityId;

            WriteVarInt(entityId);
        }
    }
}