// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockIce : BlockBase {

        public override string Id { get { return "minecraft:ice"; } }

        public override ushort MinimumState { get { return 3929; } }
        public override ushort MaximumState { get { return 3929; } }
        public override ushort DefaultState { get { return 3929; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockIce() {
            State = DefaultState;
        }

        public BlockIce(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}