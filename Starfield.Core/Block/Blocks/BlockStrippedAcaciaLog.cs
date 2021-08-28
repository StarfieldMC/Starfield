// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:stripped_acacia_log", 44, 100, 102, 101)]
    public class BlockStrippedAcaciaLog : BlockBase {

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 100;
                }

                if(Axis == "y") {
                    return 101;
                }

                if(Axis == "z") {
                    return 102;
                }

                return DefaultState;
            }

            set {
                if(value == 100) {
                    Axis = "x";
                }

                if(value == 101) {
                    Axis = "y";
                }

                if(value == 102) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockStrippedAcaciaLog() {
            State = DefaultState;
        }

        public BlockStrippedAcaciaLog(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockStrippedAcaciaLog(string axis) {
            Axis = axis;
        }
    }
}