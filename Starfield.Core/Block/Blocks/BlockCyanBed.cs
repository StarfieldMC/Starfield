// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:cyan_bed", 84, 1193, 1208, 1196)]
    public class BlockCyanBed : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north" && Occupied == true && Part == "head") {
                    return 1193;
                }

                if(Facing == "north" && Occupied == true && Part == "foot") {
                    return 1194;
                }

                if(Facing == "north" && Occupied == false && Part == "head") {
                    return 1195;
                }

                if(Facing == "north" && Occupied == false && Part == "foot") {
                    return 1196;
                }

                if(Facing == "south" && Occupied == true && Part == "head") {
                    return 1197;
                }

                if(Facing == "south" && Occupied == true && Part == "foot") {
                    return 1198;
                }

                if(Facing == "south" && Occupied == false && Part == "head") {
                    return 1199;
                }

                if(Facing == "south" && Occupied == false && Part == "foot") {
                    return 1200;
                }

                if(Facing == "west" && Occupied == true && Part == "head") {
                    return 1201;
                }

                if(Facing == "west" && Occupied == true && Part == "foot") {
                    return 1202;
                }

                if(Facing == "west" && Occupied == false && Part == "head") {
                    return 1203;
                }

                if(Facing == "west" && Occupied == false && Part == "foot") {
                    return 1204;
                }

                if(Facing == "east" && Occupied == true && Part == "head") {
                    return 1205;
                }

                if(Facing == "east" && Occupied == true && Part == "foot") {
                    return 1206;
                }

                if(Facing == "east" && Occupied == false && Part == "head") {
                    return 1207;
                }

                if(Facing == "east" && Occupied == false && Part == "foot") {
                    return 1208;
                }

                return DefaultState;
            }

            set {
                if(value == 1193) {
                    Facing = "north";
Occupied = true;
Part = "head";
                }

                if(value == 1194) {
                    Facing = "north";
Occupied = true;
Part = "foot";
                }

                if(value == 1195) {
                    Facing = "north";
Occupied = false;
Part = "head";
                }

                if(value == 1196) {
                    Facing = "north";
Occupied = false;
Part = "foot";
                }

                if(value == 1197) {
                    Facing = "south";
Occupied = true;
Part = "head";
                }

                if(value == 1198) {
                    Facing = "south";
Occupied = true;
Part = "foot";
                }

                if(value == 1199) {
                    Facing = "south";
Occupied = false;
Part = "head";
                }

                if(value == 1200) {
                    Facing = "south";
Occupied = false;
Part = "foot";
                }

                if(value == 1201) {
                    Facing = "west";
Occupied = true;
Part = "head";
                }

                if(value == 1202) {
                    Facing = "west";
Occupied = true;
Part = "foot";
                }

                if(value == 1203) {
                    Facing = "west";
Occupied = false;
Part = "head";
                }

                if(value == 1204) {
                    Facing = "west";
Occupied = false;
Part = "foot";
                }

                if(value == 1205) {
                    Facing = "east";
Occupied = true;
Part = "head";
                }

                if(value == 1206) {
                    Facing = "east";
Occupied = true;
Part = "foot";
                }

                if(value == 1207) {
                    Facing = "east";
Occupied = false;
Part = "head";
                }

                if(value == 1208) {
                    Facing = "east";
Occupied = false;
Part = "foot";
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool Occupied { get; set; } = false;
        public string Part { get; set; } = "foot";

        public BlockCyanBed() {
            State = DefaultState;
        }

        public BlockCyanBed(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockCyanBed(string facing, bool occupied, string part) {
            Facing = facing;
            Occupied = occupied;
            Part = part;
        }
    }
}