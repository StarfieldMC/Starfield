using System.IO;

namespace Starfield.Core.Networking.Packet.Client.Play {

    [Packet(0x2C, ProtocolState.Play, PacketSide.Client)]
    public class CP2CAnimation : MinecraftPacket {

        public bool MainHand { get; }

        public CP2CAnimation(MinecraftClient client, Stream stream) : base(client, stream) {
            MainHand = Data.ReadVarInt() == 0;
        }
    }
}