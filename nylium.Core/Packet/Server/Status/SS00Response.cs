using nylium.Core.DataTypes;

namespace nylium.Core.Packet.Server.Status {

    [Packet(0, ProtocolState.Status, PacketSide.Server)]
    public class SS00Response : NetworkPacket {

        public string JsonResponse { get; }

        public SS00Response(string jsonResponse) {
            JsonResponse = jsonResponse;

            String @string = new(jsonResponse);
            @string.Write(Data);
        }
    }
}
