// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockPinkBanner : BlockBase {

        public override string Id { get { return "minecraft:pink_banner"; } }

        public override ushort MinimumState { get { return 7997; } }
        public override ushort MaximumState { get { return 8012; } }
        public override ushort DefaultState { get { return 7997; } }

        public override ushort State {
            get {
                if(Rotation == 0) {
                    return 7997;
                }

                if(Rotation == 1) {
                    return 7998;
                }

                if(Rotation == 2) {
                    return 7999;
                }

                if(Rotation == 3) {
                    return 8000;
                }

                if(Rotation == 4) {
                    return 8001;
                }

                if(Rotation == 5) {
                    return 8002;
                }

                if(Rotation == 6) {
                    return 8003;
                }

                if(Rotation == 7) {
                    return 8004;
                }

                if(Rotation == 8) {
                    return 8005;
                }

                if(Rotation == 9) {
                    return 8006;
                }

                if(Rotation == 10) {
                    return 8007;
                }

                if(Rotation == 11) {
                    return 8008;
                }

                if(Rotation == 12) {
                    return 8009;
                }

                if(Rotation == 13) {
                    return 8010;
                }

                if(Rotation == 14) {
                    return 8011;
                }

                if(Rotation == 15) {
                    return 8012;
                }

                return DefaultState;
            }

            set {
                if(value == 7997) {
                    Rotation = 0;
                }

                if(value == 7998) {
                    Rotation = 1;
                }

                if(value == 7999) {
                    Rotation = 2;
                }

                if(value == 8000) {
                    Rotation = 3;
                }

                if(value == 8001) {
                    Rotation = 4;
                }

                if(value == 8002) {
                    Rotation = 5;
                }

                if(value == 8003) {
                    Rotation = 6;
                }

                if(value == 8004) {
                    Rotation = 7;
                }

                if(value == 8005) {
                    Rotation = 8;
                }

                if(value == 8006) {
                    Rotation = 9;
                }

                if(value == 8007) {
                    Rotation = 10;
                }

                if(value == 8008) {
                    Rotation = 11;
                }

                if(value == 8009) {
                    Rotation = 12;
                }

                if(value == 8010) {
                    Rotation = 13;
                }

                if(value == 8011) {
                    Rotation = 14;
                }

                if(value == 8012) {
                    Rotation = 15;
                }

            }
        }

        public int Rotation { get; set; } = 0;

        public BlockPinkBanner() {
            State = DefaultState;
        }

        public BlockPinkBanner(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockPinkBanner(int rotation) {
            Rotation = rotation;
        }
    }
}