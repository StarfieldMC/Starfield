// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:spruce_pressure_plate", 175, 3875, 3876, 3876)]
    public class BlockSprucePressurePlate : BlockBase {

        public override ushort State {
            get {
                if(Powered == true) {
                    return 3875;
                }

                if(Powered == false) {
                    return 3876;
                }

                return DefaultState;
            }

            set {
                if(value == 3875) {
                    Powered = true;
                }

                if(value == 3876) {
                    Powered = false;
                }

            }
        }

        public bool Powered { get; set; } = false;

        public BlockSprucePressurePlate() {
            State = DefaultState;
        }

        public BlockSprucePressurePlate(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockSprucePressurePlate(bool powered) {
            Powered = powered;
        }
    }
}