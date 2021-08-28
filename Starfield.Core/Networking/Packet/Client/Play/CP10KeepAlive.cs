using System.IO;

namespace Starfield.Core.Networking.Packet.Client.Play {

    [Packet(0x10, ProtocolState.Play, PacketSide.Client)]
    public class CP10KeepAlive : MinecraftPacket {

        public long KeepAliveId { get; }

        public CP10KeepAlive(MinecraftClient client, Stream stream) : base(client, stream) {
            KeepAliveId = Data.ReadLong();
        }
    }
}
