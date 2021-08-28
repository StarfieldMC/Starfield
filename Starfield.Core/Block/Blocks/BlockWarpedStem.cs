// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:warped_stem", 683, 14966, 14968, 14967)]
    public class BlockWarpedStem : BlockBase {

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 14966;
                }

                if(Axis == "y") {
                    return 14967;
                }

                if(Axis == "z") {
                    return 14968;
                }

                return DefaultState;
            }

            set {
                if(value == 14966) {
                    Axis = "x";
                }

                if(value == 14967) {
                    Axis = "y";
                }

                if(value == 14968) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockWarpedStem() {
            State = DefaultState;
        }

        public BlockWarpedStem(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockWarpedStem(string axis) {
            Axis = axis;
        }
    }
}