using System;
using System.Collections.Generic;

namespace nylium.Core.Block {

    public abstract class BlockBase {

        public abstract string Id { get; }

        public abstract ushort MinimumState { get; }
        public abstract ushort MaximumState { get; }
        public abstract ushort DefaultState { get; }

        public abstract ushort State { get; set; }
    }
}