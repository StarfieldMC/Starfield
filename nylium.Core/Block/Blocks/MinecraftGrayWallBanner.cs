// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockGrayWallBanner : BlockBase {

        public override string Id { get { return "minecraft:gray_wall_banner"; } }

        public override ushort MinimumState { get { return 8185; } }
        public override ushort MaximumState { get { return 8188; } }
        public override ushort DefaultState { get { return 8185; } }

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 8185;
                }

                if(Facing == "south") {
                    return 8186;
                }

                if(Facing == "west") {
                    return 8187;
                }

                if(Facing == "east") {
                    return 8188;
                }

                return DefaultState;
            }

            set {
                if(value == 8185) {
                    Facing = "north";
                }

                if(value == 8186) {
                    Facing = "south";
                }

                if(value == 8187) {
                    Facing = "west";
                }

                if(value == 8188) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockGrayWallBanner() {
            State = DefaultState;
        }

        public BlockGrayWallBanner(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockGrayWallBanner(string facing) {
            Facing = facing;
        }
    }
}