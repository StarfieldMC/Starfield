// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:gray_stained_glass", 213, 4102, 4102, 4102)]
    public class BlockGrayStainedGlass : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockGrayStainedGlass() {
            State = DefaultState;
        }

        public BlockGrayStainedGlass(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}