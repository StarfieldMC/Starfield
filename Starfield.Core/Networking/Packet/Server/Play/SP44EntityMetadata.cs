using System.Collections.Generic;
using Starfield.Core.Networking.DataTypes;

namespace Starfield.Core.Networking.Packet.Server.Play {

    [Packet(0x44, ProtocolState.Play, PacketSide.Server)]
    public class SP44EntityMetadata : MinecraftPacket {

        public int EntityId { get; }
        public List<EntityMetadata.Entry> Metadata { get; }

        public SP44EntityMetadata(MinecraftClient client, int entityId, List<EntityMetadata.Entry> metadata) : base(client) {
            EntityId = Data.WriteVarInt(entityId);
            Metadata = Data.WriteEntityMetadata(metadata);
        }
    }
}