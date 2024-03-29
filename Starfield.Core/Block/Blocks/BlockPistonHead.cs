// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:piston_head", 101, 1360, 1383, 1362)]
    public class BlockPistonHead : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north" && Short == true && Type == "normal") {
                    return 1360;
                }

                if(Facing == "north" && Short == true && Type == "sticky") {
                    return 1361;
                }

                if(Facing == "north" && Short == false && Type == "normal") {
                    return 1362;
                }

                if(Facing == "north" && Short == false && Type == "sticky") {
                    return 1363;
                }

                if(Facing == "east" && Short == true && Type == "normal") {
                    return 1364;
                }

                if(Facing == "east" && Short == true && Type == "sticky") {
                    return 1365;
                }

                if(Facing == "east" && Short == false && Type == "normal") {
                    return 1366;
                }

                if(Facing == "east" && Short == false && Type == "sticky") {
                    return 1367;
                }

                if(Facing == "south" && Short == true && Type == "normal") {
                    return 1368;
                }

                if(Facing == "south" && Short == true && Type == "sticky") {
                    return 1369;
                }

                if(Facing == "south" && Short == false && Type == "normal") {
                    return 1370;
                }

                if(Facing == "south" && Short == false && Type == "sticky") {
                    return 1371;
                }

                if(Facing == "west" && Short == true && Type == "normal") {
                    return 1372;
                }

                if(Facing == "west" && Short == true && Type == "sticky") {
                    return 1373;
                }

                if(Facing == "west" && Short == false && Type == "normal") {
                    return 1374;
                }

                if(Facing == "west" && Short == false && Type == "sticky") {
                    return 1375;
                }

                if(Facing == "up" && Short == true && Type == "normal") {
                    return 1376;
                }

                if(Facing == "up" && Short == true && Type == "sticky") {
                    return 1377;
                }

                if(Facing == "up" && Short == false && Type == "normal") {
                    return 1378;
                }

                if(Facing == "up" && Short == false && Type == "sticky") {
                    return 1379;
                }

                if(Facing == "down" && Short == true && Type == "normal") {
                    return 1380;
                }

                if(Facing == "down" && Short == true && Type == "sticky") {
                    return 1381;
                }

                if(Facing == "down" && Short == false && Type == "normal") {
                    return 1382;
                }

                if(Facing == "down" && Short == false && Type == "sticky") {
                    return 1383;
                }

                return DefaultState;
            }

            set {
                if(value == 1360) {
                    Facing = "north";
Short = true;
Type = "normal";
                }

                if(value == 1361) {
                    Facing = "north";
Short = true;
Type = "sticky";
                }

                if(value == 1362) {
                    Facing = "north";
Short = false;
Type = "normal";
                }

                if(value == 1363) {
                    Facing = "north";
Short = false;
Type = "sticky";
                }

                if(value == 1364) {
                    Facing = "east";
Short = true;
Type = "normal";
                }

                if(value == 1365) {
                    Facing = "east";
Short = true;
Type = "sticky";
                }

                if(value == 1366) {
                    Facing = "east";
Short = false;
Type = "normal";
                }

                if(value == 1367) {
                    Facing = "east";
Short = false;
Type = "sticky";
                }

                if(value == 1368) {
                    Facing = "south";
Short = true;
Type = "normal";
                }

                if(value == 1369) {
                    Facing = "south";
Short = true;
Type = "sticky";
                }

                if(value == 1370) {
                    Facing = "south";
Short = false;
Type = "normal";
                }

                if(value == 1371) {
                    Facing = "south";
Short = false;
Type = "sticky";
                }

                if(value == 1372) {
                    Facing = "west";
Short = true;
Type = "normal";
                }

                if(value == 1373) {
                    Facing = "west";
Short = true;
Type = "sticky";
                }

                if(value == 1374) {
                    Facing = "west";
Short = false;
Type = "normal";
                }

                if(value == 1375) {
                    Facing = "west";
Short = false;
Type = "sticky";
                }

                if(value == 1376) {
                    Facing = "up";
Short = true;
Type = "normal";
                }

                if(value == 1377) {
                    Facing = "up";
Short = true;
Type = "sticky";
                }

                if(value == 1378) {
                    Facing = "up";
Short = false;
Type = "normal";
                }

                if(value == 1379) {
                    Facing = "up";
Short = false;
Type = "sticky";
                }

                if(value == 1380) {
                    Facing = "down";
Short = true;
Type = "normal";
                }

                if(value == 1381) {
                    Facing = "down";
Short = true;
Type = "sticky";
                }

                if(value == 1382) {
                    Facing = "down";
Short = false;
Type = "normal";
                }

                if(value == 1383) {
                    Facing = "down";
Short = false;
Type = "sticky";
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool Short { get; set; } = false;
        public string Type { get; set; } = "normal";

        public BlockPistonHead() {
            State = DefaultState;
        }

        public BlockPistonHead(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockPistonHead(string facing, bool @short, string type) {
            Facing = facing;
            Short = @short;
            Type = type;
        }
    }
}