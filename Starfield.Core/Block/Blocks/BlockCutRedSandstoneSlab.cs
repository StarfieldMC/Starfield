// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:cut_red_sandstone_slab", 469, 8406, 8411, 8409)]
    public class BlockCutRedSandstoneSlab : BlockBase {

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 8406;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 8407;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 8408;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 8409;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 8410;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 8411;
                }

                return DefaultState;
            }

            set {
                if(value == 8406) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 8407) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 8408) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 8409) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 8410) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 8411) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockCutRedSandstoneSlab() {
            State = DefaultState;
        }

        public BlockCutRedSandstoneSlab(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockCutRedSandstoneSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}