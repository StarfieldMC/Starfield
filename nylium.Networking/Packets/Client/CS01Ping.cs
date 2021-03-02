using System;
using System.IO;
using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Client {

    [Packet(1, ProtocolState.STATUS, PacketSide.CLIENT)]
    public class CS01Ping : Packet {

        public long Payload { get; }

        public CS01Ping(Stream stream) : base(stream) {
            Data.Seek(0, SeekOrigin.Begin);

            Long _long = new Long();
            _long.Read(Data, out _);
            Payload = _long.Value;
        }
    }
}
