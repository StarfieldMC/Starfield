// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:zombie_head", 318, 6534, 6549, 6534)]
    public class BlockZombieHead : BlockBase {

        public override ushort State {
            get {
                if(Rotation == 0) {
                    return 6534;
                }

                if(Rotation == 1) {
                    return 6535;
                }

                if(Rotation == 2) {
                    return 6536;
                }

                if(Rotation == 3) {
                    return 6537;
                }

                if(Rotation == 4) {
                    return 6538;
                }

                if(Rotation == 5) {
                    return 6539;
                }

                if(Rotation == 6) {
                    return 6540;
                }

                if(Rotation == 7) {
                    return 6541;
                }

                if(Rotation == 8) {
                    return 6542;
                }

                if(Rotation == 9) {
                    return 6543;
                }

                if(Rotation == 10) {
                    return 6544;
                }

                if(Rotation == 11) {
                    return 6545;
                }

                if(Rotation == 12) {
                    return 6546;
                }

                if(Rotation == 13) {
                    return 6547;
                }

                if(Rotation == 14) {
                    return 6548;
                }

                if(Rotation == 15) {
                    return 6549;
                }

                return DefaultState;
            }

            set {
                if(value == 6534) {
                    Rotation = 0;
                }

                if(value == 6535) {
                    Rotation = 1;
                }

                if(value == 6536) {
                    Rotation = 2;
                }

                if(value == 6537) {
                    Rotation = 3;
                }

                if(value == 6538) {
                    Rotation = 4;
                }

                if(value == 6539) {
                    Rotation = 5;
                }

                if(value == 6540) {
                    Rotation = 6;
                }

                if(value == 6541) {
                    Rotation = 7;
                }

                if(value == 6542) {
                    Rotation = 8;
                }

                if(value == 6543) {
                    Rotation = 9;
                }

                if(value == 6544) {
                    Rotation = 10;
                }

                if(value == 6545) {
                    Rotation = 11;
                }

                if(value == 6546) {
                    Rotation = 12;
                }

                if(value == 6547) {
                    Rotation = 13;
                }

                if(value == 6548) {
                    Rotation = 14;
                }

                if(value == 6549) {
                    Rotation = 15;
                }

            }
        }

        public int Rotation { get; set; } = 0;

        public BlockZombieHead() {
            State = DefaultState;
        }

        public BlockZombieHead(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockZombieHead(int rotation) {
            Rotation = rotation;
        }
    }
}