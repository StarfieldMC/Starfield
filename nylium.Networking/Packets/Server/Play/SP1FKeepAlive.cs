using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Server.Play {

    [Packet(0x1f, ProtocolState.Play, PacketSide.Server)]
    public class SP1FKeepAlive : Packet {

        public long KeepAliveId { get; }

        public SP1FKeepAlive(long keepAliveId) {
            KeepAliveId = keepAliveId;

            Long @long = new(keepAliveId);
            @long.Write(Data);
        }
    }
}
