// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockNetherSprouts : BlockBase {

        public override string Id { get { return "minecraft:nether_sprouts"; } }

        public override ushort MinimumState { get { return 14982; } }
        public override ushort MaximumState { get { return 14982; } }
        public override ushort DefaultState { get { return 14982; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockNetherSprouts() {
            State = DefaultState;
        }

        public BlockNetherSprouts(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}