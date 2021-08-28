using System.IO;

namespace Starfield.Core.Networking.Packet.Client.Play {

    [Packet(0x00, ProtocolState.Play, PacketSide.Server)]
    public class CP00TeleportConfirm : MinecraftPacket {

        public int TeleportId { get; }

        public CP00TeleportConfirm(MinecraftClient client, Stream stream) : base(client, stream) {
            TeleportId = Data.ReadVarInt();
        }
    }
}