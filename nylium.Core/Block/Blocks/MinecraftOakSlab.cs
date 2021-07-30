// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockOakSlab : BlockBase {

        public override string Id { get { return "minecraft:oak_slab"; } }

        public override ushort MinimumState { get { return 8304; } }
        public override ushort MaximumState { get { return 8309; } }
        public override ushort DefaultState { get { return 8307; } }

        public override ushort State {
            get {
                if(Type == "top" && Waterlogged == true) {
                    return 8304;
                }

                if(Type == "top" && Waterlogged == false) {
                    return 8305;
                }

                if(Type == "bottom" && Waterlogged == true) {
                    return 8306;
                }

                if(Type == "bottom" && Waterlogged == false) {
                    return 8307;
                }

                if(Type == "double" && Waterlogged == true) {
                    return 8308;
                }

                if(Type == "double" && Waterlogged == false) {
                    return 8309;
                }

                return DefaultState;
            }

            set {
                if(value == 8304) {
                    Type = "top";
Waterlogged = true;
                }

                if(value == 8305) {
                    Type = "top";
Waterlogged = false;
                }

                if(value == 8306) {
                    Type = "bottom";
Waterlogged = true;
                }

                if(value == 8307) {
                    Type = "bottom";
Waterlogged = false;
                }

                if(value == 8308) {
                    Type = "double";
Waterlogged = true;
                }

                if(value == 8309) {
                    Type = "double";
Waterlogged = false;
                }

            }
        }

        public string Type { get; set; } = "bottom";
        public bool Waterlogged { get; set; } = false;

        public BlockOakSlab() {
            State = DefaultState;
        }

        public BlockOakSlab(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockOakSlab(string type, bool waterlogged) {
            Type = type;
            Waterlogged = waterlogged;
        }
    }
}