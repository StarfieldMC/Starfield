// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:stripped_dark_oak_wood", 58, 142, 144, 143)]
    public class BlockStrippedDarkOakWood : BlockBase {

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 142;
                }

                if(Axis == "y") {
                    return 143;
                }

                if(Axis == "z") {
                    return 144;
                }

                return DefaultState;
            }

            set {
                if(value == 142) {
                    Axis = "x";
                }

                if(value == 143) {
                    Axis = "y";
                }

                if(value == 144) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockStrippedDarkOakWood() {
            State = DefaultState;
        }

        public BlockStrippedDarkOakWood(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockStrippedDarkOakWood(string axis) {
            Axis = axis;
        }
    }
}