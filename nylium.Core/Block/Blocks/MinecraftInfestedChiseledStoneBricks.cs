// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockInfestedChiseledStoneBricks : BlockBase {

        public override string Id { get { return "minecraft:infested_chiseled_stone_bricks"; } }

        public override ushort MinimumState { get { return 4504; } }
        public override ushort MaximumState { get { return 4504; } }
        public override ushort DefaultState { get { return 4504; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockInfestedChiseledStoneBricks() {
            State = DefaultState;
        }

        public BlockInfestedChiseledStoneBricks(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}