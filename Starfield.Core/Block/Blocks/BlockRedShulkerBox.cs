// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:red_shulker_box", 524, 9366, 9371, 9370)]
    public class BlockRedShulkerBox : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 9366;
                }

                if(Facing == "east") {
                    return 9367;
                }

                if(Facing == "south") {
                    return 9368;
                }

                if(Facing == "west") {
                    return 9369;
                }

                if(Facing == "up") {
                    return 9370;
                }

                if(Facing == "down") {
                    return 9371;
                }

                return DefaultState;
            }

            set {
                if(value == 9366) {
                    Facing = "north";
                }

                if(value == 9367) {
                    Facing = "east";
                }

                if(value == 9368) {
                    Facing = "south";
                }

                if(value == 9369) {
                    Facing = "west";
                }

                if(value == 9370) {
                    Facing = "up";
                }

                if(value == 9371) {
                    Facing = "down";
                }

            }
        }

        public string Facing { get; set; } = "up";

        public BlockRedShulkerBox() {
            State = DefaultState;
        }

        public BlockRedShulkerBox(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockRedShulkerBox(string facing) {
            Facing = facing;
        }
    }
}