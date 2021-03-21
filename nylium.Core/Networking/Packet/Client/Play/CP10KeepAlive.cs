using System.IO;
using nylium.Core.DataTypes;

namespace nylium.Core.Networking.Packet.Client.Play {

    [Packet(0x10, ProtocolState.Play, PacketSide.Client)]
    public class CP10KeepAlive : NetworkPacket {

        public long KeepAliveId { get; }

        public CP10KeepAlive(Stream stream) : base(stream) {
            KeepAliveId = ReadLong();
        }
    }
}
