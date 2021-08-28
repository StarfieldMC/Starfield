// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:oak_log", 35, 73, 75, 74)]
    public class BlockOakLog : BlockBase {

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 73;
                }

                if(Axis == "y") {
                    return 74;
                }

                if(Axis == "z") {
                    return 75;
                }

                return DefaultState;
            }

            set {
                if(value == 73) {
                    Axis = "x";
                }

                if(value == 74) {
                    Axis = "y";
                }

                if(value == 75) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockOakLog() {
            State = DefaultState;
        }

        public BlockOakLog(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockOakLog(string axis) {
            Axis = axis;
        }
    }
}