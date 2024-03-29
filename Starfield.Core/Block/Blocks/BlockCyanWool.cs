// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:cyan_wool", 111, 1393, 1393, 1393)]
    public class BlockCyanWool : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockCyanWool() {
            State = DefaultState;
        }

        public BlockCyanWool(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}