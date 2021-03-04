using System.IO;

namespace nylium.Networking.Packets.Client.Status {

    [Packet(0, ProtocolState.STATUS, PacketSide.CLIENT)]
    public class CS00Request : Packet {
    
        public CS00Request(Stream stream) : base(stream) { }
    }
}
