using nylium.Core.DataTypes;

namespace nylium.Core.Packet.Server.Login {

    [Packet(2, ProtocolState.Login, PacketSide.Server)]
    public class SL02LoginSuccess : NetworkPacket {

        public DaanV2.UUID.UUID UUID { get; }
        public string Username { get; }

        public SL02LoginSuccess(DaanV2.UUID.UUID uuid, string username) {
            UUID = uuid;
            Username = username;

            WriteUuid(uuid);
            WriteString(username);
        }
    }
}
