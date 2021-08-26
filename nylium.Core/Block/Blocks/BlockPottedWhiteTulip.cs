// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:potted_white_tulip", 296, 6324, 6324, 6324)]
    public class BlockPottedWhiteTulip : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockPottedWhiteTulip() {
            State = DefaultState;
        }

        public BlockPottedWhiteTulip(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}