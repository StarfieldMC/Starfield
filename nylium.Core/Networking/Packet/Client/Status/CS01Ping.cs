using System;
using System.IO;

namespace nylium.Core.Networking.Packet.Client.Status {

    [Packet(1, ProtocolState.Status, PacketSide.Client)]
    public class CS01Ping : MinecraftPacket {

        public long Payload { get; }

        public CS01Ping(Stream stream) : base(stream) {
            Payload = ReadLong();
        }
    }
}
