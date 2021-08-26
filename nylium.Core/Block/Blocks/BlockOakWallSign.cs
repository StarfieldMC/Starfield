// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:oak_wall_sign", 165, 3735, 3742, 3736)]
    public class BlockOakWallSign : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north" && Waterlogged == true) {
                    return 3735;
                }

                if(Facing == "north" && Waterlogged == false) {
                    return 3736;
                }

                if(Facing == "south" && Waterlogged == true) {
                    return 3737;
                }

                if(Facing == "south" && Waterlogged == false) {
                    return 3738;
                }

                if(Facing == "west" && Waterlogged == true) {
                    return 3739;
                }

                if(Facing == "west" && Waterlogged == false) {
                    return 3740;
                }

                if(Facing == "east" && Waterlogged == true) {
                    return 3741;
                }

                if(Facing == "east" && Waterlogged == false) {
                    return 3742;
                }

                return DefaultState;
            }

            set {
                if(value == 3735) {
                    Facing = "north";
Waterlogged = true;
                }

                if(value == 3736) {
                    Facing = "north";
Waterlogged = false;
                }

                if(value == 3737) {
                    Facing = "south";
Waterlogged = true;
                }

                if(value == 3738) {
                    Facing = "south";
Waterlogged = false;
                }

                if(value == 3739) {
                    Facing = "west";
Waterlogged = true;
                }

                if(value == 3740) {
                    Facing = "west";
Waterlogged = false;
                }

                if(value == 3741) {
                    Facing = "east";
Waterlogged = true;
                }

                if(value == 3742) {
                    Facing = "east";
Waterlogged = false;
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool Waterlogged { get; set; } = false;

        public BlockOakWallSign() {
            State = DefaultState;
        }

        public BlockOakWallSign(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockOakWallSign(string facing, bool waterlogged) {
            Facing = facing;
            Waterlogged = waterlogged;
        }
    }
}