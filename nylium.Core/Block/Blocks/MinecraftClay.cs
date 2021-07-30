// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockClay : BlockBase {

        public override string Id { get { return "minecraft:clay"; } }

        public override ushort MinimumState { get { return 3947; } }
        public override ushort MaximumState { get { return 3947; } }
        public override ushort DefaultState { get { return 3947; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockClay() {
            State = DefaultState;
        }

        public BlockClay(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}