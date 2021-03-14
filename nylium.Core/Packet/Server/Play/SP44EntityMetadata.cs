using System;
using System.Collections.Generic;
using nylium.Core.DataTypes;

namespace nylium.Core.Packet.Server.Play {

    [Packet(0x44, ProtocolState.Play, PacketSide.Server)]
    public class SP44EntityMetadata : NetworkPacket {

        public int EntityId { get; }
        public List<EntityMetadataEntry> Metadata { get; }

        public SP44EntityMetadata(int entityId, List<EntityMetadataEntry> metadata) {
            EntityId = entityId;
            Metadata = metadata;

            VarInt varInt = new(entityId);
            varInt.Write(Data);

            EntityMetadata entityMetadata = new(metadata);
            entityMetadata.Write(Data);
        }
    }
}