namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x4E, ProtocolState.Play, PacketSide.Server)]
    public class SP4ETimeUpdate : MinecraftPacket {

        public long WorldAge { get; }
        public long TimeOfDay { get; }

        public SP4ETimeUpdate(MinecraftClient client, long worldAge, long timeOfDay) : base(client) {
            WorldAge = Data.WriteLong(worldAge);
            TimeOfDay = Data.WriteLong(timeOfDay);
        }
    }
}