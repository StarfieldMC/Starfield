// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:green_banner", 429, 8109, 8124, 8109)]
    public class BlockGreenBanner : BlockBase {

        public override ushort State {
            get {
                if(Rotation == 0) {
                    return 8109;
                }

                if(Rotation == 1) {
                    return 8110;
                }

                if(Rotation == 2) {
                    return 8111;
                }

                if(Rotation == 3) {
                    return 8112;
                }

                if(Rotation == 4) {
                    return 8113;
                }

                if(Rotation == 5) {
                    return 8114;
                }

                if(Rotation == 6) {
                    return 8115;
                }

                if(Rotation == 7) {
                    return 8116;
                }

                if(Rotation == 8) {
                    return 8117;
                }

                if(Rotation == 9) {
                    return 8118;
                }

                if(Rotation == 10) {
                    return 8119;
                }

                if(Rotation == 11) {
                    return 8120;
                }

                if(Rotation == 12) {
                    return 8121;
                }

                if(Rotation == 13) {
                    return 8122;
                }

                if(Rotation == 14) {
                    return 8123;
                }

                if(Rotation == 15) {
                    return 8124;
                }

                return DefaultState;
            }

            set {
                if(value == 8109) {
                    Rotation = 0;
                }

                if(value == 8110) {
                    Rotation = 1;
                }

                if(value == 8111) {
                    Rotation = 2;
                }

                if(value == 8112) {
                    Rotation = 3;
                }

                if(value == 8113) {
                    Rotation = 4;
                }

                if(value == 8114) {
                    Rotation = 5;
                }

                if(value == 8115) {
                    Rotation = 6;
                }

                if(value == 8116) {
                    Rotation = 7;
                }

                if(value == 8117) {
                    Rotation = 8;
                }

                if(value == 8118) {
                    Rotation = 9;
                }

                if(value == 8119) {
                    Rotation = 10;
                }

                if(value == 8120) {
                    Rotation = 11;
                }

                if(value == 8121) {
                    Rotation = 12;
                }

                if(value == 8122) {
                    Rotation = 13;
                }

                if(value == 8123) {
                    Rotation = 14;
                }

                if(value == 8124) {
                    Rotation = 15;
                }

            }
        }

        public int Rotation { get; set; } = 0;

        public BlockGreenBanner() {
            State = DefaultState;
        }

        public BlockGreenBanner(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockGreenBanner(int rotation) {
            Rotation = rotation;
        }
    }
}