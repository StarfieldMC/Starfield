// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:trapped_chest", 329, 6626, 6649, 6627)]
    public class BlockTrappedChest : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north" && Type == "single" && Waterlogged == true) {
                    return 6626;
                }

                if(Facing == "north" && Type == "single" && Waterlogged == false) {
                    return 6627;
                }

                if(Facing == "north" && Type == "left" && Waterlogged == true) {
                    return 6628;
                }

                if(Facing == "north" && Type == "left" && Waterlogged == false) {
                    return 6629;
                }

                if(Facing == "north" && Type == "right" && Waterlogged == true) {
                    return 6630;
                }

                if(Facing == "north" && Type == "right" && Waterlogged == false) {
                    return 6631;
                }

                if(Facing == "south" && Type == "single" && Waterlogged == true) {
                    return 6632;
                }

                if(Facing == "south" && Type == "single" && Waterlogged == false) {
                    return 6633;
                }

                if(Facing == "south" && Type == "left" && Waterlogged == true) {
                    return 6634;
                }

                if(Facing == "south" && Type == "left" && Waterlogged == false) {
                    return 6635;
                }

                if(Facing == "south" && Type == "right" && Waterlogged == true) {
                    return 6636;
                }

                if(Facing == "south" && Type == "right" && Waterlogged == false) {
                    return 6637;
                }

                if(Facing == "west" && Type == "single" && Waterlogged == true) {
                    return 6638;
                }

                if(Facing == "west" && Type == "single" && Waterlogged == false) {
                    return 6639;
                }

                if(Facing == "west" && Type == "left" && Waterlogged == true) {
                    return 6640;
                }

                if(Facing == "west" && Type == "left" && Waterlogged == false) {
                    return 6641;
                }

                if(Facing == "west" && Type == "right" && Waterlogged == true) {
                    return 6642;
                }

                if(Facing == "west" && Type == "right" && Waterlogged == false) {
                    return 6643;
                }

                if(Facing == "east" && Type == "single" && Waterlogged == true) {
                    return 6644;
                }

                if(Facing == "east" && Type == "single" && Waterlogged == false) {
                    return 6645;
                }

                if(Facing == "east" && Type == "left" && Waterlogged == true) {
                    return 6646;
                }

                if(Facing == "east" && Type == "left" && Waterlogged == false) {
                    return 6647;
                }

                if(Facing == "east" && Type == "right" && Waterlogged == true) {
                    return 6648;
                }

                if(Facing == "east" && Type == "right" && Waterlogged == false) {
                    return 6649;
                }

                return DefaultState;
            }

            set {
                if(value == 6626) {
                    Facing = "north";
Type = "single";
Waterlogged = true;
                }

                if(value == 6627) {
                    Facing = "north";
Type = "single";
Waterlogged = false;
                }

                if(value == 6628) {
                    Facing = "north";
Type = "left";
Waterlogged = true;
                }

                if(value == 6629) {
                    Facing = "north";
Type = "left";
Waterlogged = false;
                }

                if(value == 6630) {
                    Facing = "north";
Type = "right";
Waterlogged = true;
                }

                if(value == 6631) {
                    Facing = "north";
Type = "right";
Waterlogged = false;
                }

                if(value == 6632) {
                    Facing = "south";
Type = "single";
Waterlogged = true;
                }

                if(value == 6633) {
                    Facing = "south";
Type = "single";
Waterlogged = false;
                }

                if(value == 6634) {
                    Facing = "south";
Type = "left";
Waterlogged = true;
                }

                if(value == 6635) {
                    Facing = "south";
Type = "left";
Waterlogged = false;
                }

                if(value == 6636) {
                    Facing = "south";
Type = "right";
Waterlogged = true;
                }

                if(value == 6637) {
                    Facing = "south";
Type = "right";
Waterlogged = false;
                }

                if(value == 6638) {
                    Facing = "west";
Type = "single";
Waterlogged = true;
                }

                if(value == 6639) {
                    Facing = "west";
Type = "single";
Waterlogged = false;
                }

                if(value == 6640) {
                    Facing = "west";
Type = "left";
Waterlogged = true;
                }

                if(value == 6641) {
                    Facing = "west";
Type = "left";
Waterlogged = false;
                }

                if(value == 6642) {
                    Facing = "west";
Type = "right";
Waterlogged = true;
                }

                if(value == 6643) {
                    Facing = "west";
Type = "right";
Waterlogged = false;
                }

                if(value == 6644) {
                    Facing = "east";
Type = "single";
Waterlogged = true;
                }

                if(value == 6645) {
                    Facing = "east";
Type = "single";
Waterlogged = false;
                }

                if(value == 6646) {
                    Facing = "east";
Type = "left";
Waterlogged = true;
                }

                if(value == 6647) {
                    Facing = "east";
Type = "left";
Waterlogged = false;
                }

                if(value == 6648) {
                    Facing = "east";
Type = "right";
Waterlogged = true;
                }

                if(value == 6649) {
                    Facing = "east";
Type = "right";
Waterlogged = false;
                }

            }
        }

        public string Facing { get; set; } = "north";
        public string Type { get; set; } = "single";
        public bool Waterlogged { get; set; } = false;

        public BlockTrappedChest() {
            State = DefaultState;
        }

        public BlockTrappedChest(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockTrappedChest(string facing, string type, bool waterlogged) {
            Facing = facing;
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}