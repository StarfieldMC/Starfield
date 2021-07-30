// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockPolishedBlackstoneBrickSlab : BlockBase {

        public override string Id { get { return "minecraft:polished_blackstone_brick_slab"; } }

        public override ushort MinimumState { get { return 16262; } }
        public override ushort MaximumState { get { return 16267; } }
        public override ushort DefaultState { get { return 16265; } }

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 16262;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 16263;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 16264;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 16265;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 16266;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 16267;
                }

                return DefaultState;
            }

            set {
                if(value == 16262) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 16263) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 16264) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 16265) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 16266) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 16267) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockPolishedBlackstoneBrickSlab() {
            State = DefaultState;
        }

        public BlockPolishedBlackstoneBrickSlab(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockPolishedBlackstoneBrickSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}