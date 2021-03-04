using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Server.Login {

    [Packet(0, ProtocolState.LOGIN, PacketSide.SERVER)]
    public class SL00Disconnect : Packet {

        public dynamic Reason { get; }

        public SL00Disconnect(dynamic reason) {
            Reason = reason;

            Chat chat = new Chat();
            chat.SetValue(reason);
            chat.Write(Data);
        }
    }
}
