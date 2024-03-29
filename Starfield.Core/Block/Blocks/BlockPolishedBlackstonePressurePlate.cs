// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:polished_blackstone_pressure_plate", 757, 16759, 16760, 16760)]
    public class BlockPolishedBlackstonePressurePlate : BlockBase {

        public override ushort State {
            get {
                if(Powered == true) {
                    return 16759;
                }

                if(Powered == false) {
                    return 16760;
                }

                return DefaultState;
            }

            set {
                if(value == 16759) {
                    Powered = true;
                }

                if(value == 16760) {
                    Powered = false;
                }

            }
        }

        public bool Powered { get; set; } = false;

        public BlockPolishedBlackstonePressurePlate() {
            State = DefaultState;
        }

        public BlockPolishedBlackstonePressurePlate(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockPolishedBlackstonePressurePlate(bool powered) {
            Powered = powered;
        }
    }
}