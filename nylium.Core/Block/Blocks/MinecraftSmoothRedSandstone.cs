// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockSmoothRedSandstone : BlockBase {

        public override string Id { get { return "minecraft:smooth_red_sandstone"; } }

        public override ushort MinimumState { get { return 8421; } }
        public override ushort MaximumState { get { return 8421; } }
        public override ushort DefaultState { get { return 8421; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockSmoothRedSandstone() {
            State = DefaultState;
        }

        public BlockSmoothRedSandstone(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}