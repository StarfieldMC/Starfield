// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockLightGrayShulkerBox : BlockBase {

        public override string Id { get { return "minecraft:light_gray_shulker_box"; } }

        public override ushort MinimumState { get { return 9330; } }
        public override ushort MaximumState { get { return 9335; } }
        public override ushort DefaultState { get { return 9334; } }

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 9330;
                }

                if(Facing == "east") {
                    return 9331;
                }

                if(Facing == "south") {
                    return 9332;
                }

                if(Facing == "west") {
                    return 9333;
                }

                if(Facing == "up") {
                    return 9334;
                }

                if(Facing == "down") {
                    return 9335;
                }

                return DefaultState;
            }

            set {
                if(value == 9330) {
                    Facing = "north";
                }

                if(value == 9331) {
                    Facing = "east";
                }

                if(value == 9332) {
                    Facing = "south";
                }

                if(value == 9333) {
                    Facing = "west";
                }

                if(value == 9334) {
                    Facing = "up";
                }

                if(value == 9335) {
                    Facing = "down";
                }

            }
        }

        public string Facing { get; set; } = "up";

        public BlockLightGrayShulkerBox() {
            State = DefaultState;
        }

        public BlockLightGrayShulkerBox(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockLightGrayShulkerBox(string facing) {
            Facing = facing;
        }
    }
}