namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x19, ProtocolState.Play, PacketSide.Server)]
    public class SP19Disconnect : MinecraftPacket {

        public dynamic Reason { get; }

        public SP19Disconnect(dynamic reason) {
            Reason = reason;

            WriteChat(reason);
        }
    }
}
