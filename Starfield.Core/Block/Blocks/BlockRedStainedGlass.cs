// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:red_stained_glass", 220, 4109, 4109, 4109)]
    public class BlockRedStainedGlass : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockRedStainedGlass() {
            State = DefaultState;
        }

        public BlockRedStainedGlass(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}