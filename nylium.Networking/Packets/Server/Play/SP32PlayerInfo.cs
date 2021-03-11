using System;
using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Server.Play {

    // TODO do this properly https://wiki.vg/Protocol#Player_Info
    [Packet(0x32, ProtocolState.Play, PacketSide.Server)]
    public class SP32PlayerInfo : Packet {

        public SP32PlayerInfo() {
            VarInt varInt = new VarInt(4);
            varInt.Write(Data);

            varInt.Value = 0;
            varInt.Write(Data);
        }
    }
}