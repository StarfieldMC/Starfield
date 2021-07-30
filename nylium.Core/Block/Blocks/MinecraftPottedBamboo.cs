// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockPottedBamboo : BlockBase {

        public override string Id { get { return "minecraft:potted_bamboo"; } }

        public override ushort MinimumState { get { return 9668; } }
        public override ushort MaximumState { get { return 9668; } }
        public override ushort DefaultState { get { return 9668; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockPottedBamboo() {
            State = DefaultState;
        }

        public BlockPottedBamboo(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}