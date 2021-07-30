// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockGrayShulkerBox : BlockBase {

        public override string Id { get { return "minecraft:gray_shulker_box"; } }

        public override ushort MinimumState { get { return 9324; } }
        public override ushort MaximumState { get { return 9329; } }
        public override ushort DefaultState { get { return 9328; } }

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 9324;
                }

                if(Facing == "east") {
                    return 9325;
                }

                if(Facing == "south") {
                    return 9326;
                }

                if(Facing == "west") {
                    return 9327;
                }

                if(Facing == "up") {
                    return 9328;
                }

                if(Facing == "down") {
                    return 9329;
                }

                return DefaultState;
            }

            set {
                if(value == 9324) {
                    Facing = "north";
                }

                if(value == 9325) {
                    Facing = "east";
                }

                if(value == 9326) {
                    Facing = "south";
                }

                if(value == 9327) {
                    Facing = "west";
                }

                if(value == 9328) {
                    Facing = "up";
                }

                if(value == 9329) {
                    Facing = "down";
                }

            }
        }

        public string Facing { get; set; } = "up";

        public BlockGrayShulkerBox() {
            State = DefaultState;
        }

        public BlockGrayShulkerBox(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockGrayShulkerBox(string facing) {
            Facing = facing;
        }
    }
}