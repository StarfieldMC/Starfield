// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:lilac", 411, 7891, 7892, 7892)]
    public class BlockLilac : BlockBase {

        public override ushort State {
            get {
                if(Half == "upper") {
                    return 7891;
                }

                if(Half == "lower") {
                    return 7892;
                }

                return DefaultState;
            }

            set {
                if(value == 7891) {
                    Half = "upper";
                }

                if(value == 7892) {
                    Half = "lower";
                }

            }
        }

        public string Half { get; set; } = "lower";

        public BlockLilac() {
            State = DefaultState;
        }

        public BlockLilac(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockLilac(string half) {
            Half = half;
        }
    }
}