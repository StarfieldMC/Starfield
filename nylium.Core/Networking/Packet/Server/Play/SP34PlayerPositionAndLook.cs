using nylium.Core.DataTypes;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x34, ProtocolState.Play, PacketSide.Server)]
    public class SP34PlayerPositionAndLook : NetworkPacket {

        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        public float Yaw { get; }
        public float Pitch { get; }
        public sbyte Flags { get; }
        public int TeleportId { get; }

        public SP34PlayerPositionAndLook(double x, double y, double z,
            float yaw, float pitch, sbyte flags, int teleportId) {

            X = x;
            Y = y;
            Z = z;
            Yaw = yaw;
            Pitch = pitch;
            Flags = flags;
            TeleportId = teleportId;

            WriteDouble(x);
            WriteDouble(y);
            WriteDouble(z);

            WriteFloat(yaw);
            WriteFloat(pitch);

            WriteByte(flags);
            WriteVarInt(teleportId);
        }
    }
}