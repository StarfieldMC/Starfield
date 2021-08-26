// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:light_gray_terracotta", 351, 6859, 6859, 6859)]
    public class BlockLightGrayTerracotta : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockLightGrayTerracotta() {
            State = DefaultState;
        }

        public BlockLightGrayTerracotta(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}