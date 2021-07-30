// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockWarpedPressurePlate : BlockBase {

        public override string Id { get { return "minecraft:warped_pressure_plate"; } }

        public override ushort MinimumState { get { return 15069; } }
        public override ushort MaximumState { get { return 15070; } }
        public override ushort DefaultState { get { return 15070; } }

        public override ushort State {
            get {
                if(Powered == true) {
                    return 15069;
                }

                if(Powered == false) {
                    return 15070;
                }

                return DefaultState;
            }

            set {
                if(value == 15069) {
                    Powered = true;
                }

                if(value == 15070) {
                    Powered = false;
                }

            }
        }

        public bool Powered { get; set; } = false;

        public BlockWarpedPressurePlate() {
            State = DefaultState;
        }

        public BlockWarpedPressurePlate(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockWarpedPressurePlate(bool powered) {
            Powered = powered;
        }
    }
}