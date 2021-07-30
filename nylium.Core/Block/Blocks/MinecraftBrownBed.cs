// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockBrownBed : BlockBase {

        public override string Id { get { return "minecraft:brown_bed"; } }

        public override ushort MinimumState { get { return 1241; } }
        public override ushort MaximumState { get { return 1256; } }
        public override ushort DefaultState { get { return 1244; } }

        public override ushort State {
            get {
                if(Facing == "north" && Occupied == true && Part == "head") {
                    return 1241;
                }

                if(Facing == "north" && Occupied == true && Part == "foot") {
                    return 1242;
                }

                if(Facing == "north" && Occupied == false && Part == "head") {
                    return 1243;
                }

                if(Facing == "north" && Occupied == false && Part == "foot") {
                    return 1244;
                }

                if(Facing == "south" && Occupied == true && Part == "head") {
                    return 1245;
                }

                if(Facing == "south" && Occupied == true && Part == "foot") {
                    return 1246;
                }

                if(Facing == "south" && Occupied == false && Part == "head") {
                    return 1247;
                }

                if(Facing == "south" && Occupied == false && Part == "foot") {
                    return 1248;
                }

                if(Facing == "west" && Occupied == true && Part == "head") {
                    return 1249;
                }

                if(Facing == "west" && Occupied == true && Part == "foot") {
                    return 1250;
                }

                if(Facing == "west" && Occupied == false && Part == "head") {
                    return 1251;
                }

                if(Facing == "west" && Occupied == false && Part == "foot") {
                    return 1252;
                }

                if(Facing == "east" && Occupied == true && Part == "head") {
                    return 1253;
                }

                if(Facing == "east" && Occupied == true && Part == "foot") {
                    return 1254;
                }

                if(Facing == "east" && Occupied == false && Part == "head") {
                    return 1255;
                }

                if(Facing == "east" && Occupied == false && Part == "foot") {
                    return 1256;
                }

                return DefaultState;
            }

            set {
                if(value == 1241) {
                    Facing = "north";
Occupied = true;
Part = "head";
                }

                if(value == 1242) {
                    Facing = "north";
Occupied = true;
Part = "foot";
                }

                if(value == 1243) {
                    Facing = "north";
Occupied = false;
Part = "head";
                }

                if(value == 1244) {
                    Facing = "north";
Occupied = false;
Part = "foot";
                }

                if(value == 1245) {
                    Facing = "south";
Occupied = true;
Part = "head";
                }

                if(value == 1246) {
                    Facing = "south";
Occupied = true;
Part = "foot";
                }

                if(value == 1247) {
                    Facing = "south";
Occupied = false;
Part = "head";
                }

                if(value == 1248) {
                    Facing = "south";
Occupied = false;
Part = "foot";
                }

                if(value == 1249) {
                    Facing = "west";
Occupied = true;
Part = "head";
                }

                if(value == 1250) {
                    Facing = "west";
Occupied = true;
Part = "foot";
                }

                if(value == 1251) {
                    Facing = "west";
Occupied = false;
Part = "head";
                }

                if(value == 1252) {
                    Facing = "west";
Occupied = false;
Part = "foot";
                }

                if(value == 1253) {
                    Facing = "east";
Occupied = true;
Part = "head";
                }

                if(value == 1254) {
                    Facing = "east";
Occupied = true;
Part = "foot";
                }

                if(value == 1255) {
                    Facing = "east";
Occupied = false;
Part = "head";
                }

                if(value == 1256) {
                    Facing = "east";
Occupied = false;
Part = "foot";
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool Occupied { get; set; } = false;
        public string Part { get; set; } = "foot";

        public BlockBrownBed() {
            State = DefaultState;
        }

        public BlockBrownBed(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBrownBed(string facing, bool occupied, string part) {
            Facing = facing;
            Occupied = occupied;
            Part = part;
        }
    }
}