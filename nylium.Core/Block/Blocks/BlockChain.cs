// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:chain", 242, 4729, 4734, 4732)]
    public class BlockChain : BlockBase {

        public override ushort State {
            get {
                if(Axis == "x" && Waterlogged == true) {
                    return 4729;
                }

                if(Axis == "x" && Waterlogged == false) {
                    return 4730;
                }

                if(Axis == "y" && Waterlogged == true) {
                    return 4731;
                }

                if(Axis == "y" && Waterlogged == false) {
                    return 4732;
                }

                if(Axis == "z" && Waterlogged == true) {
                    return 4733;
                }

                if(Axis == "z" && Waterlogged == false) {
                    return 4734;
                }

                return DefaultState;
            }

            set {
                if(value == 4729) {
                    Axis = "x";
Waterlogged = true;
                }

                if(value == 4730) {
                    Axis = "x";
Waterlogged = false;
                }

                if(value == 4731) {
                    Axis = "y";
Waterlogged = true;
                }

                if(value == 4732) {
                    Axis = "y";
Waterlogged = false;
                }

                if(value == 4733) {
                    Axis = "z";
Waterlogged = true;
                }

                if(value == 4734) {
                    Axis = "z";
Waterlogged = false;
                }

            }
        }

        public string Axis { get; set; } = "y";
        public bool Waterlogged { get; set; } = false;

        public BlockChain() {
            State = DefaultState;
        }

        public BlockChain(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockChain(string axis, bool waterlogged) {
            Axis = axis;
            Waterlogged = waterlogged;
        }
    }
}