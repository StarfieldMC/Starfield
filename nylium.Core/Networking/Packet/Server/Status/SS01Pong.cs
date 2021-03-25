namespace nylium.Core.Networking.Packet.Server.Status {

    [Packet(1, ProtocolState.Status, PacketSide.Server)]
    public class SS01Pong : MinecraftPacket {

        public long Payload { get; }

        public SS01Pong(long payload) {
            Payload = payload;

            WriteLong(payload);
        }
    }
}
