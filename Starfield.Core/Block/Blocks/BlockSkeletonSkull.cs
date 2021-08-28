// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:skeleton_skull", 314, 6494, 6509, 6494)]
    public class BlockSkeletonSkull : BlockBase {

        public override ushort State {
            get {
                if(Rotation == 0) {
                    return 6494;
                }

                if(Rotation == 1) {
                    return 6495;
                }

                if(Rotation == 2) {
                    return 6496;
                }

                if(Rotation == 3) {
                    return 6497;
                }

                if(Rotation == 4) {
                    return 6498;
                }

                if(Rotation == 5) {
                    return 6499;
                }

                if(Rotation == 6) {
                    return 6500;
                }

                if(Rotation == 7) {
                    return 6501;
                }

                if(Rotation == 8) {
                    return 6502;
                }

                if(Rotation == 9) {
                    return 6503;
                }

                if(Rotation == 10) {
                    return 6504;
                }

                if(Rotation == 11) {
                    return 6505;
                }

                if(Rotation == 12) {
                    return 6506;
                }

                if(Rotation == 13) {
                    return 6507;
                }

                if(Rotation == 14) {
                    return 6508;
                }

                if(Rotation == 15) {
                    return 6509;
                }

                return DefaultState;
            }

            set {
                if(value == 6494) {
                    Rotation = 0;
                }

                if(value == 6495) {
                    Rotation = 1;
                }

                if(value == 6496) {
                    Rotation = 2;
                }

                if(value == 6497) {
                    Rotation = 3;
                }

                if(value == 6498) {
                    Rotation = 4;
                }

                if(value == 6499) {
                    Rotation = 5;
                }

                if(value == 6500) {
                    Rotation = 6;
                }

                if(value == 6501) {
                    Rotation = 7;
                }

                if(value == 6502) {
                    Rotation = 8;
                }

                if(value == 6503) {
                    Rotation = 9;
                }

                if(value == 6504) {
                    Rotation = 10;
                }

                if(value == 6505) {
                    Rotation = 11;
                }

                if(value == 6506) {
                    Rotation = 12;
                }

                if(value == 6507) {
                    Rotation = 13;
                }

                if(value == 6508) {
                    Rotation = 14;
                }

                if(value == 6509) {
                    Rotation = 15;
                }

            }
        }

        public int Rotation { get; set; } = 0;

        public BlockSkeletonSkull() {
            State = DefaultState;
        }

        public BlockSkeletonSkull(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockSkeletonSkull(int rotation) {
            Rotation = rotation;
        }
    }
}