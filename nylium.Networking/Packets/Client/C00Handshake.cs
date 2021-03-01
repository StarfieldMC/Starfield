using System.IO;
using nylium.Networking.DataTypes;
using DT = nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Client {

    public class C00Handshake {

        private Packet _packet;

        public int ProtocolVersion { get; }
        public string ServerAddress { get; }
        public ushort ServerPort { get; }
        public ProtocolState NextState { get; }

        public C00Handshake(Packet packet) {
            _packet = packet;

            packet.Data.Seek(0, SeekOrigin.Begin);

            VarInt varInt = new VarInt();
            varInt.Read(packet.Data, out _);
            ProtocolVersion = varInt.Value;

            DT.String str = new DT.String();
            str.Read(packet.Data, out _);
            ServerAddress = str.Value;

            UShort ushrt = new UShort();
            ushrt.Read(packet.Data, out _);
            ServerPort = ushrt.Value;

            varInt.Read(packet.Data, out _);
            NextState = (ProtocolState) varInt.Value;
        }
    }
}
