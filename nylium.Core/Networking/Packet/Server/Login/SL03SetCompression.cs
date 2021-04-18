namespace nylium.Core.Networking.Packet.Server.Login {

    [Packet(0x03, ProtocolState.Login, PacketSide.Server)]
    public class SL03SetCompression : MinecraftPacket {

        public int Threshold { get; }

        public SL03SetCompression(MinecraftClient client, int threshold) : base(client) {
            Threshold = Data.WriteVarInt(threshold);
        }
    }
}