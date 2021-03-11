using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Server.Status {

    [Packet(1, ProtocolState.Status, PacketSide.Server)]
    public class SS01Pong : Packet {

        public long Payload { get; }
    
        public SS01Pong(long payload) {
            Payload = payload;

            Long _long = new(payload);
            _long.Write(Data);
        }
    }
}
