// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockCreeperWallHead : BlockBase {

        public override string Id { get { return "minecraft:creeper_wall_head"; } }

        public override ushort MinimumState { get { return 6590; } }
        public override ushort MaximumState { get { return 6593; } }
        public override ushort DefaultState { get { return 6590; } }

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 6590;
                }

                if(Facing == "south") {
                    return 6591;
                }

                if(Facing == "west") {
                    return 6592;
                }

                if(Facing == "east") {
                    return 6593;
                }

                return DefaultState;
            }

            set {
                if(value == 6590) {
                    Facing = "north";
                }

                if(value == 6591) {
                    Facing = "south";
                }

                if(value == 6592) {
                    Facing = "west";
                }

                if(value == 6593) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockCreeperWallHead() {
            State = DefaultState;
        }

        public BlockCreeperWallHead(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockCreeperWallHead(string facing) {
            Facing = facing;
        }
    }
}