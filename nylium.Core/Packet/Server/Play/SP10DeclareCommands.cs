﻿using nylium.Core.DataTypes;

namespace nylium.Core.Packet.Server.Play {

    [Packet(0x10, ProtocolState.Play, PacketSide.Server)]
    public class SP10DeclareCommands : NetworkPacket {

        // i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind
        // TODO https://wiki.vg/Protocol#Declare_Commands

        public SP10DeclareCommands() {
            VarInt varInt = new(0);
            varInt.Write(Data);
            varInt.Write(Data);
        }
    }
}