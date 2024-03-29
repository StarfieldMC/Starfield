// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:fire_coral", 596, 9540, 9541, 9540)]
    public class BlockFireCoral : BlockBase {

        public override ushort State {
            get {
                if(Waterlogged == true) {
                    return 9540;
                }

                if(Waterlogged == false) {
                    return 9541;
                }

                return DefaultState;
            }

            set {
                if(value == 9540) {
                    Waterlogged = true;
                }

                if(value == 9541) {
                    Waterlogged = false;
                }

            }
        }

        public bool Waterlogged { get; set; } = true;

        public BlockFireCoral() {
            State = DefaultState;
        }

        public BlockFireCoral(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockFireCoral(bool waterlogged) {
            Waterlogged = waterlogged;
        }
    }
}