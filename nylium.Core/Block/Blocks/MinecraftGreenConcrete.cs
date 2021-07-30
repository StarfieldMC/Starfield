// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockGreenConcrete : BlockBase {

        public override string Id { get { return "minecraft:green_concrete"; } }

        public override ushort MinimumState { get { return 9455; } }
        public override ushort MaximumState { get { return 9455; } }
        public override ushort DefaultState { get { return 9455; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockGreenConcrete() {
            State = DefaultState;
        }

        public BlockGreenConcrete(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}