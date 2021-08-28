// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:large_fern", 415, 7899, 7900, 7900)]
    public class BlockLargeFern : BlockBase {

        public override ushort State {
            get {
                if(Half == "upper") {
                    return 7899;
                }

                if(Half == "lower") {
                    return 7900;
                }

                return DefaultState;
            }

            set {
                if(value == 7899) {
                    Half = "upper";
                }

                if(value == 7900) {
                    Half = "lower";
                }

            }
        }

        public string Half { get; set; } = "lower";

        public BlockLargeFern() {
            State = DefaultState;
        }

        public BlockLargeFern(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockLargeFern(string half) {
            Half = half;
        }
    }
}