namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x3F, ProtocolState.Play, PacketSide.Server)]
    public class SP3FHeldItemChange : MinecraftPacket {

        public sbyte Slot { get; }

        public SP3FHeldItemChange(MinecraftClient client, sbyte slot) : base(client) {
            Slot = Data.WriteByte(slot);
        }
    }
}