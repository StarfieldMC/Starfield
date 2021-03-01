using System;

namespace nylium.Networking.Packets.Client {

    [Packet(0, ProtocolState.STATUS, PacketSide.CLIENT)]
    public class CS00Request : Packet { }
}
