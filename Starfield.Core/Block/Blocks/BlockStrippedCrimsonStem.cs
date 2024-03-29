// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:stripped_crimson_stem", 693, 14986, 14988, 14987)]
    public class BlockStrippedCrimsonStem : BlockBase {

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 14986;
                }

                if(Axis == "y") {
                    return 14987;
                }

                if(Axis == "z") {
                    return 14988;
                }

                return DefaultState;
            }

            set {
                if(value == 14986) {
                    Axis = "x";
                }

                if(value == 14987) {
                    Axis = "y";
                }

                if(value == 14988) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockStrippedCrimsonStem() {
            State = DefaultState;
        }

        public BlockStrippedCrimsonStem(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockStrippedCrimsonStem(string axis) {
            Axis = axis;
        }
    }
}