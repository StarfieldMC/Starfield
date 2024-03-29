// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:blue_stained_glass", 217, 4106, 4106, 4106)]
    public class BlockBlueStainedGlass : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockBlueStainedGlass() {
            State = DefaultState;
        }

        public BlockBlueStainedGlass(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}