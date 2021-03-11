using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Server.Play {

    [Packet(0x19, ProtocolState.Play, PacketSide.Server)]
    public class SP19Disconnect : Packet {

        public dynamic Reason { get; }

        public SP19Disconnect(dynamic reason) {
            Reason = reason;

            Chat chat = new(reason);
            chat.Write(Data);
        }
    }
}
