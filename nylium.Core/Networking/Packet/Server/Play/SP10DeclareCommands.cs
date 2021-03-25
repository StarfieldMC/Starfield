namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x10, ProtocolState.Play, PacketSide.Server)]
    public class SP10DeclareCommands : MinecraftPacket {

        // i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind
        // TODO https://wiki.vg/Protocol#Declare_Commands

        public SP10DeclareCommands() {
            WriteVarInt(0);
            WriteVarInt(0);
        }
    }
}