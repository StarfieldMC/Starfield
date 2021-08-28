// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:peony", 413, 7895, 7896, 7896)]
    public class BlockPeony : BlockBase {

        public override ushort State {
            get {
                if(Half == "upper") {
                    return 7895;
                }

                if(Half == "lower") {
                    return 7896;
                }

                return DefaultState;
            }

            set {
                if(value == 7895) {
                    Half = "upper";
                }

                if(value == 7896) {
                    Half = "lower";
                }

            }
        }

        public string Half { get; set; } = "lower";

        public BlockPeony() {
            State = DefaultState;
        }

        public BlockPeony(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockPeony(string half) {
            Half = half;
        }
    }
}