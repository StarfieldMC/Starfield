using System.IO;
using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Client.Play {

    [Packet(0x10, ProtocolState.PLAY, PacketSide.CLIENT)]
    public class CP10KeepAlive : Packet {

        public long KeepAliveId { get; }

        public CP10KeepAlive(Stream stream) : base(stream) {
            Long @long = new Long();
            @long.Read(stream);
            KeepAliveId = @long.Value;
        }
    }
}
