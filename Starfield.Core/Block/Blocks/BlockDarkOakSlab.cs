// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:dark_oak_slab", 457, 8334, 8339, 8337)]
    public class BlockDarkOakSlab : BlockBase {

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 8334;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 8335;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 8336;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 8337;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 8338;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 8339;
                }

                return DefaultState;
            }

            set {
                if(value == 8334) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 8335) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 8336) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 8337) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 8338) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 8339) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockDarkOakSlab() {
            State = DefaultState;
        }

        public BlockDarkOakSlab(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockDarkOakSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}