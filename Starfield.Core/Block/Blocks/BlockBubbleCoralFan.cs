// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:bubble_coral_fan", 605, 9558, 9559, 9558)]
    public class BlockBubbleCoralFan : BlockBase {

        public override ushort State {
            get {
                if(Waterlogged == true) {
                    return 9558;
                }

                if(Waterlogged == false) {
                    return 9559;
                }

                return DefaultState;
            }

            set {
                if(value == 9558) {
                    Waterlogged = true;
                }

                if(value == 9559) {
                    Waterlogged = false;
                }

            }
        }

        public bool Waterlogged { get; set; } = true;

        public BlockBubbleCoralFan() {
            State = DefaultState;
        }

        public BlockBubbleCoralFan(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBubbleCoralFan(bool waterlogged) {
            Waterlogged = waterlogged;
        }
    }
}