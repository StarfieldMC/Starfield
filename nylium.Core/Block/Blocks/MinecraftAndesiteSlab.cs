// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockAndesiteSlab : BlockBase {

        public override string Id { get { return "minecraft:andesite_slab"; } }

        public override ushort MinimumState { get { return 10847; } }
        public override ushort MaximumState { get { return 10852; } }
        public override ushort DefaultState { get { return 10850; } }

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 10847;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 10848;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 10849;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 10850;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 10851;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 10852;
                }

                return DefaultState;
            }

            set {
                if(value == 10847) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 10848) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 10849) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 10850) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 10851) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 10852) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockAndesiteSlab() {
            State = DefaultState;
        }

        public BlockAndesiteSlab(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockAndesiteSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}