// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:blue_banner", 427, 8077, 8092, 8077)]
    public class BlockBlueBanner : BlockBase {

        public override ushort State {
            get {
                if(Rotation == 0) {
                    return 8077;
                }

                if(Rotation == 1) {
                    return 8078;
                }

                if(Rotation == 2) {
                    return 8079;
                }

                if(Rotation == 3) {
                    return 8080;
                }

                if(Rotation == 4) {
                    return 8081;
                }

                if(Rotation == 5) {
                    return 8082;
                }

                if(Rotation == 6) {
                    return 8083;
                }

                if(Rotation == 7) {
                    return 8084;
                }

                if(Rotation == 8) {
                    return 8085;
                }

                if(Rotation == 9) {
                    return 8086;
                }

                if(Rotation == 10) {
                    return 8087;
                }

                if(Rotation == 11) {
                    return 8088;
                }

                if(Rotation == 12) {
                    return 8089;
                }

                if(Rotation == 13) {
                    return 8090;
                }

                if(Rotation == 14) {
                    return 8091;
                }

                if(Rotation == 15) {
                    return 8092;
                }

                return DefaultState;
            }

            set {
                if(value == 8077) {
                    Rotation = 0;
                }

                if(value == 8078) {
                    Rotation = 1;
                }

                if(value == 8079) {
                    Rotation = 2;
                }

                if(value == 8080) {
                    Rotation = 3;
                }

                if(value == 8081) {
                    Rotation = 4;
                }

                if(value == 8082) {
                    Rotation = 5;
                }

                if(value == 8083) {
                    Rotation = 6;
                }

                if(value == 8084) {
                    Rotation = 7;
                }

                if(value == 8085) {
                    Rotation = 8;
                }

                if(value == 8086) {
                    Rotation = 9;
                }

                if(value == 8087) {
                    Rotation = 10;
                }

                if(value == 8088) {
                    Rotation = 11;
                }

                if(value == 8089) {
                    Rotation = 12;
                }

                if(value == 8090) {
                    Rotation = 13;
                }

                if(value == 8091) {
                    Rotation = 14;
                }

                if(value == 8092) {
                    Rotation = 15;
                }

            }
        }

        public int Rotation { get; set; } = 0;

        public BlockBlueBanner() {
            State = DefaultState;
        }

        public BlockBlueBanner(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBlueBanner(int rotation) {
            Rotation = rotation;
        }
    }
}