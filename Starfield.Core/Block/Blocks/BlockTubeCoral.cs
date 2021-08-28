// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:tube_coral", 593, 9534, 9535, 9534)]
    public class BlockTubeCoral : BlockBase {

        public override ushort State {
            get {
                if(Waterlogged == true) {
                    return 9534;
                }

                if(Waterlogged == false) {
                    return 9535;
                }

                return DefaultState;
            }

            set {
                if(value == 9534) {
                    Waterlogged = true;
                }

                if(value == 9535) {
                    Waterlogged = false;
                }

            }
        }

        public bool Waterlogged { get; set; } = true;

        public BlockTubeCoral() {
            State = DefaultState;
        }

        public BlockTubeCoral(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockTubeCoral(bool waterlogged) {
            Waterlogged = waterlogged;
        }
    }
}