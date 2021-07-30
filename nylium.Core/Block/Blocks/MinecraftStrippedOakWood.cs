// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockStrippedOakWood : BlockBase {

        public override string Id { get { return "minecraft:stripped_oak_wood"; } }

        public override ushort MinimumState { get { return 127; } }
        public override ushort MaximumState { get { return 129; } }
        public override ushort DefaultState { get { return 128; } }

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 127;
                }

                if(Axis == "y") {
                    return 128;
                }

                if(Axis == "z") {
                    return 129;
                }

                return DefaultState;
            }

            set {
                if(value == 127) {
                    Axis = "x";
                }

                if(value == 128) {
                    Axis = "y";
                }

                if(value == 129) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockStrippedOakWood() {
            State = DefaultState;
        }

        public BlockStrippedOakWood(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockStrippedOakWood(string axis) {
            Axis = axis;
        }
    }
}