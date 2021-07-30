// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockRedWool : BlockBase {

        public override string Id { get { return "minecraft:red_wool"; } }

        public override ushort MinimumState { get { return 1398; } }
        public override ushort MaximumState { get { return 1398; } }
        public override ushort DefaultState { get { return 1398; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockRedWool() {
            State = DefaultState;
        }

        public BlockRedWool(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}