// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:stone_slab", 458, 8340, 8345, 8343)]
    public class BlockStoneSlab : BlockBase {

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 8340;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 8341;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 8342;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 8343;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 8344;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 8345;
                }

                return DefaultState;
            }

            set {
                if(value == 8340) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 8341) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 8342) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 8343) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 8344) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 8345) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockStoneSlab() {
            State = DefaultState;
        }

        public BlockStoneSlab(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockStoneSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}