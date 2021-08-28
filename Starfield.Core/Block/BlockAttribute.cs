using System;
using Starfield.Utilities;

namespace Starfield.Core.Block {
    
    class BlockAttribute : Attribute {
        
        public Identifier Id { get; }
        public int ProtocolId { get; }
        
        public ushort MinimumState { get; }
        public ushort MaximumState { get; }
        public ushort DefaultState { get; }

        public BlockAttribute(string id, int protocolId,
            ushort minState, ushort maxState, ushort defaultState) {

            Id = new Identifier(id);
            ProtocolId = protocolId;
            MinimumState = minState;
            MaximumState = maxState;
            DefaultState = defaultState;
        }
    }
}
