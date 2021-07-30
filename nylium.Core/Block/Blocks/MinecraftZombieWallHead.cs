// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockZombieWallHead : BlockBase {

        public override string Id { get { return "minecraft:zombie_wall_head"; } }

        public override ushort MinimumState { get { return 6550; } }
        public override ushort MaximumState { get { return 6553; } }
        public override ushort DefaultState { get { return 6550; } }

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 6550;
                }

                if(Facing == "south") {
                    return 6551;
                }

                if(Facing == "west") {
                    return 6552;
                }

                if(Facing == "east") {
                    return 6553;
                }

                return DefaultState;
            }

            set {
                if(value == 6550) {
                    Facing = "north";
                }

                if(value == 6551) {
                    Facing = "south";
                }

                if(value == 6552) {
                    Facing = "west";
                }

                if(value == 6553) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockZombieWallHead() {
            State = DefaultState;
        }

        public BlockZombieWallHead(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockZombieWallHead(string facing) {
            Facing = facing;
        }
    }
}