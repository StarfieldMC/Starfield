// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:magenta_concrete", 544, 9444, 9444, 9444)]
    public class BlockMagentaConcrete : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockMagentaConcrete() {
            State = DefaultState;
        }

        public BlockMagentaConcrete(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}