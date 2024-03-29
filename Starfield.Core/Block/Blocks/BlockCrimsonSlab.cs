// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:crimson_slab", 706, 15055, 15060, 15058)]
    public class BlockCrimsonSlab : BlockBase {

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 15055;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 15056;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 15057;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 15058;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 15059;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 15060;
                }

                return DefaultState;
            }

            set {
                if(value == 15055) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 15056) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 15057) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 15058) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 15059) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 15060) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockCrimsonSlab() {
            State = DefaultState;
        }

        public BlockCrimsonSlab(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockCrimsonSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}