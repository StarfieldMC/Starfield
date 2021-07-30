// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockMagmaBlock : BlockBase {

        public override string Id { get { return "minecraft:magma_block"; } }

        public override ushort MinimumState { get { return 9257; } }
        public override ushort MaximumState { get { return 9257; } }
        public override ushort DefaultState { get { return 9257; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockMagmaBlock() {
            State = DefaultState;
        }

        public BlockMagmaBlock(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}