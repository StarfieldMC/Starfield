using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Server.Status {

    [Packet(0, ProtocolState.Status, PacketSide.Server)]
    public class SS00Response : Packet {

        public string JsonResponse { get; }

        public SS00Response(string jsonResponse) {
            JsonResponse = jsonResponse;

            String @string = new(jsonResponse);
            @string.Write(Data);
        }
    }
}
