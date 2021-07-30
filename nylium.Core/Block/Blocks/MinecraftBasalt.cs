// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockBasalt : BlockBase {

        public override string Id { get { return "minecraft:basalt"; } }

        public override ushort MinimumState { get { return 4002; } }
        public override ushort MaximumState { get { return 4004; } }
        public override ushort DefaultState { get { return 4003; } }

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 4002;
                }

                if(Axis == "y") {
                    return 4003;
                }

                if(Axis == "z") {
                    return 4004;
                }

                return DefaultState;
            }

            set {
                if(value == 4002) {
                    Axis = "x";
                }

                if(value == 4003) {
                    Axis = "y";
                }

                if(value == 4004) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockBasalt() {
            State = DefaultState;
        }

        public BlockBasalt(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBasalt(string axis) {
            Axis = axis;
        }
    }
}