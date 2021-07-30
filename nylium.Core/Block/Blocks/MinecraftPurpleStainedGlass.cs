// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockPurpleStainedGlass : BlockBase {

        public override string Id { get { return "minecraft:purple_stained_glass"; } }

        public override ushort MinimumState { get { return 4105; } }
        public override ushort MaximumState { get { return 4105; } }
        public override ushort DefaultState { get { return 4105; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockPurpleStainedGlass() {
            State = DefaultState;
        }

        public BlockPurpleStainedGlass(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}