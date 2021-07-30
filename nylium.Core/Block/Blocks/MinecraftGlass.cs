// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockGlass : BlockBase {

        public override string Id { get { return "minecraft:glass"; } }

        public override ushort MinimumState { get { return 231; } }
        public override ushort MaximumState { get { return 231; } }
        public override ushort DefaultState { get { return 231; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockGlass() {
            State = DefaultState;
        }

        public BlockGlass(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}