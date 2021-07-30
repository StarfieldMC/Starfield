// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockDiamondBlock : BlockBase {

        public override string Id { get { return "minecraft:diamond_block"; } }

        public override ushort MinimumState { get { return 3355; } }
        public override ushort MaximumState { get { return 3355; } }
        public override ushort DefaultState { get { return 3355; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockDiamondBlock() {
            State = DefaultState;
        }

        public BlockDiamondBlock(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}