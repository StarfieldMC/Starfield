// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:dead_horn_coral_wall_fan", 612, 9596, 9603, 9596)]
    public class BlockDeadHornCoralWallFan : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north" && Waterlogged == true) {
                    return 9596;
                }

                if(Facing == "north" && Waterlogged == false) {
                    return 9597;
                }

                if(Facing == "south" && Waterlogged == true) {
                    return 9598;
                }

                if(Facing == "south" && Waterlogged == false) {
                    return 9599;
                }

                if(Facing == "west" && Waterlogged == true) {
                    return 9600;
                }

                if(Facing == "west" && Waterlogged == false) {
                    return 9601;
                }

                if(Facing == "east" && Waterlogged == true) {
                    return 9602;
                }

                if(Facing == "east" && Waterlogged == false) {
                    return 9603;
                }

                return DefaultState;
            }

            set {
                if(value == 9596) {
                    Facing = "north";
Waterlogged = true;
                }

                if(value == 9597) {
                    Facing = "north";
Waterlogged = false;
                }

                if(value == 9598) {
                    Facing = "south";
Waterlogged = true;
                }

                if(value == 9599) {
                    Facing = "south";
Waterlogged = false;
                }

                if(value == 9600) {
                    Facing = "west";
Waterlogged = true;
                }

                if(value == 9601) {
                    Facing = "west";
Waterlogged = false;
                }

                if(value == 9602) {
                    Facing = "east";
Waterlogged = true;
                }

                if(value == 9603) {
                    Facing = "east";
Waterlogged = false;
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool Waterlogged { get; set; } = true;

        public BlockDeadHornCoralWallFan() {
            State = DefaultState;
        }

        public BlockDeadHornCoralWallFan(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockDeadHornCoralWallFan(string facing, bool waterlogged) {
            Facing = facing;
            Waterlogged = waterlogged;
        }
    }
}