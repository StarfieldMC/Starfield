// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:tube_coral_fan", 603, 9554, 9555, 9554)]
    public class BlockTubeCoralFan : BlockBase {

        public override ushort State {
            get {
                if(Waterlogged == true) {
                    return 9554;
                }

                if(Waterlogged == false) {
                    return 9555;
                }

                return DefaultState;
            }

            set {
                if(value == 9554) {
                    Waterlogged = true;
                }

                if(value == 9555) {
                    Waterlogged = false;
                }

            }
        }

        public bool Waterlogged { get; set; } = true;

        public BlockTubeCoralFan() {
            State = DefaultState;
        }

        public BlockTubeCoralFan(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockTubeCoralFan(bool waterlogged) {
            Waterlogged = waterlogged;
        }
    }
}