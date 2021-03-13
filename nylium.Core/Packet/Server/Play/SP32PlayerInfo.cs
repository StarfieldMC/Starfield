using System;
using nylium.Core.DataTypes;

namespace nylium.Core.Packet.Server.Play {

    // TODO do this properly https://wiki.vg/Protocol#Player_Info
    [Packet(0x32, ProtocolState.Play, PacketSide.Server)]
    public class SP32PlayerInfo : NetworkPacket {

        public SP32PlayerInfo() {
            VarInt varInt = new VarInt(4);
            varInt.Write(Data);

            varInt.Value = 0;
            varInt.Write(Data);
        }
    }
}