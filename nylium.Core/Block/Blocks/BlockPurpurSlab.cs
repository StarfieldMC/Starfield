// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:purpur_slab", 470, 8412, 8417, 8415)]
    public class BlockPurpurSlab : BlockBase {

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 8412;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 8413;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 8414;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 8415;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 8416;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 8417;
                }

                return DefaultState;
            }

            set {
                if(value == 8412) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 8413) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 8414) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 8415) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 8416) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 8417) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockPurpurSlab() {
            State = DefaultState;
        }

        public BlockPurpurSlab(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockPurpurSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}