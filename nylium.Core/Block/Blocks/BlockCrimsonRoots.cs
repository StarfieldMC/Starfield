// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:crimson_roots", 703, 15052, 15052, 15052)]
    public class BlockCrimsonRoots : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockCrimsonRoots() {
            State = DefaultState;
        }

        public BlockCrimsonRoots(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}