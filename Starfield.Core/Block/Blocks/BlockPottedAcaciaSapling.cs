// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:potted_acacia_sapling", 286, 6314, 6314, 6314)]
    public class BlockPottedAcaciaSapling : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockPottedAcaciaSapling() {
            State = DefaultState;
        }

        public BlockPottedAcaciaSapling(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}