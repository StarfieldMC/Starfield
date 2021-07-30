// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockCrimsonSlab : BlockBase {

        public override string Id { get { return "minecraft:crimson_slab"; } }

        public override ushort MinimumState { get { return 15055; } }
        public override ushort MaximumState { get { return 15060; } }
        public override ushort DefaultState { get { return 15058; } }

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

        public BlockCrimsonSlab(ushort state) {
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