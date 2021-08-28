// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:dead_tube_coral_fan", 598, 9544, 9545, 9544)]
    public class BlockDeadTubeCoralFan : BlockBase {

        public override ushort State {
            get {
                if(Waterlogged == true) {
                    return 9544;
                }

                if(Waterlogged == false) {
                    return 9545;
                }

                return DefaultState;
            }

            set {
                if(value == 9544) {
                    Waterlogged = true;
                }

                if(value == 9545) {
                    Waterlogged = false;
                }

            }
        }

        public bool Waterlogged { get; set; } = true;

        public BlockDeadTubeCoralFan() {
            State = DefaultState;
        }

        public BlockDeadTubeCoralFan(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockDeadTubeCoralFan(bool waterlogged) {
            Waterlogged = waterlogged;
        }
    }
}