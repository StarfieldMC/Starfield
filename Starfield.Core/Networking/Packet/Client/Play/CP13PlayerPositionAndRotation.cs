using System.IO;

namespace Starfield.Core.Networking.Packet.Client.Play {

    [Packet(0x13, ProtocolState.Play, PacketSide.Client)]
    public class CP13PlayerPositionAndRotation : MinecraftPacket {

        public double X { get; }
        public double FeetY { get; }
        public double Z { get; }
        public float Yaw { get; }
        public float Pitch { get; }
        public bool OnGround { get; }

        public CP13PlayerPositionAndRotation(MinecraftClient client, Stream stream) : base(client, stream) {
            X = Data.ReadDouble();
            FeetY = Data.ReadDouble();
            Z = Data.ReadDouble();
            Yaw = Data.ReadFloat();
            Pitch = Data.ReadFloat();
            OnGround = Data.ReadBoolean();
        }
    }
}