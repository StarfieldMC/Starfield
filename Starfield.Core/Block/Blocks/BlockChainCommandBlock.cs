// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:chain_command_block", 501, 9241, 9252, 9247)]
    public class BlockChainCommandBlock : BlockBase {

        public override ushort State {
            get {
                if(Conditional == true && Facing == "north") {
                    return 9241;
                }

                if(Conditional == true && Facing == "east") {
                    return 9242;
                }

                if(Conditional == true && Facing == "south") {
                    return 9243;
                }

                if(Conditional == true && Facing == "west") {
                    return 9244;
                }

                if(Conditional == true && Facing == "up") {
                    return 9245;
                }

                if(Conditional == true && Facing == "down") {
                    return 9246;
                }

                if(Conditional == false && Facing == "north") {
                    return 9247;
                }

                if(Conditional == false && Facing == "east") {
                    return 9248;
                }

                if(Conditional == false && Facing == "south") {
                    return 9249;
                }

                if(Conditional == false && Facing == "west") {
                    return 9250;
                }

                if(Conditional == false && Facing == "up") {
                    return 9251;
                }

                if(Conditional == false && Facing == "down") {
                    return 9252;
                }

                return DefaultState;
            }

            set {
                if(value == 9241) {
                    Conditional = true;
Facing = "north";
                }

                if(value == 9242) {
                    Conditional = true;
Facing = "east";
                }

                if(value == 9243) {
                    Conditional = true;
Facing = "south";
                }

                if(value == 9244) {
                    Conditional = true;
Facing = "west";
                }

                if(value == 9245) {
                    Conditional = true;
Facing = "up";
                }

                if(value == 9246) {
                    Conditional = true;
Facing = "down";
                }

                if(value == 9247) {
                    Conditional = false;
Facing = "north";
                }

                if(value == 9248) {
                    Conditional = false;
Facing = "east";
                }

                if(value == 9249) {
                    Conditional = false;
Facing = "south";
                }

                if(value == 9250) {
                    Conditional = false;
Facing = "west";
                }

                if(value == 9251) {
                    Conditional = false;
Facing = "up";
                }

                if(value == 9252) {
                    Conditional = false;
Facing = "down";
                }

            }
        }

        public bool Conditional { get; set; } = false;
        public string Facing { get; set; } = "north";

        public BlockChainCommandBlock() {
            State = DefaultState;
        }

        public BlockChainCommandBlock(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockChainCommandBlock(bool conditional, string facing) {
            Conditional = conditional;
            Facing = facing;
        }
    }
}