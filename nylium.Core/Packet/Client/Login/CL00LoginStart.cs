using System.IO;
using nylium.Core.DataTypes;

namespace nylium.Core.Packet.Client.Login {

    [Packet(0, ProtocolState.Login, PacketSide.Client)]
    public class CL00LoginStart : NetworkPacket {

        public string Username { get; }

        public CL00LoginStart(Stream stream) : base(stream) {
            String @string = new(Data);
            Username = @string.Value;
        }
    }
}
