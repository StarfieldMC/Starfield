// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:wither_skeleton_wall_skull", 317, 6530, 6533, 6530)]
    public class BlockWitherSkeletonWallSkull : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 6530;
                }

                if(Facing == "south") {
                    return 6531;
                }

                if(Facing == "west") {
                    return 6532;
                }

                if(Facing == "east") {
                    return 6533;
                }

                return DefaultState;
            }

            set {
                if(value == 6530) {
                    Facing = "north";
                }

                if(value == 6531) {
                    Facing = "south";
                }

                if(value == 6532) {
                    Facing = "west";
                }

                if(value == 6533) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockWitherSkeletonWallSkull() {
            State = DefaultState;
        }

        public BlockWitherSkeletonWallSkull(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockWitherSkeletonWallSkull(string facing) {
            Facing = facing;
        }
    }
}