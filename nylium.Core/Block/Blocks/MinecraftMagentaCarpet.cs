// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockMagentaCarpet : BlockBase {

        public override string Id { get { return "minecraft:magenta_carpet"; } }

        public override ushort MinimumState { get { return 7872; } }
        public override ushort MaximumState { get { return 7872; } }
        public override ushort DefaultState { get { return 7872; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockMagentaCarpet() {
            State = DefaultState;
        }

        public BlockMagentaCarpet(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}