// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:birch_log", 37, 79, 81, 80)]
    public class BlockBirchLog : BlockBase {

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 79;
                }

                if(Axis == "y") {
                    return 80;
                }

                if(Axis == "z") {
                    return 81;
                }

                return DefaultState;
            }

            set {
                if(value == 79) {
                    Axis = "x";
                }

                if(value == 80) {
                    Axis = "y";
                }

                if(value == 81) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockBirchLog() {
            State = DefaultState;
        }

        public BlockBirchLog(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBirchLog(string axis) {
            Axis = axis;
        }
    }
}