// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockPackedIce : BlockBase {

        public override string Id { get { return "minecraft:packed_ice"; } }

        public override ushort MinimumState { get { return 7888; } }
        public override ushort MaximumState { get { return 7888; } }
        public override ushort DefaultState { get { return 7888; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockPackedIce() {
            State = DefaultState;
        }

        public BlockPackedIce(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}