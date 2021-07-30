// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockPurpleWallBanner : BlockBase {

        public override string Id { get { return "minecraft:purple_wall_banner"; } }

        public override ushort MinimumState { get { return 8197; } }
        public override ushort MaximumState { get { return 8200; } }
        public override ushort DefaultState { get { return 8197; } }

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 8197;
                }

                if(Facing == "south") {
                    return 8198;
                }

                if(Facing == "west") {
                    return 8199;
                }

                if(Facing == "east") {
                    return 8200;
                }

                return DefaultState;
            }

            set {
                if(value == 8197) {
                    Facing = "north";
                }

                if(value == 8198) {
                    Facing = "south";
                }

                if(value == 8199) {
                    Facing = "west";
                }

                if(value == 8200) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockPurpleWallBanner() {
            State = DefaultState;
        }

        public BlockPurpleWallBanner(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockPurpleWallBanner(string facing) {
            Facing = facing;
        }
    }
}