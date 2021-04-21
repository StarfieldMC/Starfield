using System.IO;
using nylium.Core.Block;
using nylium.Utilities;

namespace nylium.Core.Networking.Packet.Client.Play {

    [Packet(0x2E, ProtocolState.Play, PacketSide.Client)]
    public class CP2EPlayerBlockPlacement : MinecraftPacket {

        public bool MainHand { get; }
        public Position.Int Location { get; }
        public BaseBlock.Face Face { get; }
        public float CursorPositionX { get; }
        public float CursorPositionY { get; }
        public float CursorPositionZ { get; }
        public bool InsideBlock { get; }

        public CP2EPlayerBlockPlacement(MinecraftClient client, Stream stream) : base(client, stream) {
            MainHand = Data.ReadVarInt() == 0;
            Location = Data.ReadPosition();
            Face = (BaseBlock.Face) Data.ReadVarInt();
            CursorPositionX = Data.ReadFloat();
            CursorPositionY = Data.ReadFloat();
            CursorPositionZ = Data.ReadFloat();
            InsideBlock = Data.ReadBoolean();
        }
    }
}