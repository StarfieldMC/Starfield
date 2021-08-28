// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:brown_glazed_terracotta", 538, 9426, 9429, 9426)]
    public class BlockBrownGlazedTerracotta : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 9426;
                }

                if(Facing == "south") {
                    return 9427;
                }

                if(Facing == "west") {
                    return 9428;
                }

                if(Facing == "east") {
                    return 9429;
                }

                return DefaultState;
            }

            set {
                if(value == 9426) {
                    Facing = "north";
                }

                if(value == 9427) {
                    Facing = "south";
                }

                if(value == 9428) {
                    Facing = "west";
                }

                if(value == 9429) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockBrownGlazedTerracotta() {
            State = DefaultState;
        }

        public BlockBrownGlazedTerracotta(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBrownGlazedTerracotta(string facing) {
            Facing = facing;
        }
    }
}