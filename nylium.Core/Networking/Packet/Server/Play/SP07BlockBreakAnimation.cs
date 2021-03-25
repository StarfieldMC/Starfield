using System;
using nylium.Utilities;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x07, ProtocolState.Play, PacketSide.Server)]
    public class SP07BlockBreakAnimation : MinecraftPacket {

        public int EntityId { get; }
        public Position.Int Location { get; }
        public sbyte DestroyStage { get; }

        public SP07BlockBreakAnimation(int entityId, Position.Int location, sbyte destroyStage) {
            EntityId = entityId;
            Location = location;
            DestroyStage = destroyStage;

            WriteVarInt(entityId);
            WritePosition(location);
            WriteByte(destroyStage);
        }
    }
}