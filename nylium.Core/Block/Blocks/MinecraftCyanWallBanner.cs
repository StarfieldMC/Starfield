// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockCyanWallBanner : BlockBase {

        public override string Id { get { return "minecraft:cyan_wall_banner"; } }

        public override ushort MinimumState { get { return 8193; } }
        public override ushort MaximumState { get { return 8196; } }
        public override ushort DefaultState { get { return 8193; } }

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 8193;
                }

                if(Facing == "south") {
                    return 8194;
                }

                if(Facing == "west") {
                    return 8195;
                }

                if(Facing == "east") {
                    return 8196;
                }

                return DefaultState;
            }

            set {
                if(value == 8193) {
                    Facing = "north";
                }

                if(value == 8194) {
                    Facing = "south";
                }

                if(value == 8195) {
                    Facing = "west";
                }

                if(value == 8196) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockCyanWallBanner() {
            State = DefaultState;
        }

        public BlockCyanWallBanner(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockCyanWallBanner(string facing) {
            Facing = facing;
        }
    }
}