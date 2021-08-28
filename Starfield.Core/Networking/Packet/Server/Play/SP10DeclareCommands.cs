namespace Starfield.Core.Networking.Packet.Server.Play {

    [Packet(0x10, ProtocolState.Play, PacketSide.Server)]
    public class SP10DeclareCommands : MinecraftPacket {

        // i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind i am losing my mind
        // TODO https://wiki.vg/Protocol#Declare_Commands

        public SP10DeclareCommands(MinecraftClient client) : base(client) {
            Data.WriteVarInt(0);
            Data.WriteVarInt(0);
        }
    }
}