// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:dead_tube_coral_wall_fan", 608, 9564, 9571, 9564)]
    public class BlockDeadTubeCoralWallFan : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north" && Waterlogged == true) {
                    return 9564;
                }

                if(Facing == "north" && Waterlogged == false) {
                    return 9565;
                }

                if(Facing == "south" && Waterlogged == true) {
                    return 9566;
                }

                if(Facing == "south" && Waterlogged == false) {
                    return 9567;
                }

                if(Facing == "west" && Waterlogged == true) {
                    return 9568;
                }

                if(Facing == "west" && Waterlogged == false) {
                    return 9569;
                }

                if(Facing == "east" && Waterlogged == true) {
                    return 9570;
                }

                if(Facing == "east" && Waterlogged == false) {
                    return 9571;
                }

                return DefaultState;
            }

            set {
                if(value == 9564) {
                    Facing = "north";
Waterlogged = true;
                }

                if(value == 9565) {
                    Facing = "north";
Waterlogged = false;
                }

                if(value == 9566) {
                    Facing = "south";
Waterlogged = true;
                }

                if(value == 9567) {
                    Facing = "south";
Waterlogged = false;
                }

                if(value == 9568) {
                    Facing = "west";
Waterlogged = true;
                }

                if(value == 9569) {
                    Facing = "west";
Waterlogged = false;
                }

                if(value == 9570) {
                    Facing = "east";
Waterlogged = true;
                }

                if(value == 9571) {
                    Facing = "east";
Waterlogged = false;
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool Waterlogged { get; set; } = true;

        public BlockDeadTubeCoralWallFan() {
            State = DefaultState;
        }

        public BlockDeadTubeCoralWallFan(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockDeadTubeCoralWallFan(string facing, bool waterlogged) {
            Facing = facing;
            Waterlogged = waterlogged;
        }
    }
}