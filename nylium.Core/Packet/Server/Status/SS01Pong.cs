using nylium.Core.DataTypes;

namespace nylium.Core.Packet.Server.Status {

    [Packet(1, ProtocolState.Status, PacketSide.Server)]
    public class SS01Pong : NetworkPacket {

        public long Payload { get; }
    
        public SS01Pong(long payload) {
            Payload = payload;

            Long _long = new(payload);
            _long.Write(Data);
        }
    }
}
