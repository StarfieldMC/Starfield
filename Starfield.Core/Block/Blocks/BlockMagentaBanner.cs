// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:magenta_banner", 418, 7933, 7948, 7933)]
    public class BlockMagentaBanner : BlockBase {

        public override ushort State {
            get {
                if(Rotation == 0) {
                    return 7933;
                }

                if(Rotation == 1) {
                    return 7934;
                }

                if(Rotation == 2) {
                    return 7935;
                }

                if(Rotation == 3) {
                    return 7936;
                }

                if(Rotation == 4) {
                    return 7937;
                }

                if(Rotation == 5) {
                    return 7938;
                }

                if(Rotation == 6) {
                    return 7939;
                }

                if(Rotation == 7) {
                    return 7940;
                }

                if(Rotation == 8) {
                    return 7941;
                }

                if(Rotation == 9) {
                    return 7942;
                }

                if(Rotation == 10) {
                    return 7943;
                }

                if(Rotation == 11) {
                    return 7944;
                }

                if(Rotation == 12) {
                    return 7945;
                }

                if(Rotation == 13) {
                    return 7946;
                }

                if(Rotation == 14) {
                    return 7947;
                }

                if(Rotation == 15) {
                    return 7948;
                }

                return DefaultState;
            }

            set {
                if(value == 7933) {
                    Rotation = 0;
                }

                if(value == 7934) {
                    Rotation = 1;
                }

                if(value == 7935) {
                    Rotation = 2;
                }

                if(value == 7936) {
                    Rotation = 3;
                }

                if(value == 7937) {
                    Rotation = 4;
                }

                if(value == 7938) {
                    Rotation = 5;
                }

                if(value == 7939) {
                    Rotation = 6;
                }

                if(value == 7940) {
                    Rotation = 7;
                }

                if(value == 7941) {
                    Rotation = 8;
                }

                if(value == 7942) {
                    Rotation = 9;
                }

                if(value == 7943) {
                    Rotation = 10;
                }

                if(value == 7944) {
                    Rotation = 11;
                }

                if(value == 7945) {
                    Rotation = 12;
                }

                if(value == 7946) {
                    Rotation = 13;
                }

                if(value == 7947) {
                    Rotation = 14;
                }

                if(value == 7948) {
                    Rotation = 15;
                }

            }
        }

        public int Rotation { get; set; } = 0;

        public BlockMagentaBanner() {
            State = DefaultState;
        }

        public BlockMagentaBanner(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockMagentaBanner(int rotation) {
            Rotation = rotation;
        }
    }
}