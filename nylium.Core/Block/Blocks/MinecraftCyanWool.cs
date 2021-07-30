// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockCyanWool : BlockBase {

        public override string Id { get { return "minecraft:cyan_wool"; } }

        public override ushort MinimumState { get { return 1393; } }
        public override ushort MaximumState { get { return 1393; } }
        public override ushort DefaultState { get { return 1393; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockCyanWool() {
            State = DefaultState;
        }

        public BlockCyanWool(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}