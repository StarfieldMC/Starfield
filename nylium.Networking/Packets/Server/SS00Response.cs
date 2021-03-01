using System;
using System.IO;
using DT = nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Server {

    [Packet(0, ProtocolState.STATUS, PacketSide.SERVER)]
    public class SS00Response : Packet {

        public string JsonResponse { get; }

        public SS00Response(string jsonResponse) {
            this.JsonResponse = jsonResponse;

            DT.String str = new DT.String(jsonResponse);
            str.Write(this.Data);
        }
    }
}
