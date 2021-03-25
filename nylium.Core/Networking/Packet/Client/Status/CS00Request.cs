﻿using System.IO;

namespace nylium.Core.Networking.Packet.Client.Status {

    [Packet(0, ProtocolState.Status, PacketSide.Client)]
    public class CS00Request : MinecraftPacket {
    
        public CS00Request(Stream stream) : base(stream) { }
    }
}
