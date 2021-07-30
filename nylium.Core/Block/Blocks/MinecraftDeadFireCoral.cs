// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockDeadFireCoral : BlockBase {

        public override string Id { get { return "minecraft:dead_fire_coral"; } }

        public override ushort MinimumState { get { return 9530; } }
        public override ushort MaximumState { get { return 9531; } }
        public override ushort DefaultState { get { return 9530; } }

        public override ushort State {
            get {
                if(Waterlogged == true) {
                    return 9530;
                }

                if(Waterlogged == false) {
                    return 9531;
                }

                return DefaultState;
            }

            set {
                if(value == 9530) {
                    Waterlogged = true;
                }

                if(value == 9531) {
                    Waterlogged = false;
                }

            }
        }

        public bool Waterlogged { get; set; } = true;

        public BlockDeadFireCoral() {
            State = DefaultState;
        }

        public BlockDeadFireCoral(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockDeadFireCoral(bool waterlogged) {
            Waterlogged = waterlogged;
        }
    }
}