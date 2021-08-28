// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:nether_brick_slab", 466, 8388, 8393, 8391)]
    public class BlockNetherBrickSlab : BlockBase {

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 8388;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 8389;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 8390;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 8391;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 8392;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 8393;
                }

                return DefaultState;
            }

            set {
                if(value == 8388) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 8389) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 8390) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 8391) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 8392) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 8393) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockNetherBrickSlab() {
            State = DefaultState;
        }

        public BlockNetherBrickSlab(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockNetherBrickSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}