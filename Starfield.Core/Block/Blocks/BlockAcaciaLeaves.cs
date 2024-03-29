// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:acacia_leaves", 63, 201, 214, 214)]
    public class BlockAcaciaLeaves : BlockBase {

        public override ushort State {
            get {
                if(Distance == 1 && Persistent == true) {
                    return 201;
                }

                if(Distance == 1 && Persistent == false) {
                    return 202;
                }

                if(Distance == 2 && Persistent == true) {
                    return 203;
                }

                if(Distance == 2 && Persistent == false) {
                    return 204;
                }

                if(Distance == 3 && Persistent == true) {
                    return 205;
                }

                if(Distance == 3 && Persistent == false) {
                    return 206;
                }

                if(Distance == 4 && Persistent == true) {
                    return 207;
                }

                if(Distance == 4 && Persistent == false) {
                    return 208;
                }

                if(Distance == 5 && Persistent == true) {
                    return 209;
                }

                if(Distance == 5 && Persistent == false) {
                    return 210;
                }

                if(Distance == 6 && Persistent == true) {
                    return 211;
                }

                if(Distance == 6 && Persistent == false) {
                    return 212;
                }

                if(Distance == 7 && Persistent == true) {
                    return 213;
                }

                if(Distance == 7 && Persistent == false) {
                    return 214;
                }

                return DefaultState;
            }

            set {
                if(value == 201) {
                    Distance = 1;
Persistent = true;
                }

                if(value == 202) {
                    Distance = 1;
Persistent = false;
                }

                if(value == 203) {
                    Distance = 2;
Persistent = true;
                }

                if(value == 204) {
                    Distance = 2;
Persistent = false;
                }

                if(value == 205) {
                    Distance = 3;
Persistent = true;
                }

                if(value == 206) {
                    Distance = 3;
Persistent = false;
                }

                if(value == 207) {
                    Distance = 4;
Persistent = true;
                }

                if(value == 208) {
                    Distance = 4;
Persistent = false;
                }

                if(value == 209) {
                    Distance = 5;
Persistent = true;
                }

                if(value == 210) {
                    Distance = 5;
Persistent = false;
                }

                if(value == 211) {
                    Distance = 6;
Persistent = true;
                }

                if(value == 212) {
                    Distance = 6;
Persistent = false;
                }

                if(value == 213) {
                    Distance = 7;
Persistent = true;
                }

                if(value == 214) {
                    Distance = 7;
Persistent = false;
                }

            }
        }

        public int Distance { get; set; } = 7;
        public bool Persistent { get; set; } = false;

        public BlockAcaciaLeaves() {
            State = DefaultState;
        }

        public BlockAcaciaLeaves(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockAcaciaLeaves(int distance, bool persistent) {
            Distance = distance;
            Persistent = persistent;
        }
    }
}