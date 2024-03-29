// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:light_gray_glazed_terracotta", 534, 9410, 9413, 9410)]
    public class BlockLightGrayGlazedTerracotta : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 9410;
                }

                if(Facing == "south") {
                    return 9411;
                }

                if(Facing == "west") {
                    return 9412;
                }

                if(Facing == "east") {
                    return 9413;
                }

                return DefaultState;
            }

            set {
                if(value == 9410) {
                    Facing = "north";
                }

                if(value == 9411) {
                    Facing = "south";
                }

                if(value == 9412) {
                    Facing = "west";
                }

                if(value == 9413) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockLightGrayGlazedTerracotta() {
            State = DefaultState;
        }

        public BlockLightGrayGlazedTerracotta(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockLightGrayGlazedTerracotta(string facing) {
            Facing = facing;
        }
    }
}