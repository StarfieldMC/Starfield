// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:bubble_coral", 595, 9538, 9539, 9538)]
    public class BlockBubbleCoral : BlockBase {

        public override ushort State {
            get {
                if(Waterlogged == true) {
                    return 9538;
                }

                if(Waterlogged == false) {
                    return 9539;
                }

                return DefaultState;
            }

            set {
                if(value == 9538) {
                    Waterlogged = true;
                }

                if(value == 9539) {
                    Waterlogged = false;
                }

            }
        }

        public bool Waterlogged { get; set; } = true;

        public BlockBubbleCoral() {
            State = DefaultState;
        }

        public BlockBubbleCoral(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBubbleCoral(bool waterlogged) {
            Waterlogged = waterlogged;
        }
    }
}