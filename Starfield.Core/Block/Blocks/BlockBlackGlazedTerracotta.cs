// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:black_glazed_terracotta", 541, 9438, 9441, 9438)]
    public class BlockBlackGlazedTerracotta : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 9438;
                }

                if(Facing == "south") {
                    return 9439;
                }

                if(Facing == "west") {
                    return 9440;
                }

                if(Facing == "east") {
                    return 9441;
                }

                return DefaultState;
            }

            set {
                if(value == 9438) {
                    Facing = "north";
                }

                if(value == 9439) {
                    Facing = "south";
                }

                if(value == 9440) {
                    Facing = "west";
                }

                if(value == 9441) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockBlackGlazedTerracotta() {
            State = DefaultState;
        }

        public BlockBlackGlazedTerracotta(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBlackGlazedTerracotta(string facing) {
            Facing = facing;
        }
    }
}