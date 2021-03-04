using System.IO;
using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Client.Login {

    [Packet(0, ProtocolState.LOGIN, PacketSide.CLIENT)]
    public class CL00LoginStart : Packet {

        public string Username { get; }

        public CL00LoginStart(Stream stream) : base(stream) {
            String @string = new String();
            @string.Read(Data);
            Username = @string.Value;
        }
    }
}
