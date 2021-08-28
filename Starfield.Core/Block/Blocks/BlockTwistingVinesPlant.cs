// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:twisting_vines_plant", 702, 15051, 15051, 15051)]
    public class BlockTwistingVinesPlant : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockTwistingVinesPlant() {
            State = DefaultState;
        }

        public BlockTwistingVinesPlant(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}