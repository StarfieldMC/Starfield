using System;

namespace nylium.Core.Packet {

    class PacketAttribute : Attribute {

        public int Id { get; }
        public ProtocolState State { get; }
        public PacketSide Side { get; }

        public PacketAttribute(int id, ProtocolState state, PacketSide side) {
            Id = id;
            State = state;
            Side = side;
        }
    }
}
