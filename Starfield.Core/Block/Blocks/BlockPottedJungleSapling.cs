// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:potted_jungle_sapling", 285, 6313, 6313, 6313)]
    public class BlockPottedJungleSapling : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockPottedJungleSapling() {
            State = DefaultState;
        }

        public BlockPottedJungleSapling(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}