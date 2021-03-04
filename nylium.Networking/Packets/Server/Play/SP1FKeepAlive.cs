using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Server.Play {

    [Packet(0x1f, ProtocolState.PLAY, PacketSide.SERVER)]
    public class SP1FKeepAlive : Packet {

        public long KeepAliveId { get; }

        public SP1FKeepAlive(long keepAliveId) {
            KeepAliveId = keepAliveId;

            Long @long = new Long(keepAliveId);
            @long.Write(Data);
        }
    }
}
