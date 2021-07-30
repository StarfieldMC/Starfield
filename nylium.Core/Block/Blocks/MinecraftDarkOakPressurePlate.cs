// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockDarkOakPressurePlate : BlockBase {

        public override string Id { get { return "minecraft:dark_oak_pressure_plate"; } }

        public override ushort MinimumState { get { return 3883; } }
        public override ushort MaximumState { get { return 3884; } }
        public override ushort DefaultState { get { return 3884; } }

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

        public BlockDarkOakPressurePlate(ushort state) {
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