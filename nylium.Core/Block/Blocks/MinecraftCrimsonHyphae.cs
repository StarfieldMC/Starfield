// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockCrimsonHyphae : BlockBase {

        public override string Id { get { return "minecraft:crimson_hyphae"; } }

        public override ushort MinimumState { get { return 14989; } }
        public override ushort MaximumState { get { return 14991; } }
        public override ushort DefaultState { get { return 14990; } }

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 14989;
                }

                if(Axis == "y") {
                    return 14990;
                }

                if(Axis == "z") {
                    return 14991;
                }

                return DefaultState;
            }

            set {
                if(value == 14989) {
                    Axis = "x";
                }

                if(value == 14990) {
                    Axis = "y";
                }

                if(value == 14991) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockCrimsonHyphae() {
            State = DefaultState;
        }

        public BlockCrimsonHyphae(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockCrimsonHyphae(string axis) {
            Axis = axis;
        }
    }
}