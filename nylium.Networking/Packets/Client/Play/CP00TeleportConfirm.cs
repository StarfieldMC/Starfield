using System.IO;
using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Client.Play {

    [Packet(0x00, ProtocolState.Play, PacketSide.Server)]
    public class CP00TeleportConfirm : Packet {

        public int TeleportId { get; }

        public CP00TeleportConfirm(Stream stream) : base(stream) {
            VarInt varInt = new(stream);
            TeleportId = varInt.Value;
        }
    }
}