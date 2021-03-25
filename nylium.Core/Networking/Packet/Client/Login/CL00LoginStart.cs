using System.IO;

namespace nylium.Core.Networking.Packet.Client.Login {

    [Packet(0, ProtocolState.Login, PacketSide.Client)]
    public class CL00LoginStart : MinecraftPacket {

        public string Username { get; }

        public CL00LoginStart(Stream stream) : base(stream) {
            Username = ReadString();
        }
    }
}
