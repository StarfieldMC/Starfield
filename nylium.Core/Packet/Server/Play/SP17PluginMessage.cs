using nylium.Core.DataTypes;
using U = nylium.Utilities;

namespace nylium.Core.Packet.Server.Play {

    [Packet(0x17, ProtocolState.Play, PacketSide.Server)]
    public class SP17PluginMessage : NetworkPacket {

        public U.Identifier Channel { get; }
        public sbyte[] MessageData { get; }

        public SP17PluginMessage(U.Identifier channel, sbyte[] data) {
            Channel = channel;
            MessageData = data;

            Identifier identifier = new(channel);
            identifier.Write(Data);

            WriteByteArray(data);
        }
    }
}
