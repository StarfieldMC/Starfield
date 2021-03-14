using System;
using DaanV2.UUID;

namespace nylium.Core.Packet.Server.Play {

    [Packet(0x04, ProtocolState.Play, PacketSide.Server)]
    public class SP04SpawnPlayer : NetworkPacket {

        public int EntityId { get; }
        public UUID PlayerUuid { get; }
        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        public float Yaw { get; }
        public float Pitch { get; }

        public SP04SpawnPlayer(int entityId, UUID playerUuid, double x, double y, double z, float yaw, float pitch) {
            EntityId = entityId;
            PlayerUuid = playerUuid;
            X = x;
            Y = y;
            Z = z;
            Yaw = yaw;
            Pitch = pitch;

            WriteVarInt(entityId);
            WriteUuid(playerUuid);
            WriteDouble(x);
            WriteDouble(y);
            WriteDouble(z);
            WriteAngle(yaw);
            WriteAngle(pitch);
        }
    }
}