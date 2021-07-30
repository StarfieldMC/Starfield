// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockJungleWood : BlockBase {

        public override string Id { get { return "minecraft:jungle_wood"; } }

        public override ushort MinimumState { get { return 118; } }
        public override ushort MaximumState { get { return 120; } }
        public override ushort DefaultState { get { return 119; } }

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

        public BlockJungleWood(ushort state) {
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