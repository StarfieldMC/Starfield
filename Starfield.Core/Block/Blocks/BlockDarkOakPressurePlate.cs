// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:dark_oak_pressure_plate", 179, 3883, 3884, 3884)]
    public class BlockDarkOakPressurePlate : BlockBase {

        public override ushort State {
            get {
                if(Powered == true) {
                    return 3883;
                }

                if(Powered == false) {
                    return 3884;
                }

                return DefaultState;
            }

            set {
                if(value == 3883) {
                    Powered = true;
                }

                if(value == 3884) {
                    Powered = false;
                }

            }
        }

        public bool Powered { get; set; } = false;

        public BlockDarkOakPressurePlate() {
            State = DefaultState;
        }

        public BlockDarkOakPressurePlate(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockDarkOakPressurePlate(bool powered) {
            Powered = powered;
        }
    }
}