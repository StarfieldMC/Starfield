using System;
using nylium.Networking.DataTypes;
using U = nylium.Utilities;

namespace nylium.Networking.Packets.Server.Play {

    [Packet(0x42, ProtocolState.Play, PacketSide.Server)]
    public class SP42SpawnPosition : Packet {

        public U.Position.Int Location { get; }

        public SP42SpawnPosition(U.Position.Int location) {
            Location = location;

            Position position = new(location);
            position.Write(Data);
        }
    }
}