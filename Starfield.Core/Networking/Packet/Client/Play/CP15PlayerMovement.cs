using System.IO;

namespace Starfield.Core.Networking.Packet.Client.Play {
    
    [Packet(0x15, ProtocolState.Play, PacketSide.Client)]
    public class CP15PlayerMovement : MinecraftPacket {

        public bool OnGround { get; }

        public CP15PlayerMovement(MinecraftClient client, Stream stream) : base(client, stream) {
            OnGround = Data.ReadBoolean();
        }
    }
}