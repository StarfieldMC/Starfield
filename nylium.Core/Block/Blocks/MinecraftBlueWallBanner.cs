// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockBlueWallBanner : BlockBase {

        public override string Id { get { return "minecraft:blue_wall_banner"; } }

        public override ushort MinimumState { get { return 8201; } }
        public override ushort MaximumState { get { return 8204; } }
        public override ushort DefaultState { get { return 8201; } }

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 8201;
                }

                if(Facing == "south") {
                    return 8202;
                }

                if(Facing == "west") {
                    return 8203;
                }

                if(Facing == "east") {
                    return 8204;
                }

                return DefaultState;
            }

            set {
                if(value == 8201) {
                    Facing = "north";
                }

                if(value == 8202) {
                    Facing = "south";
                }

                if(value == 8203) {
                    Facing = "west";
                }

                if(value == 8204) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockBlueWallBanner() {
            State = DefaultState;
        }

        public BlockBlueWallBanner(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBlueWallBanner(string facing) {
            Facing = facing;
        }
    }
}