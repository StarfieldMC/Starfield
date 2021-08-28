namespace Starfield.Core.Networking.Packet.Server.Play {

    [Packet(0x34, ProtocolState.Play, PacketSide.Server)]
    public class SP34PlayerPositionAndLook : MinecraftPacket {

        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        public float Yaw { get; }
        public float Pitch { get; }
        public sbyte Flags { get; }
        public int TeleportId { get; }

        public SP34PlayerPositionAndLook(MinecraftClient client, double x, double y, double z,
            float yaw, float pitch, sbyte flags, int teleportId) : base(client) {

            X = Data.WriteDouble(x);
            Y = Data.WriteDouble(y);
            Z = Data.WriteDouble(z);
            Yaw = Data.WriteFloat(yaw);
            Pitch = Data.WriteFloat(pitch);
            Flags = Data.WriteByte(flags);
            TeleportId = Data.WriteVarInt(teleportId);
        }
    }
}