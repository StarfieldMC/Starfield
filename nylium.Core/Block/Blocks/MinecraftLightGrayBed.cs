// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockLightGrayBed : BlockBase {

        public override string Id { get { return "minecraft:light_gray_bed"; } }

        public override ushort MinimumState { get { return 1177; } }
        public override ushort MaximumState { get { return 1192; } }
        public override ushort DefaultState { get { return 1180; } }

        public override ushort State {
            get {
                if(Facing == "north" && Occupied == true && Part == "head") {
                    return 1177;
                }

                if(Facing == "north" && Occupied == true && Part == "foot") {
                    return 1178;
                }

                if(Facing == "north" && Occupied == false && Part == "head") {
                    return 1179;
                }

                if(Facing == "north" && Occupied == false && Part == "foot") {
                    return 1180;
                }

                if(Facing == "south" && Occupied == true && Part == "head") {
                    return 1181;
                }

                if(Facing == "south" && Occupied == true && Part == "foot") {
                    return 1182;
                }

                if(Facing == "south" && Occupied == false && Part == "head") {
                    return 1183;
                }

                if(Facing == "south" && Occupied == false && Part == "foot") {
                    return 1184;
                }

                if(Facing == "west" && Occupied == true && Part == "head") {
                    return 1185;
                }

                if(Facing == "west" && Occupied == true && Part == "foot") {
                    return 1186;
                }

                if(Facing == "west" && Occupied == false && Part == "head") {
                    return 1187;
                }

                if(Facing == "west" && Occupied == false && Part == "foot") {
                    return 1188;
                }

                if(Facing == "east" && Occupied == true && Part == "head") {
                    return 1189;
                }

                if(Facing == "east" && Occupied == true && Part == "foot") {
                    return 1190;
                }

                if(Facing == "east" && Occupied == false && Part == "head") {
                    return 1191;
                }

                if(Facing == "east" && Occupied == false && Part == "foot") {
                    return 1192;
                }

                return DefaultState;
            }

            set {
                if(value == 1177) {
                    Facing = "north";
Occupied = true;
Part = "head";
                }

                if(value == 1178) {
                    Facing = "north";
Occupied = true;
Part = "foot";
                }

                if(value == 1179) {
                    Facing = "north";
Occupied = false;
Part = "head";
                }

                if(value == 1180) {
                    Facing = "north";
Occupied = false;
Part = "foot";
                }

                if(value == 1181) {
                    Facing = "south";
Occupied = true;
Part = "head";
                }

                if(value == 1182) {
                    Facing = "south";
Occupied = true;
Part = "foot";
                }

                if(value == 1183) {
                    Facing = "south";
Occupied = false;
Part = "head";
                }

                if(value == 1184) {
                    Facing = "south";
Occupied = false;
Part = "foot";
                }

                if(value == 1185) {
                    Facing = "west";
Occupied = true;
Part = "head";
                }

                if(value == 1186) {
                    Facing = "west";
Occupied = true;
Part = "foot";
                }

                if(value == 1187) {
                    Facing = "west";
Occupied = false;
Part = "head";
                }

                if(value == 1188) {
                    Facing = "west";
Occupied = false;
Part = "foot";
                }

                if(value == 1189) {
                    Facing = "east";
Occupied = true;
Part = "head";
                }

                if(value == 1190) {
                    Facing = "east";
Occupied = true;
Part = "foot";
                }

                if(value == 1191) {
                    Facing = "east";
Occupied = false;
Part = "head";
                }

                if(value == 1192) {
                    Facing = "east";
Occupied = false;
Part = "foot";
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool Occupied { get; set; } = false;
        public string Part { get; set; } = "foot";

        public BlockLightGrayBed() {
            State = DefaultState;
        }

        public BlockLightGrayBed(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockLightGrayBed(string facing, bool occupied, string part) {
            Facing = facing;
            Occupied = occupied;
            Part = part;
        }
    }
}