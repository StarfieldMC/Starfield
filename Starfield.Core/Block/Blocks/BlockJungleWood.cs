// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:jungle_wood", 50, 118, 120, 119)]
    public class BlockJungleWood : BlockBase {

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 118;
                }

                if(Axis == "y") {
                    return 119;
                }

                if(Axis == "z") {
                    return 120;
                }

                return DefaultState;
            }

            set {
                if(value == 118) {
                    Axis = "x";
                }

                if(value == 119) {
                    Axis = "y";
                }

                if(value == 120) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockJungleWood() {
            State = DefaultState;
        }

        public BlockJungleWood(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockJungleWood(string axis) {
            Axis = axis;
        }
    }
}