using Starfield.Utilities;

namespace Starfield.Core.Networking.Packet.Server.Play {

    [Packet(0x17, ProtocolState.Play, PacketSide.Server)]
    public class SP17PluginMessage : MinecraftPacket {

        public Identifier Channel { get; }
        public sbyte[] MessageData { get; }

        public SP17PluginMessage(MinecraftClient client, Identifier channel, sbyte[] data) : base(client) {
            Channel = Data.WriteIdentifier(channel);
            MessageData = Data.WriteByteArray(data);
        }
    }
}
