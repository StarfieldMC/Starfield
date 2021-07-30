// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockBlackTerracotta : BlockBase {

        public override string Id { get { return "minecraft:black_terracotta"; } }

        public override ushort MinimumState { get { return 6866; } }
        public override ushort MaximumState { get { return 6866; } }
        public override ushort DefaultState { get { return 6866; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockBlackTerracotta() {
            State = DefaultState;
        }

        public BlockBlackTerracotta(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}