using System.IO;

namespace nylium.Core.Networking.Packet.Client.Handshake {

    [Packet(0x00, ProtocolState.Handshaking, PacketSide.Client)]
    public class CH00Handshake : MinecraftPacket {

        public int ProtocolVersion { get; }
        public string ServerAddress { get; }
        public ushort ServerPort { get; }
        public ProtocolState NextState { get; }

        public CH00Handshake(MinecraftClient client, Stream stream) : base(client, stream) {
            ProtocolVersion = Data.ReadVarInt();
            ServerAddress = Data.ReadString();
            ServerPort = Data.ReadUnsignedShort();
            NextState = (ProtocolState) Data.ReadVarInt();
        }
    }
}
