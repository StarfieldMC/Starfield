// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:mossy_cobblestone_slab", 645, 10817, 10822, 10820)]
    public class BlockMossyCobblestoneSlab : BlockBase {

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 10817;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 10818;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 10819;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 10820;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 10821;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 10822;
                }

                return DefaultState;
            }

            set {
                if(value == 10817) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 10818) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 10819) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 10820) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 10821) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 10822) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockMossyCobblestoneSlab() {
            State = DefaultState;
        }

        public BlockMossyCobblestoneSlab(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockMossyCobblestoneSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}