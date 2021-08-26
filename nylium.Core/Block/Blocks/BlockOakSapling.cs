// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:oak_sapling", 19, 21, 22, 21)]
    public class BlockOakSapling : BlockBase {

        public override ushort State {
            get {
                if(Stage == 0) {
                    return 21;
                }

                if(Stage == 1) {
                    return 22;
                }

                return DefaultState;
            }

            set {
                if(value == 21) {
                    Stage = 0;
                }

                if(value == 22) {
                    Stage = 1;
                }

            }
        }

        public int Stage { get; set; } = 0;

        public BlockOakSapling() {
            State = DefaultState;
        }

        public BlockOakSapling(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockOakSapling(int stage) {
            Stage = stage;
        }
    }
}