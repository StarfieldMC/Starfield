// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockCreeperHead : BlockBase {

        public override string Id { get { return "minecraft:creeper_head"; } }

        public override ushort MinimumState { get { return 6574; } }
        public override ushort MaximumState { get { return 6589; } }
        public override ushort DefaultState { get { return 6574; } }

        public override ushort State {
            get {
                if(Rotation == 0) {
                    return 6574;
                }

                if(Rotation == 1) {
                    return 6575;
                }

                if(Rotation == 2) {
                    return 6576;
                }

                if(Rotation == 3) {
                    return 6577;
                }

                if(Rotation == 4) {
                    return 6578;
                }

                if(Rotation == 5) {
                    return 6579;
                }

                if(Rotation == 6) {
                    return 6580;
                }

                if(Rotation == 7) {
                    return 6581;
                }

                if(Rotation == 8) {
                    return 6582;
                }

                if(Rotation == 9) {
                    return 6583;
                }

                if(Rotation == 10) {
                    return 6584;
                }

                if(Rotation == 11) {
                    return 6585;
                }

                if(Rotation == 12) {
                    return 6586;
                }

                if(Rotation == 13) {
                    return 6587;
                }

                if(Rotation == 14) {
                    return 6588;
                }

                if(Rotation == 15) {
                    return 6589;
                }

                return DefaultState;
            }

            set {
                if(value == 6574) {
                    Rotation = 0;
                }

                if(value == 6575) {
                    Rotation = 1;
                }

                if(value == 6576) {
                    Rotation = 2;
                }

                if(value == 6577) {
                    Rotation = 3;
                }

                if(value == 6578) {
                    Rotation = 4;
                }

                if(value == 6579) {
                    Rotation = 5;
                }

                if(value == 6580) {
                    Rotation = 6;
                }

                if(value == 6581) {
                    Rotation = 7;
                }

                if(value == 6582) {
                    Rotation = 8;
                }

                if(value == 6583) {
                    Rotation = 9;
                }

                if(value == 6584) {
                    Rotation = 10;
                }

                if(value == 6585) {
                    Rotation = 11;
                }

                if(value == 6586) {
                    Rotation = 12;
                }

                if(value == 6587) {
                    Rotation = 13;
                }

                if(value == 6588) {
                    Rotation = 14;
                }

                if(value == 6589) {
                    Rotation = 15;
                }

            }
        }

        public int Rotation { get; set; } = 0;

        public BlockCreeperHead() {
            State = DefaultState;
        }

        public BlockCreeperHead(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockCreeperHead(int rotation) {
            Rotation = rotation;
        }
    }
}