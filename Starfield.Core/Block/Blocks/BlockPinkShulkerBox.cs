// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:pink_shulker_box", 516, 9318, 9323, 9322)]
    public class BlockPinkShulkerBox : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 9318;
                }

                if(Facing == "east") {
                    return 9319;
                }

                if(Facing == "south") {
                    return 9320;
                }

                if(Facing == "west") {
                    return 9321;
                }

                if(Facing == "up") {
                    return 9322;
                }

                if(Facing == "down") {
                    return 9323;
                }

                return DefaultState;
            }

            set {
                if(value == 9318) {
                    Facing = "north";
                }

                if(value == 9319) {
                    Facing = "east";
                }

                if(value == 9320) {
                    Facing = "south";
                }

                if(value == 9321) {
                    Facing = "west";
                }

                if(value == 9322) {
                    Facing = "up";
                }

                if(value == 9323) {
                    Facing = "down";
                }

            }
        }

        public string Facing { get; set; } = "up";

        public BlockPinkShulkerBox() {
            State = DefaultState;
        }

        public BlockPinkShulkerBox(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockPinkShulkerBox(string facing) {
            Facing = facing;
        }
    }
}