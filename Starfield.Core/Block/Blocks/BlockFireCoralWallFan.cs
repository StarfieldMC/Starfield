// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:fire_coral_wall_fan", 616, 9628, 9635, 9628)]
    public class BlockFireCoralWallFan : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north" && Waterlogged == true) {
                    return 9628;
                }

                if(Facing == "north" && Waterlogged == false) {
                    return 9629;
                }

                if(Facing == "south" && Waterlogged == true) {
                    return 9630;
                }

                if(Facing == "south" && Waterlogged == false) {
                    return 9631;
                }

                if(Facing == "west" && Waterlogged == true) {
                    return 9632;
                }

                if(Facing == "west" && Waterlogged == false) {
                    return 9633;
                }

                if(Facing == "east" && Waterlogged == true) {
                    return 9634;
                }

                if(Facing == "east" && Waterlogged == false) {
                    return 9635;
                }

                return DefaultState;
            }

            set {
                if(value == 9628) {
                    Facing = "north";
Waterlogged = true;
                }

                if(value == 9629) {
                    Facing = "north";
Waterlogged = false;
                }

                if(value == 9630) {
                    Facing = "south";
Waterlogged = true;
                }

                if(value == 9631) {
                    Facing = "south";
Waterlogged = false;
                }

                if(value == 9632) {
                    Facing = "west";
Waterlogged = true;
                }

                if(value == 9633) {
                    Facing = "west";
Waterlogged = false;
                }

                if(value == 9634) {
                    Facing = "east";
Waterlogged = true;
                }

                if(value == 9635) {
                    Facing = "east";
Waterlogged = false;
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool Waterlogged { get; set; } = true;

        public BlockFireCoralWallFan() {
            State = DefaultState;
        }

        public BlockFireCoralWallFan(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockFireCoralWallFan(string facing, bool waterlogged) {
            Facing = facing;
            Waterlogged = waterlogged;
        }
    }
}