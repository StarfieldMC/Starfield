// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:black_stained_glass_pane", 374, 7347, 7378, 7378)]
    public class BlockBlackStainedGlassPane : BlockBase {

        public override ushort State {
            get {
                if(East == true && North == true && South == true && Waterlogged == true && West == true) {
                    return 7347;
                }

                if(East == true && North == true && South == true && Waterlogged == true && West == false) {
                    return 7348;
                }

                if(East == true && North == true && South == true && Waterlogged == false && West == true) {
                    return 7349;
                }

                if(East == true && North == true && South == true && Waterlogged == false && West == false) {
                    return 7350;
                }

                if(East == true && North == true && South == false && Waterlogged == true && West == true) {
                    return 7351;
                }

                if(East == true && North == true && South == false && Waterlogged == true && West == false) {
                    return 7352;
                }

                if(East == true && North == true && South == false && Waterlogged == false && West == true) {
                    return 7353;
                }

                if(East == true && North == true && South == false && Waterlogged == false && West == false) {
                    return 7354;
                }

                if(East == true && North == false && South == true && Waterlogged == true && West == true) {
                    return 7355;
                }

                if(East == true && North == false && South == true && Waterlogged == true && West == false) {
                    return 7356;
                }

                if(East == true && North == false && South == true && Waterlogged == false && West == true) {
                    return 7357;
                }

                if(East == true && North == false && South == true && Waterlogged == false && West == false) {
                    return 7358;
                }

                if(East == true && North == false && South == false && Waterlogged == true && West == true) {
                    return 7359;
                }

                if(East == true && North == false && South == false && Waterlogged == true && West == false) {
                    return 7360;
                }

                if(East == true && North == false && South == false && Waterlogged == false && West == true) {
                    return 7361;
                }

                if(East == true && North == false && South == false && Waterlogged == false && West == false) {
                    return 7362;
                }

                if(East == false && North == true && South == true && Waterlogged == true && West == true) {
                    return 7363;
                }

                if(East == false && North == true && South == true && Waterlogged == true && West == false) {
                    return 7364;
                }

                if(East == false && North == true && South == true && Waterlogged == false && West == true) {
                    return 7365;
                }

                if(East == false && North == true && South == true && Waterlogged == false && West == false) {
                    return 7366;
                }

                if(East == false && North == true && South == false && Waterlogged == true && West == true) {
                    return 7367;
                }

                if(East == false && North == true && South == false && Waterlogged == true && West == false) {
                    return 7368;
                }

                if(East == false && North == true && South == false && Waterlogged == false && West == true) {
                    return 7369;
                }

                if(East == false && North == true && South == false && Waterlogged == false && West == false) {
                    return 7370;
                }

                if(East == false && North == false && South == true && Waterlogged == true && West == true) {
                    return 7371;
                }

                if(East == false && North == false && South == true && Waterlogged == true && West == false) {
                    return 7372;
                }

                if(East == false && North == false && South == true && Waterlogged == false && West == true) {
                    return 7373;
                }

                if(East == false && North == false && South == true && Waterlogged == false && West == false) {
                    return 7374;
                }

                if(East == false && North == false && South == false && Waterlogged == true && West == true) {
                    return 7375;
                }

                if(East == false && North == false && South == false && Waterlogged == true && West == false) {
                    return 7376;
                }

                if(East == false && North == false && South == false && Waterlogged == false && West == true) {
                    return 7377;
                }

                if(East == false && North == false && South == false && Waterlogged == false && West == false) {
                    return 7378;
                }

                return DefaultState;
            }

            set {
                if(value == 7347) {
                    East = true;
North = true;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 7348) {
                    East = true;
North = true;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 7349) {
                    East = true;
North = true;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 7350) {
                    East = true;
North = true;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 7351) {
                    East = true;
North = true;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 7352) {
                    East = true;
North = true;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 7353) {
                    East = true;
North = true;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 7354) {
                    East = true;
North = true;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 7355) {
                    East = true;
North = false;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 7356) {
                    East = true;
North = false;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 7357) {
                    East = true;
North = false;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 7358) {
                    East = true;
North = false;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 7359) {
                    East = true;
North = false;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 7360) {
                    East = true;
North = false;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 7361) {
                    East = true;
North = false;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 7362) {
                    East = true;
North = false;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 7363) {
                    East = false;
North = true;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 7364) {
                    East = false;
North = true;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 7365) {
                    East = false;
North = true;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 7366) {
                    East = false;
North = true;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 7367) {
                    East = false;
North = true;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 7368) {
                    East = false;
North = true;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 7369) {
                    East = false;
North = true;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 7370) {
                    East = false;
North = true;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 7371) {
                    East = false;
North = false;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 7372) {
                    East = false;
North = false;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 7373) {
                    East = false;
North = false;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 7374) {
                    East = false;
North = false;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 7375) {
                    East = false;
North = false;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 7376) {
                    East = false;
North = false;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 7377) {
                    East = false;
North = false;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 7378) {
                    East = false;
North = false;
South = false;
Waterlogged = false;
West = false;
                }

            }
        }

        public bool East { get; set; } = false;
        public bool North { get; set; } = false;
        public bool South { get; set; } = false;
        public bool Waterlogged { get; set; } = false;
        public bool West { get; set; } = false;

        public BlockBlackStainedGlassPane() {
            State = DefaultState;
        }

        public BlockBlackStainedGlassPane(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBlackStainedGlassPane(bool east, bool north, bool south, bool waterlogged, bool west) {
            East = east;
            North = north;
            South = south;
            Waterlogged = waterlogged;
            West = west;
        }
    }
}