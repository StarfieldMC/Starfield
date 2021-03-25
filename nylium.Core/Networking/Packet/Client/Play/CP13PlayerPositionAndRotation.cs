using System.IO;

namespace nylium.Core.Networking.Packet.Client.Play {

    [Packet(0x13, ProtocolState.Play, PacketSide.Client)]
    public class CP13PlayerPositionAndRotation : MinecraftPacket {

        public double X { get; }
        public double FeetY { get; }
        public double Z { get; }
        public float Yaw { get; }
        public float Pitch { get; }
        public bool OnGround { get; }

        public CP13PlayerPositionAndRotation(Stream stream) : base(stream) {
            X = ReadDouble();
            FeetY = ReadDouble();
            Z = ReadDouble();
            Yaw = ReadFloat();
            Pitch = ReadFloat();
            OnGround = ReadBoolean();
        }
    }
}