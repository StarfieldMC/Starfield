// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:oak_pressure_plate", 174, 3873, 3874, 3874)]
    public class BlockOakPressurePlate : BlockBase {

        public override ushort State {
            get {
                if(Powered == true) {
                    return 3873;
                }

                if(Powered == false) {
                    return 3874;
                }

                return DefaultState;
            }

            set {
                if(value == 3873) {
                    Powered = true;
                }

                if(value == 3874) {
                    Powered = false;
                }

            }
        }

        public bool Powered { get; set; } = false;

        public BlockOakPressurePlate() {
            State = DefaultState;
        }

        public BlockOakPressurePlate(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockOakPressurePlate(bool powered) {
            Powered = powered;
        }
    }
}