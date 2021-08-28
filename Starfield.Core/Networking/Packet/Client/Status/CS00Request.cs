using System.IO;

namespace Starfield.Core.Networking.Packet.Client.Status {

    [Packet(0, ProtocolState.Status, PacketSide.Client)]
    public class CS00Request : MinecraftPacket {
    
        public CS00Request(MinecraftClient client, Stream stream) : base(client, stream) { }
    }
}
