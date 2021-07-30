// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockLightGrayBanner : BlockBase {

        public override string Id { get { return "minecraft:light_gray_banner"; } }

        public override ushort MinimumState { get { return 8029; } }
        public override ushort MaximumState { get { return 8044; } }
        public override ushort DefaultState { get { return 8029; } }

        public override ushort State {
            get {
                if(Rotation == 0) {
                    return 8029;
                }

                if(Rotation == 1) {
                    return 8030;
                }

                if(Rotation == 2) {
                    return 8031;
                }

                if(Rotation == 3) {
                    return 8032;
                }

                if(Rotation == 4) {
                    return 8033;
                }

                if(Rotation == 5) {
                    return 8034;
                }

                if(Rotation == 6) {
                    return 8035;
                }

                if(Rotation == 7) {
                    return 8036;
                }

                if(Rotation == 8) {
                    return 8037;
                }

                if(Rotation == 9) {
                    return 8038;
                }

                if(Rotation == 10) {
                    return 8039;
                }

                if(Rotation == 11) {
                    return 8040;
                }

                if(Rotation == 12) {
                    return 8041;
                }

                if(Rotation == 13) {
                    return 8042;
                }

                if(Rotation == 14) {
                    return 8043;
                }

                if(Rotation == 15) {
                    return 8044;
                }

                return DefaultState;
            }

            set {
                if(value == 8029) {
                    Rotation = 0;
                }

                if(value == 8030) {
                    Rotation = 1;
                }

                if(value == 8031) {
                    Rotation = 2;
                }

                if(value == 8032) {
                    Rotation = 3;
                }

                if(value == 8033) {
                    Rotation = 4;
                }

                if(value == 8034) {
                    Rotation = 5;
                }

                if(value == 8035) {
                    Rotation = 6;
                }

                if(value == 8036) {
                    Rotation = 7;
                }

                if(value == 8037) {
                    Rotation = 8;
                }

                if(value == 8038) {
                    Rotation = 9;
                }

                if(value == 8039) {
                    Rotation = 10;
                }

                if(value == 8040) {
                    Rotation = 11;
                }

                if(value == 8041) {
                    Rotation = 12;
                }

                if(value == 8042) {
                    Rotation = 13;
                }

                if(value == 8043) {
                    Rotation = 14;
                }

                if(value == 8044) {
                    Rotation = 15;
                }

            }
        }

        public int Rotation { get; set; } = 0;

        public BlockLightGrayBanner() {
            State = DefaultState;
        }

        public BlockLightGrayBanner(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockLightGrayBanner(int rotation) {
            Rotation = rotation;
        }
    }
}