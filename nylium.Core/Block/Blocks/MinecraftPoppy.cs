// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockPoppy : BlockBase {

        public override string Id { get { return "minecraft:poppy"; } }

        public override ushort MinimumState { get { return 1413; } }
        public override ushort MaximumState { get { return 1413; } }
        public override ushort DefaultState { get { return 1413; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockPoppy() {
            State = DefaultState;
        }

        public BlockPoppy(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}