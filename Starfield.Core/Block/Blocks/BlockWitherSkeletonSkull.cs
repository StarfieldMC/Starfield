// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:wither_skeleton_skull", 316, 6514, 6529, 6514)]
    public class BlockWitherSkeletonSkull : BlockBase {

        public override ushort State {
            get {
                if(Rotation == 0) {
                    return 6514;
                }

                if(Rotation == 1) {
                    return 6515;
                }

                if(Rotation == 2) {
                    return 6516;
                }

                if(Rotation == 3) {
                    return 6517;
                }

                if(Rotation == 4) {
                    return 6518;
                }

                if(Rotation == 5) {
                    return 6519;
                }

                if(Rotation == 6) {
                    return 6520;
                }

                if(Rotation == 7) {
                    return 6521;
                }

                if(Rotation == 8) {
                    return 6522;
                }

                if(Rotation == 9) {
                    return 6523;
                }

                if(Rotation == 10) {
                    return 6524;
                }

                if(Rotation == 11) {
                    return 6525;
                }

                if(Rotation == 12) {
                    return 6526;
                }

                if(Rotation == 13) {
                    return 6527;
                }

                if(Rotation == 14) {
                    return 6528;
                }

                if(Rotation == 15) {
                    return 6529;
                }

                return DefaultState;
            }

            set {
                if(value == 6514) {
                    Rotation = 0;
                }

                if(value == 6515) {
                    Rotation = 1;
                }

                if(value == 6516) {
                    Rotation = 2;
                }

                if(value == 6517) {
                    Rotation = 3;
                }

                if(value == 6518) {
                    Rotation = 4;
                }

                if(value == 6519) {
                    Rotation = 5;
                }

                if(value == 6520) {
                    Rotation = 6;
                }

                if(value == 6521) {
                    Rotation = 7;
                }

                if(value == 6522) {
                    Rotation = 8;
                }

                if(value == 6523) {
                    Rotation = 9;
                }

                if(value == 6524) {
                    Rotation = 10;
                }

                if(value == 6525) {
                    Rotation = 11;
                }

                if(value == 6526) {
                    Rotation = 12;
                }

                if(value == 6527) {
                    Rotation = 13;
                }

                if(value == 6528) {
                    Rotation = 14;
                }

                if(value == 6529) {
                    Rotation = 15;
                }

            }
        }

        public int Rotation { get; set; } = 0;

        public BlockWitherSkeletonSkull() {
            State = DefaultState;
        }

        public BlockWitherSkeletonSkull(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockWitherSkeletonSkull(int rotation) {
            Rotation = rotation;
        }
    }
}