// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:infested_mossy_stone_bricks", 235, 4502, 4502, 4502)]
    public class BlockInfestedMossyStoneBricks : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockInfestedMossyStoneBricks() {
            State = DefaultState;
        }

        public BlockInfestedMossyStoneBricks(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}