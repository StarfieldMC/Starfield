// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockInfestedMossyStoneBricks : BlockBase {

        public override string Id { get { return "minecraft:infested_mossy_stone_bricks"; } }

        public override ushort MinimumState { get { return 4502; } }
        public override ushort MaximumState { get { return 4502; } }
        public override ushort DefaultState { get { return 4502; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockInfestedMossyStoneBricks() {
            State = DefaultState;
        }

        public BlockInfestedMossyStoneBricks(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}