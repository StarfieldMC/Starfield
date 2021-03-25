using System;
using System.Collections.Generic;
using nylium.Core.Networking.DataTypes;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x44, ProtocolState.Play, PacketSide.Server)]
    public class SP44EntityMetadata : MinecraftPacket {

        public int EntityId { get; }
        public List<EntityMetadata.Entry> Metadata { get; }

        public SP44EntityMetadata(int entityId, List<EntityMetadata.Entry> metadata) {
            EntityId = entityId;
            Metadata = metadata;

            WriteVarInt(entityId);
            WriteEntityMetadata(metadata);
        }
    }
}