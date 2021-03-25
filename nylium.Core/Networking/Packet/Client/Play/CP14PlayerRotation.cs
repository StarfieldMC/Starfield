using System.IO;

namespace nylium.Core.Networking.Packet.Client.Play {

    [Packet(0x14, ProtocolState.Play, PacketSide.Client)]
    public class CP14PlayerRotation : MinecraftPacket {

        public float Yaw { get; }
        public float Pitch { get; }
        public bool OnGround { get; }

        public CP14PlayerRotation(Stream stream) : base(stream) {
            Yaw = ReadFloat();
            Pitch = ReadFloat();
            OnGround = ReadBoolean();
        }
    }
}