// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockTubeCoral : BlockBase {

        public override string Id { get { return "minecraft:tube_coral"; } }

        public override ushort MinimumState { get { return 9534; } }
        public override ushort MaximumState { get { return 9535; } }
        public override ushort DefaultState { get { return 9534; } }

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

        public BlockTubeCoral(ushort state) {
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