// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:potted_pink_tulip", 297, 6325, 6325, 6325)]
    public class BlockPottedPinkTulip : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockPottedPinkTulip() {
            State = DefaultState;
        }

        public BlockPottedPinkTulip(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}