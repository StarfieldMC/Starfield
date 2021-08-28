// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:dead_fire_coral_wall_fan", 611, 9588, 9595, 9588)]
    public class BlockDeadFireCoralWallFan : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north" && Waterlogged == true) {
                    return 9588;
                }

                if(Facing == "north" && Waterlogged == false) {
                    return 9589;
                }

                if(Facing == "south" && Waterlogged == true) {
                    return 9590;
                }

                if(Facing == "south" && Waterlogged == false) {
                    return 9591;
                }

                if(Facing == "west" && Waterlogged == true) {
                    return 9592;
                }

                if(Facing == "west" && Waterlogged == false) {
                    return 9593;
                }

                if(Facing == "east" && Waterlogged == true) {
                    return 9594;
                }

                if(Facing == "east" && Waterlogged == false) {
                    return 9595;
                }

                return DefaultState;
            }

            set {
                if(value == 9588) {
                    Facing = "north";
Waterlogged = true;
                }

                if(value == 9589) {
                    Facing = "north";
Waterlogged = false;
                }

                if(value == 9590) {
                    Facing = "south";
Waterlogged = true;
                }

                if(value == 9591) {
                    Facing = "south";
Waterlogged = false;
                }

                if(value == 9592) {
                    Facing = "west";
Waterlogged = true;
                }

                if(value == 9593) {
                    Facing = "west";
Waterlogged = false;
                }

                if(value == 9594) {
                    Facing = "east";
Waterlogged = true;
                }

                if(value == 9595) {
                    Facing = "east";
Waterlogged = false;
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool Waterlogged { get; set; } = true;

        public BlockDeadFireCoralWallFan() {
            State = DefaultState;
        }

        public BlockDeadFireCoralWallFan(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockDeadFireCoralWallFan(string facing, bool waterlogged) {
            Facing = facing;
            Waterlogged = waterlogged;
        }
    }
}