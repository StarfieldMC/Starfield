using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Server.Play {

    [Packet(0x10, ProtocolState.Play, PacketSide.Server)]
    public class SP10DeclareCommands : Packet {

        // i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind
        // TODO https://wiki.vg/Protocol#Declare_Commands

        public SP10DeclareCommands() {
            VarInt varInt = new(0);
            varInt.Write(Data);
            varInt.Write(Data);
        }
    }
}