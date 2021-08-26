// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:stripped_oak_log", 46, 106, 108, 107)]
    public class BlockStrippedOakLog : BlockBase {

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 106;
                }

                if(Axis == "y") {
                    return 107;
                }

                if(Axis == "z") {
                    return 108;
                }

                return DefaultState;
            }

            set {
                if(value == 106) {
                    Axis = "x";
                }

                if(value == 107) {
                    Axis = "y";
                }

                if(value == 108) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockStrippedOakLog() {
            State = DefaultState;
        }

        public BlockStrippedOakLog(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockStrippedOakLog(string axis) {
            Axis = axis;
        }
    }
}