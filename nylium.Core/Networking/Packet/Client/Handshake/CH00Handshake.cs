using System.IO;
using nylium.Core.DataTypes;

namespace nylium.Core.Networking.Packet.Client.Handshake {

    [Packet(0, ProtocolState.Handshaking, PacketSide.Client)]
    public class CH00Handshake : NetworkPacket {

        public int ProtocolVersion { get; }
        public string ServerAddress { get; }
        public ushort ServerPort { get; }
        public ProtocolState NextState { get; }

        public CH00Handshake(Stream stream) : base(stream) {
            ProtocolVersion = ReadVarInt();
            ServerAddress = ReadString();
            ServerPort = ReadUnsignedShort();
            NextState = (ProtocolState) ReadVarInt();
        }
    }
}
