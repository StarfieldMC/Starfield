using System.IO;
using nylium.Core.DataTypes;

namespace nylium.Core.Packet.Client.Play {

    [Packet(0x10, ProtocolState.Play, PacketSide.Client)]
    public class CP10KeepAlive : NetworkPacket {

        public long KeepAliveId { get; }

        public CP10KeepAlive(Stream stream) : base(stream) {
            Long @long = new(Data);
            KeepAliveId = @long.Value;
        }
    }
}
