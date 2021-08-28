using Starfield.Utilities;

namespace Starfield.Core.Networking.Packet.Server.Play {

    [Packet(0x0B, ProtocolState.Play, PacketSide.Server)]
    public class SP0BBlockChange : MinecraftPacket {

        public Position.Int Location { get; }
        public int BlockId { get; }

        public SP0BBlockChange(MinecraftClient client, Position.Int location, int blockId) : base(client) {
            Location = Data.WritePosition(location);
            BlockId = Data.WriteVarInt(blockId);
        }
    }
}