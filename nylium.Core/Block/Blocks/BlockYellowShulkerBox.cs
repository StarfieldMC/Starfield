// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:yellow_shulker_box", 514, 9306, 9311, 9310)]
    public class BlockYellowShulkerBox : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 9306;
                }

                if(Facing == "east") {
                    return 9307;
                }

                if(Facing == "south") {
                    return 9308;
                }

                if(Facing == "west") {
                    return 9309;
                }

                if(Facing == "up") {
                    return 9310;
                }

                if(Facing == "down") {
                    return 9311;
                }

                return DefaultState;
            }

            set {
                if(value == 9306) {
                    Facing = "north";
                }

                if(value == 9307) {
                    Facing = "east";
                }

                if(value == 9308) {
                    Facing = "south";
                }

                if(value == 9309) {
                    Facing = "west";
                }

                if(value == 9310) {
                    Facing = "up";
                }

                if(value == 9311) {
                    Facing = "down";
                }

            }
        }

        public string Facing { get; set; } = "up";

        public BlockYellowShulkerBox() {
            State = DefaultState;
        }

        public BlockYellowShulkerBox(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockYellowShulkerBox(string facing) {
            Facing = facing;
        }
    }
}