using System;
using System.IO;

namespace nylium.Core.Networking.Packet.Client.Play {

    [Packet(0x12, ProtocolState.Play, PacketSide.Client)]
    public class CP12PlayerPosition : MinecraftPacket {
        
        public double X { get; }
        public double FeetY { get; }
        public double Z { get; }
        public bool OnGround { get; }

        public CP12PlayerPosition(MinecraftClient client, Stream stream) : base(client, stream) {
            X = Data.ReadDouble();
            FeetY = Data.ReadDouble();
            Z = Data.ReadDouble();
            OnGround = Data.ReadBoolean();
        }
    }
}