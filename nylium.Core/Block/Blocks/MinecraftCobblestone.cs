// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockCobblestone : BlockBase {

        public override string Id { get { return "minecraft:cobblestone"; } }

        public override ushort MinimumState { get { return 14; } }
        public override ushort MaximumState { get { return 14; } }
        public override ushort DefaultState { get { return 14; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockCobblestone() {
            State = DefaultState;
        }

        public BlockCobblestone(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}