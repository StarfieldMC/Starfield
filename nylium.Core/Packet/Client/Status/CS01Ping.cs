using System;
using System.IO;
using nylium.Core.DataTypes;

namespace nylium.Core.Packet.Client.Status {

    [Packet(1, ProtocolState.Status, PacketSide.Client)]
    public class CS01Ping : NetworkPacket {

        public long Payload { get; }

        public CS01Ping(Stream stream) : base(stream) {
            Long _long = new(Data);
            Payload = _long.Value;
        }
    }
}
