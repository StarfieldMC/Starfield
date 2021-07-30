// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockFireCoral : BlockBase {

        public override string Id { get { return "minecraft:fire_coral"; } }

        public override ushort MinimumState { get { return 9540; } }
        public override ushort MaximumState { get { return 9541; } }
        public override ushort DefaultState { get { return 9540; } }

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

        public BlockFireCoral(ushort state) {
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