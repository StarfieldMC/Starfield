using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Server.Play {

    [Packet(0x34, ProtocolState.Play, PacketSide.Server)]
    public class SP34PlayerPositionAndLook : Packet {

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

            Double @double = new(x);
            @double.Write(Data);

            @double.Value = y;
            @double.Write(Data);
            
            @double.Value = z;
            @double.Write(Data);

            Float @float = new(yaw);
            @float.Write(Data);

            @float.Value = pitch;
            @float.Write(Data);

            Byte @byte = new(flags);
            @byte.Write(Data);

            VarInt varInt = new(teleportId);
            varInt.Write(Data);
        }
    }
}