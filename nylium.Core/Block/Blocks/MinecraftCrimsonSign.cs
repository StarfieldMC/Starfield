// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockCrimsonSign : BlockBase {

        public override string Id { get { return "minecraft:crimson_sign"; } }

        public override ushort MinimumState { get { return 15663; } }
        public override ushort MaximumState { get { return 15694; } }
        public override ushort DefaultState { get { return 15664; } }

        public override ushort State {
            get {
                if(Rotation == 0 && Waterlogged == true) {
                    return 15663;
                }

                if(Rotation == 0 && Waterlogged == false) {
                    return 15664;
                }

                if(Rotation == 1 && Waterlogged == true) {
                    return 15665;
                }

                if(Rotation == 1 && Waterlogged == false) {
                    return 15666;
                }

                if(Rotation == 2 && Waterlogged == true) {
                    return 15667;
                }

                if(Rotation == 2 && Waterlogged == false) {
                    return 15668;
                }

                if(Rotation == 3 && Waterlogged == true) {
                    return 15669;
                }

                if(Rotation == 3 && Waterlogged == false) {
                    return 15670;
                }

                if(Rotation == 4 && Waterlogged == true) {
                    return 15671;
                }

                if(Rotation == 4 && Waterlogged == false) {
                    return 15672;
                }

                if(Rotation == 5 && Waterlogged == true) {
                    return 15673;
                }

                if(Rotation == 5 && Waterlogged == false) {
                    return 15674;
                }

                if(Rotation == 6 && Waterlogged == true) {
                    return 15675;
                }

                if(Rotation == 6 && Waterlogged == false) {
                    return 15676;
                }

                if(Rotation == 7 && Waterlogged == true) {
                    return 15677;
                }

                if(Rotation == 7 && Waterlogged == false) {
                    return 15678;
                }

                if(Rotation == 8 && Waterlogged == true) {
                    return 15679;
                }

                if(Rotation == 8 && Waterlogged == false) {
                    return 15680;
                }

                if(Rotation == 9 && Waterlogged == true) {
                    return 15681;
                }

                if(Rotation == 9 && Waterlogged == false) {
                    return 15682;
                }

                if(Rotation == 10 && Waterlogged == true) {
                    return 15683;
                }

                if(Rotation == 10 && Waterlogged == false) {
                    return 15684;
                }

                if(Rotation == 11 && Waterlogged == true) {
                    return 15685;
                }

                if(Rotation == 11 && Waterlogged == false) {
                    return 15686;
                }

                if(Rotation == 12 && Waterlogged == true) {
                    return 15687;
                }

                if(Rotation == 12 && Waterlogged == false) {
                    return 15688;
                }

                if(Rotation == 13 && Waterlogged == true) {
                    return 15689;
                }

                if(Rotation == 13 && Waterlogged == false) {
                    return 15690;
                }

                if(Rotation == 14 && Waterlogged == true) {
                    return 15691;
                }

                if(Rotation == 14 && Waterlogged == false) {
                    return 15692;
                }

                if(Rotation == 15 && Waterlogged == true) {
                    return 15693;
                }

                if(Rotation == 15 && Waterlogged == false) {
                    return 15694;
                }

                return DefaultState;
            }

            set {
                if(value == 15663) {
                    Rotation = 0;
Waterlogged = true;
                }

                if(value == 15664) {
                    Rotation = 0;
Waterlogged = false;
                }

                if(value == 15665) {
                    Rotation = 1;
Waterlogged = true;
                }

                if(value == 15666) {
                    Rotation = 1;
Waterlogged = false;
                }

                if(value == 15667) {
                    Rotation = 2;
Waterlogged = true;
                }

                if(value == 15668) {
                    Rotation = 2;
Waterlogged = false;
                }

                if(value == 15669) {
                    Rotation = 3;
Waterlogged = true;
                }

                if(value == 15670) {
                    Rotation = 3;
Waterlogged = false;
                }

                if(value == 15671) {
                    Rotation = 4;
Waterlogged = true;
                }

                if(value == 15672) {
                    Rotation = 4;
Waterlogged = false;
                }

                if(value == 15673) {
                    Rotation = 5;
Waterlogged = true;
                }

                if(value == 15674) {
                    Rotation = 5;
Waterlogged = false;
                }

                if(value == 15675) {
                    Rotation = 6;
Waterlogged = true;
                }

                if(value == 15676) {
                    Rotation = 6;
Waterlogged = false;
                }

                if(value == 15677) {
                    Rotation = 7;
Waterlogged = true;
                }

                if(value == 15678) {
                    Rotation = 7;
Waterlogged = false;
                }

                if(value == 15679) {
                    Rotation = 8;
Waterlogged = true;
                }

                if(value == 15680) {
                    Rotation = 8;
Waterlogged = false;
                }

                if(value == 15681) {
                    Rotation = 9;
Waterlogged = true;
                }

                if(value == 15682) {
                    Rotation = 9;
Waterlogged = false;
                }

                if(value == 15683) {
                    Rotation = 10;
Waterlogged = true;
                }

                if(value == 15684) {
                    Rotation = 10;
Waterlogged = false;
                }

                if(value == 15685) {
                    Rotation = 11;
Waterlogged = true;
                }

                if(value == 15686) {
                    Rotation = 11;
Waterlogged = false;
                }

                if(value == 15687) {
                    Rotation = 12;
Waterlogged = true;
                }

                if(value == 15688) {
                    Rotation = 12;
Waterlogged = false;
                }

                if(value == 15689) {
                    Rotation = 13;
Waterlogged = true;
                }

                if(value == 15690) {
                    Rotation = 13;
Waterlogged = false;
                }

                if(value == 15691) {
                    Rotation = 14;
Waterlogged = true;
                }

                if(value == 15692) {
                    Rotation = 14;
Waterlogged = false;
                }

                if(value == 15693) {
                    Rotation = 15;
Waterlogged = true;
                }

                if(value == 15694) {
                    Rotation = 15;
Waterlogged = false;
                }

            }
        }

        public int Rotation { get; set; } = 0;
        public bool Waterlogged { get; set; } = false;

        public BlockCrimsonSign() {
            State = DefaultState;
        }

        public BlockCrimsonSign(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockCrimsonSign(int rotation, bool waterlogged) {
            Rotation = rotation;
            Waterlogged = waterlogged;
        }
    }
}