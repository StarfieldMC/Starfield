// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockCoarseDirt : BlockBase {

        public override string Id { get { return "minecraft:coarse_dirt"; } }

        public override ushort MinimumState { get { return 11; } }
        public override ushort MaximumState { get { return 11; } }
        public override ushort DefaultState { get { return 11; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockCoarseDirt() {
            State = DefaultState;
        }

        public BlockCoarseDirt(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}