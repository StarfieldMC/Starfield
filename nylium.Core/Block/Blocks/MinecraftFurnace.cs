// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockFurnace : BlockBase {

        public override string Id { get { return "minecraft:furnace"; } }

        public override ushort MinimumState { get { return 3373; } }
        public override ushort MaximumState { get { return 3380; } }
        public override ushort DefaultState { get { return 3374; } }

        public override ushort State {
            get {
                if(Facing == "north" && Lit == true) {
                    return 3373;
                }

                if(Facing == "north" && Lit == false) {
                    return 3374;
                }

                if(Facing == "south" && Lit == true) {
                    return 3375;
                }

                if(Facing == "south" && Lit == false) {
                    return 3376;
                }

                if(Facing == "west" && Lit == true) {
                    return 3377;
                }

                if(Facing == "west" && Lit == false) {
                    return 3378;
                }

                if(Facing == "east" && Lit == true) {
                    return 3379;
                }

                if(Facing == "east" && Lit == false) {
                    return 3380;
                }

                return DefaultState;
            }

            set {
                if(value == 3373) {
                    Facing = "north";
Lit = true;
                }

                if(value == 3374) {
                    Facing = "north";
Lit = false;
                }

                if(value == 3375) {
                    Facing = "south";
Lit = true;
                }

                if(value == 3376) {
                    Facing = "south";
Lit = false;
                }

                if(value == 3377) {
                    Facing = "west";
Lit = true;
                }

                if(value == 3378) {
                    Facing = "west";
Lit = false;
                }

                if(value == 3379) {
                    Facing = "east";
Lit = true;
                }

                if(value == 3380) {
                    Facing = "east";
Lit = false;
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool Lit { get; set; } = false;

        public BlockFurnace() {
            State = DefaultState;
        }

        public BlockFurnace(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockFurnace(string facing, bool lit) {
            Facing = facing;
            Lit = lit;
        }
    }
}