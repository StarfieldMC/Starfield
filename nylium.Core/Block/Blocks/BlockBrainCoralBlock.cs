// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:brain_coral_block", 584, 9520, 9520, 9520)]
    public class BlockBrainCoralBlock : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockBrainCoralBlock() {
            State = DefaultState;
        }

        public BlockBrainCoralBlock(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}