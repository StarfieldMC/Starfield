using nylium.Core.DataTypes;

namespace nylium.Core.Packet.Server.Login {

    [Packet(0, ProtocolState.Login, PacketSide.Server)]
    public class SL00Disconnect : NetworkPacket {

        public dynamic Reason { get; }

        public SL00Disconnect(dynamic reason) {
            Reason = reason;

            Chat chat = new(reason);
            chat.Write(Data);
        }
    }
}
