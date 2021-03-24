using System.IO;

namespace nylium.Core.Networking.Packet.Client.Play {

    [Packet(0x25, ProtocolState.Play, PacketSide.Client)]
    public class CP25HeldItemChange : NetworkPacket {

        public short Slot { get; }

        public CP25HeldItemChange(Stream stream) : base(stream) {
            Slot = ReadShort();
        }
    }
}