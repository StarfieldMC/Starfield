// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:petrified_oak_slab", 462, 8364, 8369, 8367)]
    public class BlockPetrifiedOakSlab : BlockBase {

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 8364;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 8365;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 8366;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 8367;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 8368;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 8369;
                }

                return DefaultState;
            }

            set {
                if(value == 8364) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 8365) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 8366) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 8367) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 8368) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 8369) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockPetrifiedOakSlab() {
            State = DefaultState;
        }

        public BlockPetrifiedOakSlab(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockPetrifiedOakSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}