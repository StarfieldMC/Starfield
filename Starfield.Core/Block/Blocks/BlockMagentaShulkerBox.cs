// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:magenta_shulker_box", 512, 9294, 9299, 9298)]
    public class BlockMagentaShulkerBox : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 9294;
                }

                if(Facing == "east") {
                    return 9295;
                }

                if(Facing == "south") {
                    return 9296;
                }

                if(Facing == "west") {
                    return 9297;
                }

                if(Facing == "up") {
                    return 9298;
                }

                if(Facing == "down") {
                    return 9299;
                }

                return DefaultState;
            }

            set {
                if(value == 9294) {
                    Facing = "north";
                }

                if(value == 9295) {
                    Facing = "east";
                }

                if(value == 9296) {
                    Facing = "south";
                }

                if(value == 9297) {
                    Facing = "west";
                }

                if(value == 9298) {
                    Facing = "up";
                }

                if(value == 9299) {
                    Facing = "down";
                }

            }
        }

        public string Facing { get; set; } = "up";

        public BlockMagentaShulkerBox() {
            State = DefaultState;
        }

        public BlockMagentaShulkerBox(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockMagentaShulkerBox(string facing) {
            Facing = facing;
        }
    }
}