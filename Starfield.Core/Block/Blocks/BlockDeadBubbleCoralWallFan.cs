// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:dead_bubble_coral_wall_fan", 610, 9580, 9587, 9580)]
    public class BlockDeadBubbleCoralWallFan : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north" && Waterlogged == true) {
                    return 9580;
                }

                if(Facing == "north" && Waterlogged == false) {
                    return 9581;
                }

                if(Facing == "south" && Waterlogged == true) {
                    return 9582;
                }

                if(Facing == "south" && Waterlogged == false) {
                    return 9583;
                }

                if(Facing == "west" && Waterlogged == true) {
                    return 9584;
                }

                if(Facing == "west" && Waterlogged == false) {
                    return 9585;
                }

                if(Facing == "east" && Waterlogged == true) {
                    return 9586;
                }

                if(Facing == "east" && Waterlogged == false) {
                    return 9587;
                }

                return DefaultState;
            }

            set {
                if(value == 9580) {
                    Facing = "north";
Waterlogged = true;
                }

                if(value == 9581) {
                    Facing = "north";
Waterlogged = false;
                }

                if(value == 9582) {
                    Facing = "south";
Waterlogged = true;
                }

                if(value == 9583) {
                    Facing = "south";
Waterlogged = false;
                }

                if(value == 9584) {
                    Facing = "west";
Waterlogged = true;
                }

                if(value == 9585) {
                    Facing = "west";
Waterlogged = false;
                }

                if(value == 9586) {
                    Facing = "east";
Waterlogged = true;
                }

                if(value == 9587) {
                    Facing = "east";
Waterlogged = false;
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool Waterlogged { get; set; } = true;

        public BlockDeadBubbleCoralWallFan() {
            State = DefaultState;
        }

        public BlockDeadBubbleCoralWallFan(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockDeadBubbleCoralWallFan(string facing, bool waterlogged) {
            Facing = facing;
            Waterlogged = waterlogged;
        }
    }
}