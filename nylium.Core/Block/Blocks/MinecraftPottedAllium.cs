// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockPottedAllium : BlockBase {

        public override string Id { get { return "minecraft:potted_allium"; } }

        public override ushort MinimumState { get { return 6320; } }
        public override ushort MaximumState { get { return 6320; } }
        public override ushort DefaultState { get { return 6320; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockPottedAllium() {
            State = DefaultState;
        }

        public BlockPottedAllium(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}