using System.IO;
using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Client {

    [Packet(0, ProtocolState.HANDSHAKING, PacketSide.CLIENT)]
    public class CH00Handshake : Packet {

        public int ProtocolVersion { get; }
        public string ServerAddress { get; }
        public ushort ServerPort { get; }
        public ProtocolState NextState { get; }

        public CH00Handshake(Stream stream) : base(stream) {
            this.Data.Seek(0, SeekOrigin.Begin);

            VarInt varInt = new VarInt();
            varInt.Read(this.Data, out _);
            ProtocolVersion = varInt.Value;

            String _string = new String();
            _string.Read(this.Data, out _);
            ServerAddress = _string.Value;

            UShort _ushort = new UShort();
            _ushort.Read(this.Data, out _);
            ServerPort = _ushort.Value;

            varInt.Read(this.Data, out _);
            NextState = (ProtocolState) varInt.Value;
        }
    }
}
