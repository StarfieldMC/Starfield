namespace nylium.Core.Networking.Packet.Server.Status {

    [Packet(0x00, ProtocolState.Status, PacketSide.Server)]
    public class SS00Response : MinecraftPacket {

        public string JsonResponse { get; }

        public SS00Response(MinecraftClient client, string jsonResponse) : base(client) {
            JsonResponse = Data.WriteString(jsonResponse);
        }
    }
}
