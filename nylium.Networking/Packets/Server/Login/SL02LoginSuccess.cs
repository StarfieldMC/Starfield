using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Server.Login {

    [Packet(2, ProtocolState.LOGIN, PacketSide.SERVER)]
    public class SL02LoginSuccess : Packet {

        public DaanV2.UUID.UUID UUID { get; }
        public string Username { get; }

        public SL02LoginSuccess(DaanV2.UUID.UUID value, string username) {
            UUID = value;
            Username = username;

            UUID uuid = new UUID(value);
            uuid.Write(Data);

            String @string = new String(username);
            @string.Write(Data);
        }
    }
}
