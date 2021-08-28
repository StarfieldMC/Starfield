// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:light_blue_carpet", 394, 7873, 7873, 7873)]
    public class BlockLightBlueCarpet : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockLightBlueCarpet() {
            State = DefaultState;
        }

        public BlockLightBlueCarpet(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}