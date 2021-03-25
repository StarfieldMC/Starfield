namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x4E, ProtocolState.Play, PacketSide.Server)]
    public class SP4ETimeUpdate : MinecraftPacket {

        public long WorldAge { get; }
        public long TimeOfDay { get; }

        public SP4ETimeUpdate(long worldAge, long timeOfDay) {
            WorldAge = worldAge;
            TimeOfDay = timeOfDay;

            WriteLong(worldAge);
            WriteLong(timeOfDay);
        }
    }
}