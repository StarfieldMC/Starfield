// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:skeleton_wall_skull", 315, 6510, 6513, 6510)]
    public class BlockSkeletonWallSkull : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 6510;
                }

                if(Facing == "south") {
                    return 6511;
                }

                if(Facing == "west") {
                    return 6512;
                }

                if(Facing == "east") {
                    return 6513;
                }

                return DefaultState;
            }

            set {
                if(value == 6510) {
                    Facing = "north";
                }

                if(value == 6511) {
                    Facing = "south";
                }

                if(value == 6512) {
                    Facing = "west";
                }

                if(value == 6513) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockSkeletonWallSkull() {
            State = DefaultState;
        }

        public BlockSkeletonWallSkull(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockSkeletonWallSkull(string facing) {
            Facing = facing;
        }
    }
}