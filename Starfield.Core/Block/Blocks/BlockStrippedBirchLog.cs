// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:stripped_birch_log", 42, 94, 96, 95)]
    public class BlockStrippedBirchLog : BlockBase {

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 94;
                }

                if(Axis == "y") {
                    return 95;
                }

                if(Axis == "z") {
                    return 96;
                }

                return DefaultState;
            }

            set {
                if(value == 94) {
                    Axis = "x";
                }

                if(value == 95) {
                    Axis = "y";
                }

                if(value == 96) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockStrippedBirchLog() {
            State = DefaultState;
        }

        public BlockStrippedBirchLog(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockStrippedBirchLog(string axis) {
            Axis = axis;
        }
    }
}