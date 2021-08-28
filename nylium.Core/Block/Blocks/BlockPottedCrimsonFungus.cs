// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:potted_crimson_fungus", 738, 15842, 15842, 15842)]
    public class BlockPottedCrimsonFungus : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockPottedCrimsonFungus() {
            State = DefaultState;
        }

        public BlockPottedCrimsonFungus(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}