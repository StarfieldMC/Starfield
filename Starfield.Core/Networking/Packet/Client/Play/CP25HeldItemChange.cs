using System.IO;

namespace Starfield.Core.Networking.Packet.Client.Play {

    [Packet(0x25, ProtocolState.Play, PacketSide.Client)]
    public class CP25HeldItemChange : MinecraftPacket {

        public short Slot { get; }

        public CP25HeldItemChange(MinecraftClient client, Stream stream) : base(client, stream) {
            Slot = Data.ReadShort();
        }
    }
}