using System.IO;
using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Client.Handshake {

    [Packet(0, ProtocolState.Handshaking, PacketSide.Client)]
    public class CH00Handshake : Packet {

        public int ProtocolVersion { get; }
        public string ServerAddress { get; }
        public ushort ServerPort { get; }
        public ProtocolState NextState { get; }

        public CH00Handshake(Stream stream) : base(stream) {
            VarInt varInt = new(Data);
            ProtocolVersion = varInt.Value;

            String @string = new(Data);
            ServerAddress = @string.Value;

            UShort @ushort = new(Data);
            ServerPort = @ushort.Value;

            varInt.Read(Data);
            NextState = (ProtocolState) varInt.Value;
        }
    }
}
