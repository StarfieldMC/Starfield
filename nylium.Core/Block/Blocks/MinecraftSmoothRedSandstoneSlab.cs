// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockSmoothRedSandstoneSlab : BlockBase {

        public override string Id { get { return "minecraft:smooth_red_sandstone_slab"; } }

        public override ushort MinimumState { get { return 10799; } }
        public override ushort MaximumState { get { return 10804; } }
        public override ushort DefaultState { get { return 10802; } }

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 10799;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 10800;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 10801;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 10802;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 10803;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 10804;
                }

                return DefaultState;
            }

            set {
                if(value == 10799) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 10800) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 10801) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 10802) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 10803) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 10804) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockSmoothRedSandstoneSlab() {
            State = DefaultState;
        }

        public BlockSmoothRedSandstoneSlab(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockSmoothRedSandstoneSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}