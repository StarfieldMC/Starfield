using nylium.Networking.DataTypes;
using U = nylium.Utilities;

namespace nylium.Networking.Packets.Server.Play {

    [Packet(0x17, ProtocolState.PLAY, PacketSide.SERVER)]
    public class SP17PluginMessage : Packet {

        public U.Identifier Channel { get; }
        public sbyte[] MessageData { get; }

        public SP17PluginMessage(U.Identifier channel, sbyte[] data) {
            Channel = channel;
            MessageData = data;

            Identifier identifier = new Identifier(channel);
            identifier.Write(Data);

            ByteArray byteArray = new ByteArray(data);
            byteArray.Write(Data);
        }
    }
}
