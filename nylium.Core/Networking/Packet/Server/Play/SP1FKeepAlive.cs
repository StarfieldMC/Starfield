namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x1f, ProtocolState.Play, PacketSide.Server)]
    public class SP1FKeepAlive : MinecraftPacket {

        public long KeepAliveId { get; }

        public SP1FKeepAlive(long keepAliveId) {
            KeepAliveId = keepAliveId;

            WriteLong(keepAliveId);
        }
    }
}
