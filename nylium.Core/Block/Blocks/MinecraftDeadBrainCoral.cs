// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockDeadBrainCoral : BlockBase {

        public override string Id { get { return "minecraft:dead_brain_coral"; } }

        public override ushort MinimumState { get { return 9526; } }
        public override ushort MaximumState { get { return 9527; } }
        public override ushort DefaultState { get { return 9526; } }

        public override ushort State {
            get {
                if(Waterlogged == true) {
                    return 9526;
                }

                if(Waterlogged == false) {
                    return 9527;
                }

                return DefaultState;
            }

            set {
                if(value == 9526) {
                    Waterlogged = true;
                }

                if(value == 9527) {
                    Waterlogged = false;
                }

            }
        }

        public bool Waterlogged { get; set; } = true;

        public BlockDeadBrainCoral() {
            State = DefaultState;
        }

        public BlockDeadBrainCoral(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockDeadBrainCoral(bool waterlogged) {
            Waterlogged = waterlogged;
        }
    }
}