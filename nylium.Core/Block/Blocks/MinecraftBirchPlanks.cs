// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockBirchPlanks : BlockBase {

        public override string Id { get { return "minecraft:birch_planks"; } }

        public override ushort MinimumState { get { return 17; } }
        public override ushort MaximumState { get { return 17; } }
        public override ushort DefaultState { get { return 17; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockBirchPlanks() {
            State = DefaultState;
        }

        public BlockBirchPlanks(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}