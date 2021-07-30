// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockYellowWallBanner : BlockBase {

        public override string Id { get { return "minecraft:yellow_wall_banner"; } }

        public override ushort MinimumState { get { return 8173; } }
        public override ushort MaximumState { get { return 8176; } }
        public override ushort DefaultState { get { return 8173; } }

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 8173;
                }

                if(Facing == "south") {
                    return 8174;
                }

                if(Facing == "west") {
                    return 8175;
                }

                if(Facing == "east") {
                    return 8176;
                }

                return DefaultState;
            }

            set {
                if(value == 8173) {
                    Facing = "north";
                }

                if(value == 8174) {
                    Facing = "south";
                }

                if(value == 8175) {
                    Facing = "west";
                }

                if(value == 8176) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockYellowWallBanner() {
            State = DefaultState;
        }

        public BlockYellowWallBanner(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockYellowWallBanner(string facing) {
            Facing = facing;
        }
    }
}