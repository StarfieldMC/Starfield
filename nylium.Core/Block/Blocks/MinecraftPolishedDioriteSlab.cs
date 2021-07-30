// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockPolishedDioriteSlab : BlockBase {

        public override string Id { get { return "minecraft:polished_diorite_slab"; } }

        public override ushort MinimumState { get { return 10811; } }
        public override ushort MaximumState { get { return 10816; } }
        public override ushort DefaultState { get { return 10814; } }

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

        public BlockPolishedDioriteSlab(ushort state) {
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