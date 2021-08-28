// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:spruce_log", 36, 76, 78, 77)]
    public class BlockSpruceLog : BlockBase {

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 76;
                }

                if(Axis == "y") {
                    return 77;
                }

                if(Axis == "z") {
                    return 78;
                }

                return DefaultState;
            }

            set {
                if(value == 76) {
                    Axis = "x";
                }

                if(value == 77) {
                    Axis = "y";
                }

                if(value == 78) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockSpruceLog() {
            State = DefaultState;
        }

        public BlockSpruceLog(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockSpruceLog(string axis) {
            Axis = axis;
        }
    }
}