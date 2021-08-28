// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:mossy_stone_brick_slab", 643, 10805, 10810, 10808)]
    public class BlockMossyStoneBrickSlab : BlockBase {

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 10805;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 10806;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 10807;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 10808;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 10809;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 10810;
                }

                return DefaultState;
            }

            set {
                if(value == 10805) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 10806) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 10807) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 10808) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 10809) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 10810) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockMossyStoneBrickSlab() {
            State = DefaultState;
        }

        public BlockMossyStoneBrickSlab(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockMossyStoneBrickSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}