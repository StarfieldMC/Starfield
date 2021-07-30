// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockPottedAcaciaSapling : BlockBase {

        public override string Id { get { return "minecraft:potted_acacia_sapling"; } }

        public override ushort MinimumState { get { return 6314; } }
        public override ushort MaximumState { get { return 6314; } }
        public override ushort DefaultState { get { return 6314; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockPottedAcaciaSapling() {
            State = DefaultState;
        }

        public BlockPottedAcaciaSapling(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}