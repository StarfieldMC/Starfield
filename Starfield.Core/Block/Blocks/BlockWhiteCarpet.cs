// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:white_carpet", 391, 7870, 7870, 7870)]
    public class BlockWhiteCarpet : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockWhiteCarpet() {
            State = DefaultState;
        }

        public BlockWhiteCarpet(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}