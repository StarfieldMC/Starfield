// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockCommandBlock : BlockBase {

        public override string Id { get { return "minecraft:command_block"; } }

        public override ushort MinimumState { get { return 5648; } }
        public override ushort MaximumState { get { return 5659; } }
        public override ushort DefaultState { get { return 5654; } }

        public override ushort State {
            get {
                if(Conditional == true && Facing == "north") {
                    return 5648;
                }

                if(Conditional == true && Facing == "east") {
                    return 5649;
                }

                if(Conditional == true && Facing == "south") {
                    return 5650;
                }

                if(Conditional == true && Facing == "west") {
                    return 5651;
                }

                if(Conditional == true && Facing == "up") {
                    return 5652;
                }

                if(Conditional == true && Facing == "down") {
                    return 5653;
                }

                if(Conditional == false && Facing == "north") {
                    return 5654;
                }

                if(Conditional == false && Facing == "east") {
                    return 5655;
                }

                if(Conditional == false && Facing == "south") {
                    return 5656;
                }

                if(Conditional == false && Facing == "west") {
                    return 5657;
                }

                if(Conditional == false && Facing == "up") {
                    return 5658;
                }

                if(Conditional == false && Facing == "down") {
                    return 5659;
                }

                return DefaultState;
            }

            set {
                if(value == 5648) {
                    Conditional = true;
Facing = "north";
                }

                if(value == 5649) {
                    Conditional = true;
Facing = "east";
                }

                if(value == 5650) {
                    Conditional = true;
Facing = "south";
                }

                if(value == 5651) {
                    Conditional = true;
Facing = "west";
                }

                if(value == 5652) {
                    Conditional = true;
Facing = "up";
                }

                if(value == 5653) {
                    Conditional = true;
Facing = "down";
                }

                if(value == 5654) {
                    Conditional = false;
Facing = "north";
                }

                if(value == 5655) {
                    Conditional = false;
Facing = "east";
                }

                if(value == 5656) {
                    Conditional = false;
Facing = "south";
                }

                if(value == 5657) {
                    Conditional = false;
Facing = "west";
                }

                if(value == 5658) {
                    Conditional = false;
Facing = "up";
                }

                if(value == 5659) {
                    Conditional = false;
Facing = "down";
                }

            }
        }

        public bool Conditional { get; set; } = false;
        public string Facing { get; set; } = "north";

        public BlockCommandBlock() {
            State = DefaultState;
        }

        public BlockCommandBlock(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockCommandBlock(bool conditional, string facing) {
            Conditional = conditional;
            Facing = facing;
        }
    }
}