// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockBubbleCoralWallFan : BlockBase {

        public override string Id { get { return "minecraft:bubble_coral_wall_fan"; } }

        public override ushort MinimumState { get { return 9620; } }
        public override ushort MaximumState { get { return 9627; } }
        public override ushort DefaultState { get { return 9620; } }

        public override ushort State {
            get {
                if(Facing == "north" && Waterlogged == true) {
                    return 9620;
                }

                if(Facing == "north" && Waterlogged == false) {
                    return 9621;
                }

                if(Facing == "south" && Waterlogged == true) {
                    return 9622;
                }

                if(Facing == "south" && Waterlogged == false) {
                    return 9623;
                }

                if(Facing == "west" && Waterlogged == true) {
                    return 9624;
                }

                if(Facing == "west" && Waterlogged == false) {
                    return 9625;
                }

                if(Facing == "east" && Waterlogged == true) {
                    return 9626;
                }

                if(Facing == "east" && Waterlogged == false) {
                    return 9627;
                }

                return DefaultState;
            }

            set {
                if(value == 9620) {
                    Facing = "north";
Waterlogged = true;
                }

                if(value == 9621) {
                    Facing = "north";
Waterlogged = false;
                }

                if(value == 9622) {
                    Facing = "south";
Waterlogged = true;
                }

                if(value == 9623) {
                    Facing = "south";
Waterlogged = false;
                }

                if(value == 9624) {
                    Facing = "west";
Waterlogged = true;
                }

                if(value == 9625) {
                    Facing = "west";
Waterlogged = false;
                }

                if(value == 9626) {
                    Facing = "east";
Waterlogged = true;
                }

                if(value == 9627) {
                    Facing = "east";
Waterlogged = false;
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool Waterlogged { get; set; } = true;

        public BlockBubbleCoralWallFan() {
            State = DefaultState;
        }

        public BlockBubbleCoralWallFan(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBubbleCoralWallFan(string facing, bool waterlogged) {
            Facing = facing;
            Waterlogged = waterlogged;
        }
    }
}