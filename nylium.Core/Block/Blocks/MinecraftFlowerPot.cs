// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockFlowerPot : BlockBase {

        public override string Id { get { return "minecraft:flower_pot"; } }

        public override ushort MinimumState { get { return 6309; } }
        public override ushort MaximumState { get { return 6309; } }
        public override ushort DefaultState { get { return 6309; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockFlowerPot() {
            State = DefaultState;
        }

        public BlockFlowerPot(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}