// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockBrainCoralWallFan : BlockBase {

        public override string Id { get { return "minecraft:brain_coral_wall_fan"; } }

        public override ushort MinimumState { get { return 9612; } }
        public override ushort MaximumState { get { return 9619; } }
        public override ushort DefaultState { get { return 9612; } }

        public override ushort State {
            get {
                if(Facing == "north" && Waterlogged == true) {
                    return 9612;
                }

                if(Facing == "north" && Waterlogged == false) {
                    return 9613;
                }

                if(Facing == "south" && Waterlogged == true) {
                    return 9614;
                }

                if(Facing == "south" && Waterlogged == false) {
                    return 9615;
                }

                if(Facing == "west" && Waterlogged == true) {
                    return 9616;
                }

                if(Facing == "west" && Waterlogged == false) {
                    return 9617;
                }

                if(Facing == "east" && Waterlogged == true) {
                    return 9618;
                }

                if(Facing == "east" && Waterlogged == false) {
                    return 9619;
                }

                return DefaultState;
            }

            set {
                if(value == 9612) {
                    Facing = "north";
Waterlogged = true;
                }

                if(value == 9613) {
                    Facing = "north";
Waterlogged = false;
                }

                if(value == 9614) {
                    Facing = "south";
Waterlogged = true;
                }

                if(value == 9615) {
                    Facing = "south";
Waterlogged = false;
                }

                if(value == 9616) {
                    Facing = "west";
Waterlogged = true;
                }

                if(value == 9617) {
                    Facing = "west";
Waterlogged = false;
                }

                if(value == 9618) {
                    Facing = "east";
Waterlogged = true;
                }

                if(value == 9619) {
                    Facing = "east";
Waterlogged = false;
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool Waterlogged { get; set; } = true;

        public BlockBrainCoralWallFan() {
            State = DefaultState;
        }

        public BlockBrainCoralWallFan(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBrainCoralWallFan(string facing, bool waterlogged) {
            Facing = facing;
            Waterlogged = waterlogged;
        }
    }
}