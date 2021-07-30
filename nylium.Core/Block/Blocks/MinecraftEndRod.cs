// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockEndRod : BlockBase {

        public override string Id { get { return "minecraft:end_rod"; } }

        public override ushort MinimumState { get { return 9062; } }
        public override ushort MaximumState { get { return 9067; } }
        public override ushort DefaultState { get { return 9066; } }

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 9062;
                }

                if(Facing == "east") {
                    return 9063;
                }

                if(Facing == "south") {
                    return 9064;
                }

                if(Facing == "west") {
                    return 9065;
                }

                if(Facing == "up") {
                    return 9066;
                }

                if(Facing == "down") {
                    return 9067;
                }

                return DefaultState;
            }

            set {
                if(value == 9062) {
                    Facing = "north";
                }

                if(value == 9063) {
                    Facing = "east";
                }

                if(value == 9064) {
                    Facing = "south";
                }

                if(value == 9065) {
                    Facing = "west";
                }

                if(value == 9066) {
                    Facing = "up";
                }

                if(value == 9067) {
                    Facing = "down";
                }

            }
        }

        public string Facing { get; set; } = "up";

        public BlockEndRod() {
            State = DefaultState;
        }

        public BlockEndRod(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockEndRod(string facing) {
            Facing = facing;
        }
    }
}