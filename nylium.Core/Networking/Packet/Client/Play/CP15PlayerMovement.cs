using System.IO;

namespace nylium.Core.Networking.Packet.Client.Play {
    
    [Packet(0x15, ProtocolState.Play, PacketSide.Client)]
    public class CP15PlayerMovement : MinecraftPacket {

        public bool OnGround { get; }

        public CP15PlayerMovement(Stream stream) : base(stream) {
            OnGround = ReadBoolean();
        }
    }
}