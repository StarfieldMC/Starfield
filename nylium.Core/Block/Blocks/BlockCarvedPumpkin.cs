// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:carved_pumpkin", 202, 4016, 4019, 4016)]
    public class BlockCarvedPumpkin : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 4016;
                }

                if(Facing == "south") {
                    return 4017;
                }

                if(Facing == "west") {
                    return 4018;
                }

                if(Facing == "east") {
                    return 4019;
                }

                return DefaultState;
            }

            set {
                if(value == 4016) {
                    Facing = "north";
                }

                if(value == 4017) {
                    Facing = "south";
                }

                if(value == 4018) {
                    Facing = "west";
                }

                if(value == 4019) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockCarvedPumpkin() {
            State = DefaultState;
        }

        public BlockCarvedPumpkin(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockCarvedPumpkin(string facing) {
            Facing = facing;
        }
    }
}