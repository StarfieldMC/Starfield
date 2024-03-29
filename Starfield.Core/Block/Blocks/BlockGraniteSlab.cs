// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:granite_slab", 649, 10841, 10846, 10844)]
    public class BlockGraniteSlab : BlockBase {

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 10841;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 10842;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 10843;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 10844;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 10845;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 10846;
                }

                return DefaultState;
            }

            set {
                if(value == 10841) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 10842) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 10843) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 10844) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 10845) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 10846) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockGraniteSlab() {
            State = DefaultState;
        }

        public BlockGraniteSlab(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockGraniteSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}