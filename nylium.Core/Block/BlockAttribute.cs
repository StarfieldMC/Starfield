using System;
using nylium.Utilities;

namespace nylium.Core.Block {
    
    class BlockAttribute : Attribute {
        
        public Identifier Id { get; }
        public int ProtocolId { get; }
        
        public ushort MinimumState { get; }
        public ushort MaximumState { get; }
        public ushort DefaultState { get; }

        public BlockAttribute(Identifier id, int protocolId,
            ushort minState, ushort maxState, ushort defaultState) {

            Id = id;
            ProtocolId = protocolId;
            MinimumState = minState;
            MaximumState = maxState;
            DefaultState = defaultState;
        }
    }
}