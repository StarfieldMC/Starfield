// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockHornCoralWallFan : BlockBase {

        public override string Id { get { return "minecraft:horn_coral_wall_fan"; } }

        public override ushort MinimumState { get { return 9636; } }
        public override ushort MaximumState { get { return 9643; } }
        public override ushort DefaultState { get { return 9636; } }

        public override ushort State {
            get {
                if(Facing == "north" && Waterlogged == true) {
                    return 9636;
                }

                if(Facing == "north" && Waterlogged == false) {
                    return 9637;
                }

                if(Facing == "south" && Waterlogged == true) {
                    return 9638;
                }

                if(Facing == "south" && Waterlogged == false) {
                    return 9639;
                }

                if(Facing == "west" && Waterlogged == true) {
                    return 9640;
                }

                if(Facing == "west" && Waterlogged == false) {
                    return 9641;
                }

                if(Facing == "east" && Waterlogged == true) {
                    return 9642;
                }

                if(Facing == "east" && Waterlogged == false) {
                    return 9643;
                }

                return DefaultState;
            }

            set {
                if(value == 9636) {
                    Facing = "north";
Waterlogged = true;
                }

                if(value == 9637) {
                    Facing = "north";
Waterlogged = false;
                }

                if(value == 9638) {
                    Facing = "south";
Waterlogged = true;
                }

                if(value == 9639) {
                    Facing = "south";
Waterlogged = false;
                }

                if(value == 9640) {
                    Facing = "west";
Waterlogged = true;
                }

                if(value == 9641) {
                    Facing = "west";
Waterlogged = false;
                }

                if(value == 9642) {
                    Facing = "east";
Waterlogged = true;
                }

                if(value == 9643) {
                    Facing = "east";
Waterlogged = false;
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool Waterlogged { get; set; } = true;

        public BlockHornCoralWallFan() {
            State = DefaultState;
        }

        public BlockHornCoralWallFan(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockHornCoralWallFan(string facing, bool waterlogged) {
            Facing = facing;
            Waterlogged = waterlogged;
        }
    }
}