// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:spruce_leaves", 60, 159, 172, 172)]
    public class BlockSpruceLeaves : BlockBase {

        public override ushort State {
            get {
                if(Distance == 1 && Persistent == true) {
                    return 159;
                }

                if(Distance == 1 && Persistent == false) {
                    return 160;
                }

                if(Distance == 2 && Persistent == true) {
                    return 161;
                }

                if(Distance == 2 && Persistent == false) {
                    return 162;
                }

                if(Distance == 3 && Persistent == true) {
                    return 163;
                }

                if(Distance == 3 && Persistent == false) {
                    return 164;
                }

                if(Distance == 4 && Persistent == true) {
                    return 165;
                }

                if(Distance == 4 && Persistent == false) {
                    return 166;
                }

                if(Distance == 5 && Persistent == true) {
                    return 167;
                }

                if(Distance == 5 && Persistent == false) {
                    return 168;
                }

                if(Distance == 6 && Persistent == true) {
                    return 169;
                }

                if(Distance == 6 && Persistent == false) {
                    return 170;
                }

                if(Distance == 7 && Persistent == true) {
                    return 171;
                }

                if(Distance == 7 && Persistent == false) {
                    return 172;
                }

                return DefaultState;
            }

            set {
                if(value == 159) {
                    Distance = 1;
Persistent = true;
                }

                if(value == 160) {
                    Distance = 1;
Persistent = false;
                }

                if(value == 161) {
                    Distance = 2;
Persistent = true;
                }

                if(value == 162) {
                    Distance = 2;
Persistent = false;
                }

                if(value == 163) {
                    Distance = 3;
Persistent = true;
                }

                if(value == 164) {
                    Distance = 3;
Persistent = false;
                }

                if(value == 165) {
                    Distance = 4;
Persistent = true;
                }

                if(value == 166) {
                    Distance = 4;
Persistent = false;
                }

                if(value == 167) {
                    Distance = 5;
Persistent = true;
                }

                if(value == 168) {
                    Distance = 5;
Persistent = false;
                }

                if(value == 169) {
                    Distance = 6;
Persistent = true;
                }

                if(value == 170) {
                    Distance = 6;
Persistent = false;
                }

                if(value == 171) {
                    Distance = 7;
Persistent = true;
                }

                if(value == 172) {
                    Distance = 7;
Persistent = false;
                }

            }
        }

        public int Distance { get; set; } = 7;
        public bool Persistent { get; set; } = false;

        public BlockSpruceLeaves() {
            State = DefaultState;
        }

        public BlockSpruceLeaves(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockSpruceLeaves(int distance, bool persistent) {
            Distance = distance;
            Persistent = persistent;
        }
    }
}