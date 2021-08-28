using System.IO;

namespace Starfield.Core.Networking.Packet.Client.Login {

    [Packet(0x00, ProtocolState.Login, PacketSide.Client)]
    public class CL00LoginStart : MinecraftPacket {

        public string Username { get; }

        public CL00LoginStart(MinecraftClient client, Stream stream) : base(client, stream) {
            Username = Data.ReadString();
        }
    }
}
