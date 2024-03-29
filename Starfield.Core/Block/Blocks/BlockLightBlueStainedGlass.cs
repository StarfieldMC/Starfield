// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:light_blue_stained_glass", 209, 4098, 4098, 4098)]
    public class BlockLightBlueStainedGlass : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockLightBlueStainedGlass() {
            State = DefaultState;
        }

        public BlockLightBlueStainedGlass(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}