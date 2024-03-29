// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:birch_leaves", 61, 173, 186, 186)]
    public class BlockBirchLeaves : BlockBase {

        public override ushort State {
            get {
                if(Distance == 1 && Persistent == true) {
                    return 173;
                }

                if(Distance == 1 && Persistent == false) {
                    return 174;
                }

                if(Distance == 2 && Persistent == true) {
                    return 175;
                }

                if(Distance == 2 && Persistent == false) {
                    return 176;
                }

                if(Distance == 3 && Persistent == true) {
                    return 177;
                }

                if(Distance == 3 && Persistent == false) {
                    return 178;
                }

                if(Distance == 4 && Persistent == true) {
                    return 179;
                }

                if(Distance == 4 && Persistent == false) {
                    return 180;
                }

                if(Distance == 5 && Persistent == true) {
                    return 181;
                }

                if(Distance == 5 && Persistent == false) {
                    return 182;
                }

                if(Distance == 6 && Persistent == true) {
                    return 183;
                }

                if(Distance == 6 && Persistent == false) {
                    return 184;
                }

                if(Distance == 7 && Persistent == true) {
                    return 185;
                }

                if(Distance == 7 && Persistent == false) {
                    return 186;
                }

                return DefaultState;
            }

            set {
                if(value == 173) {
                    Distance = 1;
Persistent = true;
                }

                if(value == 174) {
                    Distance = 1;
Persistent = false;
                }

                if(value == 175) {
                    Distance = 2;
Persistent = true;
                }

                if(value == 176) {
                    Distance = 2;
Persistent = false;
                }

                if(value == 177) {
                    Distance = 3;
Persistent = true;
                }

                if(value == 178) {
                    Distance = 3;
Persistent = false;
                }

                if(value == 179) {
                    Distance = 4;
Persistent = true;
                }

                if(value == 180) {
                    Distance = 4;
Persistent = false;
                }

                if(value == 181) {
                    Distance = 5;
Persistent = true;
                }

                if(value == 182) {
                    Distance = 5;
Persistent = false;
                }

                if(value == 183) {
                    Distance = 6;
Persistent = true;
                }

                if(value == 184) {
                    Distance = 6;
Persistent = false;
                }

                if(value == 185) {
                    Distance = 7;
Persistent = true;
                }

                if(value == 186) {
                    Distance = 7;
Persistent = false;
                }

            }
        }

        public int Distance { get; set; } = 7;
        public bool Persistent { get; set; } = false;

        public BlockBirchLeaves() {
            State = DefaultState;
        }

        public BlockBirchLeaves(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBirchLeaves(int distance, bool persistent) {
            Distance = distance;
            Persistent = persistent;
        }
    }
}