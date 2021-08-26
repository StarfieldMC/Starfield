// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:green_wall_banner", 445, 8209, 8212, 8209)]
    public class BlockGreenWallBanner : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 8209;
                }

                if(Facing == "south") {
                    return 8210;
                }

                if(Facing == "west") {
                    return 8211;
                }

                if(Facing == "east") {
                    return 8212;
                }

                return DefaultState;
            }

            set {
                if(value == 8209) {
                    Facing = "north";
                }

                if(value == 8210) {
                    Facing = "south";
                }

                if(value == 8211) {
                    Facing = "west";
                }

                if(value == 8212) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockGreenWallBanner() {
            State = DefaultState;
        }

        public BlockGreenWallBanner(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockGreenWallBanner(string facing) {
            Facing = facing;
        }
    }
}