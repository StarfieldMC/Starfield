// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockStrippedBirchWood : BlockBase {

        public override string Id { get { return "minecraft:stripped_birch_wood"; } }

        public override ushort MinimumState { get { return 133; } }
        public override ushort MaximumState { get { return 135; } }
        public override ushort DefaultState { get { return 134; } }

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 133;
                }

                if(Axis == "y") {
                    return 134;
                }

                if(Axis == "z") {
                    return 135;
                }

                return DefaultState;
            }

            set {
                if(value == 133) {
                    Axis = "x";
                }

                if(value == 134) {
                    Axis = "y";
                }

                if(value == 135) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockStrippedBirchWood() {
            State = DefaultState;
        }

        public BlockStrippedBirchWood(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockStrippedBirchWood(string axis) {
            Axis = axis;
        }
    }
}