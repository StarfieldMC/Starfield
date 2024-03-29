// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:jungle_slab", 455, 8322, 8327, 8325)]
    public class BlockJungleSlab : BlockBase {

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 8322;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 8323;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 8324;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 8325;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 8326;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 8327;
                }

                return DefaultState;
            }

            set {
                if(value == 8322) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 8323) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 8324) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 8325) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 8326) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 8327) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockJungleSlab() {
            State = DefaultState;
        }

        public BlockJungleSlab(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockJungleSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}