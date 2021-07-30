// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockPottedRedMushroom : BlockBase {

        public override string Id { get { return "minecraft:potted_red_mushroom"; } }

        public override ushort MinimumState { get { return 6330; } }
        public override ushort MaximumState { get { return 6330; } }
        public override ushort DefaultState { get { return 6330; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockPottedRedMushroom() {
            State = DefaultState;
        }

        public BlockPottedRedMushroom(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}