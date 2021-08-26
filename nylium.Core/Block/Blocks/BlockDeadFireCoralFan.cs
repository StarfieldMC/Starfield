// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:dead_fire_coral_fan", 601, 9550, 9551, 9550)]
    public class BlockDeadFireCoralFan : BlockBase {

        public override ushort State {
            get {
                if(Waterlogged == true) {
                    return 9550;
                }

                if(Waterlogged == false) {
                    return 9551;
                }

                return DefaultState;
            }

            set {
                if(value == 9550) {
                    Waterlogged = true;
                }

                if(value == 9551) {
                    Waterlogged = false;
                }

            }
        }

        public bool Waterlogged { get; set; } = true;

        public BlockDeadFireCoralFan() {
            State = DefaultState;
        }

        public BlockDeadFireCoralFan(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockDeadFireCoralFan(bool waterlogged) {
            Waterlogged = waterlogged;
        }
    }
}