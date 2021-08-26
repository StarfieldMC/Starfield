// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:blackstone_slab", 746, 16252, 16257, 16255)]
    public class BlockBlackstoneSlab : BlockBase {

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 16252;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 16253;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 16254;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 16255;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 16256;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 16257;
                }

                return DefaultState;
            }

            set {
                if(value == 16252) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 16253) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 16254) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 16255) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 16256) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 16257) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockBlackstoneSlab() {
            State = DefaultState;
        }

        public BlockBlackstoneSlab(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBlackstoneSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}