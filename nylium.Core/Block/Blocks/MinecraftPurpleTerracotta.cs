// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockPurpleTerracotta : BlockBase {

        public override string Id { get { return "minecraft:purple_terracotta"; } }

        public override ushort MinimumState { get { return 6861; } }
        public override ushort MaximumState { get { return 6861; } }
        public override ushort DefaultState { get { return 6861; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockPurpleTerracotta() {
            State = DefaultState;
        }

        public BlockPurpleTerracotta(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}