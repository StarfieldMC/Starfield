// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:gray_stained_glass_pane", 366, 7091, 7122, 7122)]
    public class BlockGrayStainedGlassPane : BlockBase {

        public override ushort State {
            get {
                if(East == true && North == true && South == true && Waterlogged == true && West == true) {
                    return 7091;
                }

                if(East == true && North == true && South == true && Waterlogged == true && West == false) {
                    return 7092;
                }

                if(East == true && North == true && South == true && Waterlogged == false && West == true) {
                    return 7093;
                }

                if(East == true && North == true && South == true && Waterlogged == false && West == false) {
                    return 7094;
                }

                if(East == true && North == true && South == false && Waterlogged == true && West == true) {
                    return 7095;
                }

                if(East == true && North == true && South == false && Waterlogged == true && West == false) {
                    return 7096;
                }

                if(East == true && North == true && South == false && Waterlogged == false && West == true) {
                    return 7097;
                }

                if(East == true && North == true && South == false && Waterlogged == false && West == false) {
                    return 7098;
                }

                if(East == true && North == false && South == true && Waterlogged == true && West == true) {
                    return 7099;
                }

                if(East == true && North == false && South == true && Waterlogged == true && West == false) {
                    return 7100;
                }

                if(East == true && North == false && South == true && Waterlogged == false && West == true) {
                    return 7101;
                }

                if(East == true && North == false && South == true && Waterlogged == false && West == false) {
                    return 7102;
                }

                if(East == true && North == false && South == false && Waterlogged == true && West == true) {
                    return 7103;
                }

                if(East == true && North == false && South == false && Waterlogged == true && West == false) {
                    return 7104;
                }

                if(East == true && North == false && South == false && Waterlogged == false && West == true) {
                    return 7105;
                }

                if(East == true && North == false && South == false && Waterlogged == false && West == false) {
                    return 7106;
                }

                if(East == false && North == true && South == true && Waterlogged == true && West == true) {
                    return 7107;
                }

                if(East == false && North == true && South == true && Waterlogged == true && West == false) {
                    return 7108;
                }

                if(East == false && North == true && South == true && Waterlogged == false && West == true) {
                    return 7109;
                }

                if(East == false && North == true && South == true && Waterlogged == false && West == false) {
                    return 7110;
                }

                if(East == false && North == true && South == false && Waterlogged == true && West == true) {
                    return 7111;
                }

                if(East == false && North == true && South == false && Waterlogged == true && West == false) {
                    return 7112;
                }

                if(East == false && North == true && South == false && Waterlogged == false && West == true) {
                    return 7113;
                }

                if(East == false && North == true && South == false && Waterlogged == false && West == false) {
                    return 7114;
                }

                if(East == false && North == false && South == true && Waterlogged == true && West == true) {
                    return 7115;
                }

                if(East == false && North == false && South == true && Waterlogged == true && West == false) {
                    return 7116;
                }

                if(East == false && North == false && South == true && Waterlogged == false && West == true) {
                    return 7117;
                }

                if(East == false && North == false && South == true && Waterlogged == false && West == false) {
                    return 7118;
                }

                if(East == false && North == false && South == false && Waterlogged == true && West == true) {
                    return 7119;
                }

                if(East == false && North == false && South == false && Waterlogged == true && West == false) {
                    return 7120;
                }

                if(East == false && North == false && South == false && Waterlogged == false && West == true) {
                    return 7121;
                }

                if(East == false && North == false && South == false && Waterlogged == false && West == false) {
                    return 7122;
                }

                return DefaultState;
            }

            set {
                if(value == 7091) {
                    East = true;
North = true;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 7092) {
                    East = true;
North = true;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 7093) {
                    East = true;
North = true;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 7094) {
                    East = true;
North = true;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 7095) {
                    East = true;
North = true;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 7096) {
                    East = true;
North = true;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 7097) {
                    East = true;
North = true;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 7098) {
                    East = true;
North = true;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 7099) {
                    East = true;
North = false;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 7100) {
                    East = true;
North = false;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 7101) {
                    East = true;
North = false;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 7102) {
                    East = true;
North = false;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 7103) {
                    East = true;
North = false;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 7104) {
                    East = true;
North = false;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 7105) {
                    East = true;
North = false;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 7106) {
                    East = true;
North = false;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 7107) {
                    East = false;
North = true;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 7108) {
                    East = false;
North = true;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 7109) {
                    East = false;
North = true;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 7110) {
                    East = false;
North = true;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 7111) {
                    East = false;
North = true;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 7112) {
                    East = false;
North = true;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 7113) {
                    East = false;
North = true;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 7114) {
                    East = false;
North = true;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 7115) {
                    East = false;
North = false;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 7116) {
                    East = false;
North = false;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 7117) {
                    East = false;
North = false;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 7118) {
                    East = false;
North = false;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 7119) {
                    East = false;
North = false;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 7120) {
                    East = false;
North = false;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 7121) {
                    East = false;
North = false;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 7122) {
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

        public BlockGrayStainedGlassPane() {
            State = DefaultState;
        }

        public BlockGrayStainedGlassPane(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockGrayStainedGlassPane(bool east, bool north, bool south, bool waterlogged, bool west) {
            East = east;
            North = north;
            South = south;
            Waterlogged = waterlogged;
            West = west;
        }
    }
}