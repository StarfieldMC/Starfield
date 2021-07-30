// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockAzureBluet : BlockBase {

        public override string Id { get { return "minecraft:azure_bluet"; } }

        public override ushort MinimumState { get { return 1416; } }
        public override ushort MaximumState { get { return 1416; } }
        public override ushort DefaultState { get { return 1416; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockAzureBluet() {
            State = DefaultState;
        }

        public BlockAzureBluet(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}