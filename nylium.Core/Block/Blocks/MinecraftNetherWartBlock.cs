// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockNetherWartBlock : BlockBase {

        public override string Id { get { return "minecraft:nether_wart_block"; } }

        public override ushort MinimumState { get { return 9258; } }
        public override ushort MaximumState { get { return 9258; } }
        public override ushort DefaultState { get { return 9258; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockNetherWartBlock() {
            State = DefaultState;
        }

        public BlockNetherWartBlock(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}