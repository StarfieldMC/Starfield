using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Server {

    [Packet(1, ProtocolState.STATUS, PacketSide.SERVER)]
    public class SS01Pong : Packet {

        public long Payload { get; }
    
        public SS01Pong(long payload) {
            this.Payload = payload;

            Long _long = new Long(payload);
            _long.Write(this.Data);
        }
    }
}
