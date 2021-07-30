// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockDarkOakPlanks : BlockBase {

        public override string Id { get { return "minecraft:dark_oak_planks"; } }

        public override ushort MinimumState { get { return 20; } }
        public override ushort MaximumState { get { return 20; } }
        public override ushort DefaultState { get { return 20; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockDarkOakPlanks() {
            State = DefaultState;
        }

        public BlockDarkOakPlanks(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}