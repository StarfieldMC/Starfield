namespace Starfield.Core.Networking.Packet.Server.Login {

    [Packet(0x00, ProtocolState.Login, PacketSide.Server)]
    public class SL00Disconnect : MinecraftPacket {

        public dynamic Reason { get; }

        public SL00Disconnect(MinecraftClient client, dynamic reason) : base(client) {
            Reason = Data.WriteChat(reason);
        }
    }
}
