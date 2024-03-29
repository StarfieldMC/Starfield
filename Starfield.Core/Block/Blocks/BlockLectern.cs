// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:lectern", 674, 14837, 14852, 14840)]
    public class BlockLectern : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north" && HasBook == true && Powered == true) {
                    return 14837;
                }

                if(Facing == "north" && HasBook == true && Powered == false) {
                    return 14838;
                }

                if(Facing == "north" && HasBook == false && Powered == true) {
                    return 14839;
                }

                if(Facing == "north" && HasBook == false && Powered == false) {
                    return 14840;
                }

                if(Facing == "south" && HasBook == true && Powered == true) {
                    return 14841;
                }

                if(Facing == "south" && HasBook == true && Powered == false) {
                    return 14842;
                }

                if(Facing == "south" && HasBook == false && Powered == true) {
                    return 14843;
                }

                if(Facing == "south" && HasBook == false && Powered == false) {
                    return 14844;
                }

                if(Facing == "west" && HasBook == true && Powered == true) {
                    return 14845;
                }

                if(Facing == "west" && HasBook == true && Powered == false) {
                    return 14846;
                }

                if(Facing == "west" && HasBook == false && Powered == true) {
                    return 14847;
                }

                if(Facing == "west" && HasBook == false && Powered == false) {
                    return 14848;
                }

                if(Facing == "east" && HasBook == true && Powered == true) {
                    return 14849;
                }

                if(Facing == "east" && HasBook == true && Powered == false) {
                    return 14850;
                }

                if(Facing == "east" && HasBook == false && Powered == true) {
                    return 14851;
                }

                if(Facing == "east" && HasBook == false && Powered == false) {
                    return 14852;
                }

                return DefaultState;
            }

            set {
                if(value == 14837) {
                    Facing = "north";
HasBook = true;
Powered = true;
                }

                if(value == 14838) {
                    Facing = "north";
HasBook = true;
Powered = false;
                }

                if(value == 14839) {
                    Facing = "north";
HasBook = false;
Powered = true;
                }

                if(value == 14840) {
                    Facing = "north";
HasBook = false;
Powered = false;
                }

                if(value == 14841) {
                    Facing = "south";
HasBook = true;
Powered = true;
                }

                if(value == 14842) {
                    Facing = "south";
HasBook = true;
Powered = false;
                }

                if(value == 14843) {
                    Facing = "south";
HasBook = false;
Powered = true;
                }

                if(value == 14844) {
                    Facing = "south";
HasBook = false;
Powered = false;
                }

                if(value == 14845) {
                    Facing = "west";
HasBook = true;
Powered = true;
                }

                if(value == 14846) {
                    Facing = "west";
HasBook = true;
Powered = false;
                }

                if(value == 14847) {
                    Facing = "west";
HasBook = false;
Powered = true;
                }

                if(value == 14848) {
                    Facing = "west";
HasBook = false;
Powered = false;
                }

                if(value == 14849) {
                    Facing = "east";
HasBook = true;
Powered = true;
                }

                if(value == 14850) {
                    Facing = "east";
HasBook = true;
Powered = false;
                }

                if(value == 14851) {
                    Facing = "east";
HasBook = false;
Powered = true;
                }

                if(value == 14852) {
                    Facing = "east";
HasBook = false;
Powered = false;
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool HasBook { get; set; } = false;
        public bool Powered { get; set; } = false;

        public BlockLectern() {
            State = DefaultState;
        }

        public BlockLectern(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockLectern(string facing, bool has_book, bool powered) {
            Facing = facing;
            HasBook = has_book;
            Powered = powered;
        }
    }
}