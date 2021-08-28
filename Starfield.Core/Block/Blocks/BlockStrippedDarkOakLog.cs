// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:stripped_dark_oak_log", 45, 103, 105, 104)]
    public class BlockStrippedDarkOakLog : BlockBase {

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 103;
                }

                if(Axis == "y") {
                    return 104;
                }

                if(Axis == "z") {
                    return 105;
                }

                return DefaultState;
            }

            set {
                if(value == 103) {
                    Axis = "x";
                }

                if(value == 104) {
                    Axis = "y";
                }

                if(value == 105) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockStrippedDarkOakLog() {
            State = DefaultState;
        }

        public BlockStrippedDarkOakLog(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockStrippedDarkOakLog(string axis) {
            Axis = axis;
        }
    }
}