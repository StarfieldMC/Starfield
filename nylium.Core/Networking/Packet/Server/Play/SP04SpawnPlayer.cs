using DaanV2.UUID;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x04, ProtocolState.Play, PacketSide.Server)]
    public class SP04SpawnPlayer : MinecraftPacket {

        public int EntityId { get; }
        public UUID PlayerUuid { get; }
        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        public float Yaw { get; }
        public float Pitch { get; }

        public SP04SpawnPlayer(MinecraftClient client, int entityId, UUID playerUuid, double x, double y, double z, float yaw, float pitch) : base(client) {
            EntityId = Data.WriteVarInt(entityId);
            PlayerUuid = Data.WriteUuid(playerUuid);
            X = Data.WriteDouble(x);
            Y = Data.WriteDouble(y);
            Z = Data.WriteDouble(z);
            Yaw = Data.WriteAngle(yaw);
            Pitch = Data.WriteAngle(pitch);
        }
    }
}