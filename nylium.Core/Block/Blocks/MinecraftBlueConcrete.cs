// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockBlueConcrete : BlockBase {

        public override string Id { get { return "minecraft:blue_concrete"; } }

        public override ushort MinimumState { get { return 9453; } }
        public override ushort MaximumState { get { return 9453; } }
        public override ushort DefaultState { get { return 9453; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockBlueConcrete() {
            State = DefaultState;
        }

        public BlockBlueConcrete(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}