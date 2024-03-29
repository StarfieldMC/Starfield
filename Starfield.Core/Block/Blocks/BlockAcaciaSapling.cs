// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:acacia_sapling", 23, 29, 30, 29)]
    public class BlockAcaciaSapling : BlockBase {

        public override ushort State {
            get {
                if(Stage == 0) {
                    return 29;
                }

                if(Stage == 1) {
                    return 30;
                }

                return DefaultState;
            }

            set {
                if(value == 29) {
                    Stage = 0;
                }

                if(value == 30) {
                    Stage = 1;
                }

            }
        }

        public int Stage { get; set; } = 0;

        public BlockAcaciaSapling() {
            State = DefaultState;
        }

        public BlockAcaciaSapling(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockAcaciaSapling(int stage) {
            Stage = stage;
        }
    }
}