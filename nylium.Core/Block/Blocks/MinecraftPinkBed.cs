// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockPinkBed : BlockBase {

        public override string Id { get { return "minecraft:pink_bed"; } }

        public override ushort MinimumState { get { return 1145; } }
        public override ushort MaximumState { get { return 1160; } }
        public override ushort DefaultState { get { return 1148; } }

        public override ushort State {
            get {
                if(Facing == "north" && Occupied == true && Part == "head") {
                    return 1145;
                }

                if(Facing == "north" && Occupied == true && Part == "foot") {
                    return 1146;
                }

                if(Facing == "north" && Occupied == false && Part == "head") {
                    return 1147;
                }

                if(Facing == "north" && Occupied == false && Part == "foot") {
                    return 1148;
                }

                if(Facing == "south" && Occupied == true && Part == "head") {
                    return 1149;
                }

                if(Facing == "south" && Occupied == true && Part == "foot") {
                    return 1150;
                }

                if(Facing == "south" && Occupied == false && Part == "head") {
                    return 1151;
                }

                if(Facing == "south" && Occupied == false && Part == "foot") {
                    return 1152;
                }

                if(Facing == "west" && Occupied == true && Part == "head") {
                    return 1153;
                }

                if(Facing == "west" && Occupied == true && Part == "foot") {
                    return 1154;
                }

                if(Facing == "west" && Occupied == false && Part == "head") {
                    return 1155;
                }

                if(Facing == "west" && Occupied == false && Part == "foot") {
                    return 1156;
                }

                if(Facing == "east" && Occupied == true && Part == "head") {
                    return 1157;
                }

                if(Facing == "east" && Occupied == true && Part == "foot") {
                    return 1158;
                }

                if(Facing == "east" && Occupied == false && Part == "head") {
                    return 1159;
                }

                if(Facing == "east" && Occupied == false && Part == "foot") {
                    return 1160;
                }

                return DefaultState;
            }

            set {
                if(value == 1145) {
                    Facing = "north";
Occupied = true;
Part = "head";
                }

                if(value == 1146) {
                    Facing = "north";
Occupied = true;
Part = "foot";
                }

                if(value == 1147) {
                    Facing = "north";
Occupied = false;
Part = "head";
                }

                if(value == 1148) {
                    Facing = "north";
Occupied = false;
Part = "foot";
                }

                if(value == 1149) {
                    Facing = "south";
Occupied = true;
Part = "head";
                }

                if(value == 1150) {
                    Facing = "south";
Occupied = true;
Part = "foot";
                }

                if(value == 1151) {
                    Facing = "south";
Occupied = false;
Part = "head";
                }

                if(value == 1152) {
                    Facing = "south";
Occupied = false;
Part = "foot";
                }

                if(value == 1153) {
                    Facing = "west";
Occupied = true;
Part = "head";
                }

                if(value == 1154) {
                    Facing = "west";
Occupied = true;
Part = "foot";
                }

                if(value == 1155) {
                    Facing = "west";
Occupied = false;
Part = "head";
                }

                if(value == 1156) {
                    Facing = "west";
Occupied = false;
Part = "foot";
                }

                if(value == 1157) {
                    Facing = "east";
Occupied = true;
Part = "head";
                }

                if(value == 1158) {
                    Facing = "east";
Occupied = true;
Part = "foot";
                }

                if(value == 1159) {
                    Facing = "east";
Occupied = false;
Part = "head";
                }

                if(value == 1160) {
                    Facing = "east";
Occupied = false;
Part = "foot";
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool Occupied { get; set; } = false;
        public string Part { get; set; } = "foot";

        public BlockPinkBed() {
            State = DefaultState;
        }

        public BlockPinkBed(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockPinkBed(string facing, bool occupied, string part) {
            Facing = facing;
            Occupied = occupied;
            Part = part;
        }
    }
}