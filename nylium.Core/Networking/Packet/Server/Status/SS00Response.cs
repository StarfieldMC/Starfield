namespace nylium.Core.Networking.Packet.Server.Status {

    [Packet(0, ProtocolState.Status, PacketSide.Server)]
    public class SS00Response : MinecraftPacket {

        public string JsonResponse { get; }

        public SS00Response(string jsonResponse) {
            JsonResponse = jsonResponse;

            WriteString(jsonResponse);
        }
    }
}
