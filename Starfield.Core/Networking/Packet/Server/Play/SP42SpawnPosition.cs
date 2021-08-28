using Starfield.Utilities;

namespace Starfield.Core.Networking.Packet.Server.Play {

    [Packet(0x42, ProtocolState.Play, PacketSide.Server)]
    public class SP42SpawnPosition : MinecraftPacket {

        public Position.Int Location { get; }

        public SP42SpawnPosition(MinecraftClient client, Position.Int location) : base(client) {
            Location = Data.WritePosition(location);
        }
    }
}