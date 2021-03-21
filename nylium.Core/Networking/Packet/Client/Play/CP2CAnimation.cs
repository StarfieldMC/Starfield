using System.IO;

namespace nylium.Core.Networking.Packet.Client.Play {

    [Packet(0x2C, ProtocolState.Play, PacketSide.Client)]
    public class CP2CAnimation : NetworkPacket {

        public bool MainHand { get; }

        public CP2CAnimation(Stream stream) : base(stream) {
            MainHand = ReadVarInt() == 0;
        }
    }
}