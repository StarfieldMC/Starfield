using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Server {

    [Packet(0, ProtocolState.STATUS, PacketSide.SERVER)]
    public class SS00Response : Packet {

        public string JsonResponse { get; }

        public SS00Response(string jsonResponse) {
            JsonResponse = jsonResponse;

            String @string = new String(jsonResponse);
            @string.Write(Data);
        }
    }
}
