// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockPottedDandelion : BlockBase {

        public override string Id { get { return "minecraft:potted_dandelion"; } }

        public override ushort MinimumState { get { return 6317; } }
        public override ushort MaximumState { get { return 6317; } }
        public override ushort DefaultState { get { return 6317; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockPottedDandelion() {
            State = DefaultState;
        }

        public BlockPottedDandelion(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}