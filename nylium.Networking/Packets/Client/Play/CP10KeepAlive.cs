using System.IO;
using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Client.Play {

    [Packet(0x10, ProtocolState.Play, PacketSide.Client)]
    public class CP10KeepAlive : Packet {

        public long KeepAliveId { get; }

        public CP10KeepAlive(Stream stream) : base(stream) {
            Long @long = new(Data);
            KeepAliveId = @long.Value;
        }
    }
}
