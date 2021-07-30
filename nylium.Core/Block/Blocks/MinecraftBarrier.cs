// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockBarrier : BlockBase {

        public override string Id { get { return "minecraft:barrier"; } }

        public override ushort MinimumState { get { return 7540; } }
        public override ushort MaximumState { get { return 7540; } }
        public override ushort DefaultState { get { return 7540; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockBarrier() {
            State = DefaultState;
        }

        public BlockBarrier(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}