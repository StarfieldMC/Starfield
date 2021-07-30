// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockBirchWood : BlockBase {

        public override string Id { get { return "minecraft:birch_wood"; } }

        public override ushort MinimumState { get { return 115; } }
        public override ushort MaximumState { get { return 117; } }
        public override ushort DefaultState { get { return 116; } }

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

        public BlockBirchWood(ushort state) {
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