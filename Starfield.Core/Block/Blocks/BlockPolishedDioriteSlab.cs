// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:polished_diorite_slab", 644, 10811, 10816, 10814)]
    public class BlockPolishedDioriteSlab : BlockBase {

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 10811;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 10812;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 10813;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 10814;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 10815;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 10816;
                }

                return DefaultState;
            }

            set {
                if(value == 10811) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 10812) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 10813) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 10814) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 10815) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 10816) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockPolishedDioriteSlab() {
            State = DefaultState;
        }

        public BlockPolishedDioriteSlab(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockPolishedDioriteSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}