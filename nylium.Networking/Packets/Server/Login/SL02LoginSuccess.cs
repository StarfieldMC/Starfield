using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Server.Login {

    [Packet(2, ProtocolState.Login, PacketSide.Server)]
    public class SL02LoginSuccess : Packet {

        public DaanV2.UUID.UUID UUID { get; }
        public string Username { get; }

        public SL02LoginSuccess(DaanV2.UUID.UUID value, string username) {
            UUID = value;
            Username = username;

            UUID uuid = new(value);
            uuid.Write(Data);

            String @string = new(username);
            @string.Write(Data);
        }
    }
}
