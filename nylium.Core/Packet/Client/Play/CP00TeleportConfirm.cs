using System.IO;
using nylium.Core.DataTypes;

namespace nylium.Core.Packet.Client.Play {

    [Packet(0x00, ProtocolState.Play, PacketSide.Server)]
    public class CP00TeleportConfirm : NetworkPacket {

        public int TeleportId { get; }

        public CP00TeleportConfirm(Stream stream) : base(stream) {
            TeleportId = ReadVarInt();
        }
    }
}