// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:jungle_log", 38, 82, 84, 83)]
    public class BlockJungleLog : BlockBase {

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 82;
                }

                if(Axis == "y") {
                    return 83;
                }

                if(Axis == "z") {
                    return 84;
                }

                return DefaultState;
            }

            set {
                if(value == 82) {
                    Axis = "x";
                }

                if(value == 83) {
                    Axis = "y";
                }

                if(value == 84) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockJungleLog() {
            State = DefaultState;
        }

        public BlockJungleLog(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockJungleLog(string axis) {
            Axis = axis;
        }
    }
}