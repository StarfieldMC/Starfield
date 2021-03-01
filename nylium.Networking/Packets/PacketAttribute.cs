using System;

namespace nylium.Networking.Packets {

    class PacketAttribute : Attribute {

        public int Id { get; }
        public ProtocolState State { get; }
        public PacketSide Side { get; }

        public PacketAttribute(int id, ProtocolState state, PacketSide side) {
            this.Id = id;
            this.State = state;
            this.Side = side;
        }
    }
}
