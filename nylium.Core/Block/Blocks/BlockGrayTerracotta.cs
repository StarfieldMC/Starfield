// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:gray_terracotta", 350, 6858, 6858, 6858)]
    public class BlockGrayTerracotta : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockGrayTerracotta() {
            State = DefaultState;
        }

        public BlockGrayTerracotta(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}