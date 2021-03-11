using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Server.Login {

    [Packet(0, ProtocolState.Login, PacketSide.Server)]
    public class SL00Disconnect : Packet {

        public dynamic Reason { get; }

        public SL00Disconnect(dynamic reason) {
            Reason = reason;

            Chat chat = new(reason);
            chat.Write(Data);
        }
    }
}
