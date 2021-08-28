// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:birch_wood", 49, 115, 117, 116)]
    public class BlockBirchWood : BlockBase {

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 115;
                }

                if(Axis == "y") {
                    return 116;
                }

                if(Axis == "z") {
                    return 117;
                }

                return DefaultState;
            }

            set {
                if(value == 115) {
                    Axis = "x";
                }

                if(value == 116) {
                    Axis = "y";
                }

                if(value == 117) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockBirchWood() {
            State = DefaultState;
        }

        public BlockBirchWood(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBirchWood(string axis) {
            Axis = axis;
        }
    }
}