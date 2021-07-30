// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockOrangeGlazedTerracotta : BlockBase {

        public override string Id { get { return "minecraft:orange_glazed_terracotta"; } }

        public override ushort MinimumState { get { return 9382; } }
        public override ushort MaximumState { get { return 9385; } }
        public override ushort DefaultState { get { return 9382; } }

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 9382;
                }

                if(Facing == "south") {
                    return 9383;
                }

                if(Facing == "west") {
                    return 9384;
                }

                if(Facing == "east") {
                    return 9385;
                }

                return DefaultState;
            }

            set {
                if(value == 9382) {
                    Facing = "north";
                }

                if(value == 9383) {
                    Facing = "south";
                }

                if(value == 9384) {
                    Facing = "west";
                }

                if(value == 9385) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockOrangeGlazedTerracotta() {
            State = DefaultState;
        }

        public BlockOrangeGlazedTerracotta(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockOrangeGlazedTerracotta(string facing) {
            Facing = facing;
        }
    }
}