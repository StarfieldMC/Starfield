// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockDarkOakLog : BlockBase {

        public override string Id { get { return "minecraft:dark_oak_log"; } }

        public override ushort MinimumState { get { return 88; } }
        public override ushort MaximumState { get { return 90; } }
        public override ushort DefaultState { get { return 89; } }

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 88;
                }

                if(Axis == "y") {
                    return 89;
                }

                if(Axis == "z") {
                    return 90;
                }

                return DefaultState;
            }

            set {
                if(value == 88) {
                    Axis = "x";
                }

                if(value == 89) {
                    Axis = "y";
                }

                if(value == 90) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockDarkOakLog() {
            State = DefaultState;
        }

        public BlockDarkOakLog(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockDarkOakLog(string axis) {
            Axis = axis;
        }
    }
}