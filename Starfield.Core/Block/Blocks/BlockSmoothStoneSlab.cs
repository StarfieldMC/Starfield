// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:smooth_stone_slab", 459, 8346, 8351, 8349)]
    public class BlockSmoothStoneSlab : BlockBase {

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 8346;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 8347;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 8348;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 8349;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 8350;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 8351;
                }

                return DefaultState;
            }

            set {
                if(value == 8346) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 8347) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 8348) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 8349) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 8350) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 8351) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockSmoothStoneSlab() {
            State = DefaultState;
        }

        public BlockSmoothStoneSlab(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockSmoothStoneSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}