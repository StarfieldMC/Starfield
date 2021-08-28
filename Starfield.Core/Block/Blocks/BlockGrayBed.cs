// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:gray_bed", 82, 1161, 1176, 1164)]
    public class BlockGrayBed : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north" && Occupied == true && Part == "head") {
                    return 1161;
                }

                if(Facing == "north" && Occupied == true && Part == "foot") {
                    return 1162;
                }

                if(Facing == "north" && Occupied == false && Part == "head") {
                    return 1163;
                }

                if(Facing == "north" && Occupied == false && Part == "foot") {
                    return 1164;
                }

                if(Facing == "south" && Occupied == true && Part == "head") {
                    return 1165;
                }

                if(Facing == "south" && Occupied == true && Part == "foot") {
                    return 1166;
                }

                if(Facing == "south" && Occupied == false && Part == "head") {
                    return 1167;
                }

                if(Facing == "south" && Occupied == false && Part == "foot") {
                    return 1168;
                }

                if(Facing == "west" && Occupied == true && Part == "head") {
                    return 1169;
                }

                if(Facing == "west" && Occupied == true && Part == "foot") {
                    return 1170;
                }

                if(Facing == "west" && Occupied == false && Part == "head") {
                    return 1171;
                }

                if(Facing == "west" && Occupied == false && Part == "foot") {
                    return 1172;
                }

                if(Facing == "east" && Occupied == true && Part == "head") {
                    return 1173;
                }

                if(Facing == "east" && Occupied == true && Part == "foot") {
                    return 1174;
                }

                if(Facing == "east" && Occupied == false && Part == "head") {
                    return 1175;
                }

                if(Facing == "east" && Occupied == false && Part == "foot") {
                    return 1176;
                }

                return DefaultState;
            }

            set {
                if(value == 1161) {
                    Facing = "north";
Occupied = true;
Part = "head";
                }

                if(value == 1162) {
                    Facing = "north";
Occupied = true;
Part = "foot";
                }

                if(value == 1163) {
                    Facing = "north";
Occupied = false;
Part = "head";
                }

                if(value == 1164) {
                    Facing = "north";
Occupied = false;
Part = "foot";
                }

                if(value == 1165) {
                    Facing = "south";
Occupied = true;
Part = "head";
                }

                if(value == 1166) {
                    Facing = "south";
Occupied = true;
Part = "foot";
                }

                if(value == 1167) {
                    Facing = "south";
Occupied = false;
Part = "head";
                }

                if(value == 1168) {
                    Facing = "south";
Occupied = false;
Part = "foot";
                }

                if(value == 1169) {
                    Facing = "west";
Occupied = true;
Part = "head";
                }

                if(value == 1170) {
                    Facing = "west";
Occupied = true;
Part = "foot";
                }

                if(value == 1171) {
                    Facing = "west";
Occupied = false;
Part = "head";
                }

                if(value == 1172) {
                    Facing = "west";
Occupied = false;
Part = "foot";
                }

                if(value == 1173) {
                    Facing = "east";
Occupied = true;
Part = "head";
                }

                if(value == 1174) {
                    Facing = "east";
Occupied = true;
Part = "foot";
                }

                if(value == 1175) {
                    Facing = "east";
Occupied = false;
Part = "head";
                }

                if(value == 1176) {
                    Facing = "east";
Occupied = false;
Part = "foot";
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool Occupied { get; set; } = false;
        public string Part { get; set; } = "foot";

        public BlockGrayBed() {
            State = DefaultState;
        }

        public BlockGrayBed(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockGrayBed(string facing, bool occupied, string part) {
            Facing = facing;
            Occupied = occupied;
            Part = part;
        }
    }
}