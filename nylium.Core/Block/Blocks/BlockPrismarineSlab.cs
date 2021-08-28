// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:prismarine_slab", 386, 7848, 7853, 7851)]
    public class BlockPrismarineSlab : BlockBase {

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 7848;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 7849;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 7850;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 7851;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 7852;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 7853;
                }

                return DefaultState;
            }

            set {
                if(value == 7848) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 7849) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 7850) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 7851) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 7852) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 7853) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockPrismarineSlab() {
            State = DefaultState;
        }

        public BlockPrismarineSlab(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockPrismarineSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}