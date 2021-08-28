// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:smooth_sandstone", 472, 8419, 8419, 8419)]
    public class BlockSmoothSandstone : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockSmoothSandstone() {
            State = DefaultState;
        }

        public BlockSmoothSandstone(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}