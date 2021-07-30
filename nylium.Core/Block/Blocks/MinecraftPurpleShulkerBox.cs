// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockPurpleShulkerBox : BlockBase {

        public override string Id { get { return "minecraft:purple_shulker_box"; } }

        public override ushort MinimumState { get { return 9342; } }
        public override ushort MaximumState { get { return 9347; } }
        public override ushort DefaultState { get { return 9346; } }

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 9342;
                }

                if(Facing == "east") {
                    return 9343;
                }

                if(Facing == "south") {
                    return 9344;
                }

                if(Facing == "west") {
                    return 9345;
                }

                if(Facing == "up") {
                    return 9346;
                }

                if(Facing == "down") {
                    return 9347;
                }

                return DefaultState;
            }

            set {
                if(value == 9342) {
                    Facing = "north";
                }

                if(value == 9343) {
                    Facing = "east";
                }

                if(value == 9344) {
                    Facing = "south";
                }

                if(value == 9345) {
                    Facing = "west";
                }

                if(value == 9346) {
                    Facing = "up";
                }

                if(value == 9347) {
                    Facing = "down";
                }

            }
        }

        public string Facing { get; set; } = "up";

        public BlockPurpleShulkerBox() {
            State = DefaultState;
        }

        public BlockPurpleShulkerBox(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockPurpleShulkerBox(string facing) {
            Facing = facing;
        }
    }
}