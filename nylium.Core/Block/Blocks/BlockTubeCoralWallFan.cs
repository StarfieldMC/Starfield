// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:tube_coral_wall_fan", 613, 9604, 9611, 9604)]
    public class BlockTubeCoralWallFan : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north" && Waterlogged == true) {
                    return 9604;
                }

                if(Facing == "north" && Waterlogged == false) {
                    return 9605;
                }

                if(Facing == "south" && Waterlogged == true) {
                    return 9606;
                }

                if(Facing == "south" && Waterlogged == false) {
                    return 9607;
                }

                if(Facing == "west" && Waterlogged == true) {
                    return 9608;
                }

                if(Facing == "west" && Waterlogged == false) {
                    return 9609;
                }

                if(Facing == "east" && Waterlogged == true) {
                    return 9610;
                }

                if(Facing == "east" && Waterlogged == false) {
                    return 9611;
                }

                return DefaultState;
            }

            set {
                if(value == 9604) {
                    Facing = "north";
Waterlogged = true;
                }

                if(value == 9605) {
                    Facing = "north";
Waterlogged = false;
                }

                if(value == 9606) {
                    Facing = "south";
Waterlogged = true;
                }

                if(value == 9607) {
                    Facing = "south";
Waterlogged = false;
                }

                if(value == 9608) {
                    Facing = "west";
Waterlogged = true;
                }

                if(value == 9609) {
                    Facing = "west";
Waterlogged = false;
                }

                if(value == 9610) {
                    Facing = "east";
Waterlogged = true;
                }

                if(value == 9611) {
                    Facing = "east";
Waterlogged = false;
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool Waterlogged { get; set; } = true;

        public BlockTubeCoralWallFan() {
            State = DefaultState;
        }

        public BlockTubeCoralWallFan(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockTubeCoralWallFan(string facing, bool waterlogged) {
            Facing = facing;
            Waterlogged = waterlogged;
        }
    }
}