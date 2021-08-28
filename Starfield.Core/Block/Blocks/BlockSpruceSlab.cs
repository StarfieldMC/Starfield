// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:spruce_slab", 453, 8310, 8315, 8313)]
    public class BlockSpruceSlab : BlockBase {

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 8310;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 8311;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 8312;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 8313;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 8314;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 8315;
                }

                return DefaultState;
            }

            set {
                if(value == 8310) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 8311) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 8312) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 8313) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 8314) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 8315) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockSpruceSlab() {
            State = DefaultState;
        }

        public BlockSpruceSlab(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockSpruceSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}