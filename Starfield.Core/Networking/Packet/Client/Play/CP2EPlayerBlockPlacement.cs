using System.IO;
using Starfield.Utilities;

namespace Starfield.Core.Networking.Packet.Client.Play {

    [Packet(0x2E, ProtocolState.Play, PacketSide.Client)]
    public class CP2EPlayerBlockPlacement : MinecraftPacket {

        public bool MainHand { get; }
        public Position.Int Location { get; }
        public Face Face { get; }
        public float CursorPositionX { get; }
        public float CursorPositionY { get; }
        public float CursorPositionZ { get; }
        public bool InsideBlock { get; }

        public CP2EPlayerBlockPlacement(MinecraftClient client, Stream stream) : base(client, stream) {
            MainHand = Data.ReadVarInt() == 0;
            Location = Data.ReadPosition();
            Face = (Face) Data.ReadVarInt();
            CursorPositionX = Data.ReadFloat();
            CursorPositionY = Data.ReadFloat();
            CursorPositionZ = Data.ReadFloat();
            InsideBlock = Data.ReadBoolean();
        }
    }
}