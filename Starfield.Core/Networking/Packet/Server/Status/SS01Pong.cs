namespace Starfield.Core.Networking.Packet.Server.Status {

    [Packet(1, ProtocolState.Status, PacketSide.Server)]
    public class SS01Pong : MinecraftPacket {

        public long Payload { get; }

        public SS01Pong(MinecraftClient client, long payload) : base(client) {
            Payload = Data.WriteLong(payload);
        }
    }
}
