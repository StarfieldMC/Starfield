// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:lime_banner", 421, 7981, 7996, 7981)]
    public class BlockLimeBanner : BlockBase {

        public override ushort State {
            get {
                if(Rotation == 0) {
                    return 7981;
                }

                if(Rotation == 1) {
                    return 7982;
                }

                if(Rotation == 2) {
                    return 7983;
                }

                if(Rotation == 3) {
                    return 7984;
                }

                if(Rotation == 4) {
                    return 7985;
                }

                if(Rotation == 5) {
                    return 7986;
                }

                if(Rotation == 6) {
                    return 7987;
                }

                if(Rotation == 7) {
                    return 7988;
                }

                if(Rotation == 8) {
                    return 7989;
                }

                if(Rotation == 9) {
                    return 7990;
                }

                if(Rotation == 10) {
                    return 7991;
                }

                if(Rotation == 11) {
                    return 7992;
                }

                if(Rotation == 12) {
                    return 7993;
                }

                if(Rotation == 13) {
                    return 7994;
                }

                if(Rotation == 14) {
                    return 7995;
                }

                if(Rotation == 15) {
                    return 7996;
                }

                return DefaultState;
            }

            set {
                if(value == 7981) {
                    Rotation = 0;
                }

                if(value == 7982) {
                    Rotation = 1;
                }

                if(value == 7983) {
                    Rotation = 2;
                }

                if(value == 7984) {
                    Rotation = 3;
                }

                if(value == 7985) {
                    Rotation = 4;
                }

                if(value == 7986) {
                    Rotation = 5;
                }

                if(value == 7987) {
                    Rotation = 6;
                }

                if(value == 7988) {
                    Rotation = 7;
                }

                if(value == 7989) {
                    Rotation = 8;
                }

                if(value == 7990) {
                    Rotation = 9;
                }

                if(value == 7991) {
                    Rotation = 10;
                }

                if(value == 7992) {
                    Rotation = 11;
                }

                if(value == 7993) {
                    Rotation = 12;
                }

                if(value == 7994) {
                    Rotation = 13;
                }

                if(value == 7995) {
                    Rotation = 14;
                }

                if(value == 7996) {
                    Rotation = 15;
                }

            }
        }

        public int Rotation { get; set; } = 0;

        public BlockLimeBanner() {
            State = DefaultState;
        }

        public BlockLimeBanner(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockLimeBanner(int rotation) {
            Rotation = rotation;
        }
    }
}