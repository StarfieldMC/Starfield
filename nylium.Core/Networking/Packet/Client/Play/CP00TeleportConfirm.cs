using System.IO;

namespace nylium.Core.Networking.Packet.Client.Play {

    [Packet(0x00, ProtocolState.Play, PacketSide.Server)]
    public class CP00TeleportConfirm : MinecraftPacket {

        public int TeleportId { get; }

        public CP00TeleportConfirm(Stream stream) : base(stream) {
            TeleportId = ReadVarInt();
        }
    }
}