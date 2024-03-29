// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:quartz_slab", 467, 8394, 8399, 8397)]
    public class BlockQuartzSlab : BlockBase {

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 8394;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 8395;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 8396;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 8397;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 8398;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 8399;
                }

                return DefaultState;
            }

            set {
                if(value == 8394) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 8395) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 8396) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 8397) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 8398) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 8399) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockQuartzSlab() {
            State = DefaultState;
        }

        public BlockQuartzSlab(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockQuartzSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}