// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:purpur_pillar", 494, 9139, 9141, 9140)]
    public class BlockPurpurPillar : BlockBase {

        public override ushort State {
            get {
                if(Axis == "x") {
                    return 9139;
                }

                if(Axis == "y") {
                    return 9140;
                }

                if(Axis == "z") {
                    return 9141;
                }

                return DefaultState;
            }

            set {
                if(value == 9139) {
                    Axis = "x";
                }

                if(value == 9140) {
                    Axis = "y";
                }

                if(value == 9141) {
                    Axis = "z";
                }

            }
        }

        public string Axis { get; set; } = "y";

        public BlockPurpurPillar() {
            State = DefaultState;
        }

        public BlockPurpurPillar(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockPurpurPillar(string axis) {
            Axis = axis;
        }
    }
}