// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockCyanConcretePowder : BlockBase {

        public override string Id { get { return "minecraft:cyan_concrete_powder"; } }

        public override ushort MinimumState { get { return 9467; } }
        public override ushort MaximumState { get { return 9467; } }
        public override ushort DefaultState { get { return 9467; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockCyanConcretePowder() {
            State = DefaultState;
        }

        public BlockCyanConcretePowder(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}