// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:attached_pumpkin_stem", 245, 4768, 4771, 4768)]
    public class BlockAttachedPumpkinStem : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 4768;
                }

                if(Facing == "south") {
                    return 4769;
                }

                if(Facing == "west") {
                    return 4770;
                }

                if(Facing == "east") {
                    return 4771;
                }

                return DefaultState;
            }

            set {
                if(value == 4768) {
                    Facing = "north";
                }

                if(value == 4769) {
                    Facing = "south";
                }

                if(value == 4770) {
                    Facing = "west";
                }

                if(value == 4771) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockAttachedPumpkinStem() {
            State = DefaultState;
        }

        public BlockAttachedPumpkinStem(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockAttachedPumpkinStem(string facing) {
            Facing = facing;
        }
    }
}