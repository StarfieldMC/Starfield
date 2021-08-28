// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:red_nether_bricks", 505, 9259, 9259, 9259)]
    public class BlockRedNetherBricks : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockRedNetherBricks() {
            State = DefaultState;
        }

        public BlockRedNetherBricks(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}