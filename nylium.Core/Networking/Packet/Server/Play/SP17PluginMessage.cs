using nylium.Utilities;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x17, ProtocolState.Play, PacketSide.Server)]
    public class SP17PluginMessage : MinecraftPacket {

        public Identifier Channel { get; }
        public sbyte[] MessageData { get; }

        public SP17PluginMessage(Identifier channel, sbyte[] data) {
            Channel = channel;
            MessageData = data;

            WriteIdentifier(channel);
            WriteByteArray(data);
        }
    }
}
