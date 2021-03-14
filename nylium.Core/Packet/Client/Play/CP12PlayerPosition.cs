using System;
using System.IO;

namespace nylium.Core.Packet.Client.Play {

    [Packet(0x12, ProtocolState.Play, PacketSide.Client)]
    public class CP12PlayerPosition : NetworkPacket {
        
        public double X { get; }
        public double FeetY { get; }
        public double Z { get; }
        public bool OnGround { get; }

        public CP12PlayerPosition(Stream stream) : base(stream) {
            X = ReadDouble();
            FeetY = ReadDouble();
            Z = ReadDouble();
            OnGround = ReadBoolean();
        }
    }
}