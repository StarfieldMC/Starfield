namespace Starfield.Core.Networking.Packet.Server.Login {

    [Packet(0x02, ProtocolState.Login, PacketSide.Server)]
    public class SL02LoginSuccess : MinecraftPacket {

        public DaanV2.UUID.UUID UUID { get; }
        public string Username { get; }

        public SL02LoginSuccess(MinecraftClient client, DaanV2.UUID.UUID uuid, string username) : base(client) {
            UUID = Data.WriteUuid(uuid);
            Username = Data.WriteString(username);
        }
    }
}
