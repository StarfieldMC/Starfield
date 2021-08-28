// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:pink_concrete_powder", 564, 9464, 9464, 9464)]
    public class BlockPinkConcretePowder : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockPinkConcretePowder() {
            State = DefaultState;
        }

        public BlockPinkConcretePowder(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}