// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:orange_shulker_box", 511, 9288, 9293, 9292)]
    public class BlockOrangeShulkerBox : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 9288;
                }

                if(Facing == "east") {
                    return 9289;
                }

                if(Facing == "south") {
                    return 9290;
                }

                if(Facing == "west") {
                    return 9291;
                }

                if(Facing == "up") {
                    return 9292;
                }

                if(Facing == "down") {
                    return 9293;
                }

                return DefaultState;
            }

            set {
                if(value == 9288) {
                    Facing = "north";
                }

                if(value == 9289) {
                    Facing = "east";
                }

                if(value == 9290) {
                    Facing = "south";
                }

                if(value == 9291) {
                    Facing = "west";
                }

                if(value == 9292) {
                    Facing = "up";
                }

                if(value == 9293) {
                    Facing = "down";
                }

            }
        }

        public string Facing { get; set; } = "up";

        public BlockOrangeShulkerBox() {
            State = DefaultState;
        }

        public BlockOrangeShulkerBox(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockOrangeShulkerBox(string facing) {
            Facing = facing;
        }
    }
}