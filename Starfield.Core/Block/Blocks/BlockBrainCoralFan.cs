// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:brain_coral_fan", 604, 9556, 9557, 9556)]
    public class BlockBrainCoralFan : BlockBase {

        public override ushort State {
            get {
                if(Waterlogged == true) {
                    return 9556;
                }

                if(Waterlogged == false) {
                    return 9557;
                }

                return DefaultState;
            }

            set {
                if(value == 9556) {
                    Waterlogged = true;
                }

                if(value == 9557) {
                    Waterlogged = false;
                }

            }
        }

        public bool Waterlogged { get; set; } = true;

        public BlockBrainCoralFan() {
            State = DefaultState;
        }

        public BlockBrainCoralFan(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBrainCoralFan(bool waterlogged) {
            Waterlogged = waterlogged;
        }
    }
}