// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:brown_stained_glass_pane", 371, 7251, 7282, 7282)]
    public class BlockBrownStainedGlassPane : BlockBase {

        public override ushort State {
            get {
                if(East == true && North == true && South == true && Waterlogged == true && West == true) {
                    return 7251;
                }

                if(East == true && North == true && South == true && Waterlogged == true && West == false) {
                    return 7252;
                }

                if(East == true && North == true && South == true && Waterlogged == false && West == true) {
                    return 7253;
                }

                if(East == true && North == true && South == true && Waterlogged == false && West == false) {
                    return 7254;
                }

                if(East == true && North == true && South == false && Waterlogged == true && West == true) {
                    return 7255;
                }

                if(East == true && North == true && South == false && Waterlogged == true && West == false) {
                    return 7256;
                }

                if(East == true && North == true && South == false && Waterlogged == false && West == true) {
                    return 7257;
                }

                if(East == true && North == true && South == false && Waterlogged == false && West == false) {
                    return 7258;
                }

                if(East == true && North == false && South == true && Waterlogged == true && West == true) {
                    return 7259;
                }

                if(East == true && North == false && South == true && Waterlogged == true && West == false) {
                    return 7260;
                }

                if(East == true && North == false && South == true && Waterlogged == false && West == true) {
                    return 7261;
                }

                if(East == true && North == false && South == true && Waterlogged == false && West == false) {
                    return 7262;
                }

                if(East == true && North == false && South == false && Waterlogged == true && West == true) {
                    return 7263;
                }

                if(East == true && North == false && South == false && Waterlogged == true && West == false) {
                    return 7264;
                }

                if(East == true && North == false && South == false && Waterlogged == false && West == true) {
                    return 7265;
                }

                if(East == true && North == false && South == false && Waterlogged == false && West == false) {
                    return 7266;
                }

                if(East == false && North == true && South == true && Waterlogged == true && West == true) {
                    return 7267;
                }

                if(East == false && North == true && South == true && Waterlogged == true && West == false) {
                    return 7268;
                }

                if(East == false && North == true && South == true && Waterlogged == false && West == true) {
                    return 7269;
                }

                if(East == false && North == true && South == true && Waterlogged == false && West == false) {
                    return 7270;
                }

                if(East == false && North == true && South == false && Waterlogged == true && West == true) {
                    return 7271;
                }

                if(East == false && North == true && South == false && Waterlogged == true && West == false) {
                    return 7272;
                }

                if(East == false && North == true && South == false && Waterlogged == false && West == true) {
                    return 7273;
                }

                if(East == false && North == true && South == false && Waterlogged == false && West == false) {
                    return 7274;
                }

                if(East == false && North == false && South == true && Waterlogged == true && West == true) {
                    return 7275;
                }

                if(East == false && North == false && South == true && Waterlogged == true && West == false) {
                    return 7276;
                }

                if(East == false && North == false && South == true && Waterlogged == false && West == true) {
                    return 7277;
                }

                if(East == false && North == false && South == true && Waterlogged == false && West == false) {
                    return 7278;
                }

                if(East == false && North == false && South == false && Waterlogged == true && West == true) {
                    return 7279;
                }

                if(East == false && North == false && South == false && Waterlogged == true && West == false) {
                    return 7280;
                }

                if(East == false && North == false && South == false && Waterlogged == false && West == true) {
                    return 7281;
                }

                if(East == false && North == false && South == false && Waterlogged == false && West == false) {
                    return 7282;
                }

                return DefaultState;
            }

            set {
                if(value == 7251) {
                    East = true;
North = true;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 7252) {
                    East = true;
North = true;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 7253) {
                    East = true;
North = true;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 7254) {
                    East = true;
North = true;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 7255) {
                    East = true;
North = true;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 7256) {
                    East = true;
North = true;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 7257) {
                    East = true;
North = true;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 7258) {
                    East = true;
North = true;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 7259) {
                    East = true;
North = false;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 7260) {
                    East = true;
North = false;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 7261) {
                    East = true;
North = false;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 7262) {
                    East = true;
North = false;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 7263) {
                    East = true;
North = false;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 7264) {
                    East = true;
North = false;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 7265) {
                    East = true;
North = false;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 7266) {
                    East = true;
North = false;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 7267) {
                    East = false;
North = true;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 7268) {
                    East = false;
North = true;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 7269) {
                    East = false;
North = true;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 7270) {
                    East = false;
North = true;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 7271) {
                    East = false;
North = true;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 7272) {
                    East = false;
North = true;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 7273) {
                    East = false;
North = true;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 7274) {
                    East = false;
North = true;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 7275) {
                    East = false;
North = false;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 7276) {
                    East = false;
North = false;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 7277) {
                    East = false;
North = false;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 7278) {
                    East = false;
North = false;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 7279) {
                    East = false;
North = false;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 7280) {
                    East = false;
North = false;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 7281) {
                    East = false;
North = false;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 7282) {
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

        public BlockBrownStainedGlassPane() {
            State = DefaultState;
        }

        public BlockBrownStainedGlassPane(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBrownStainedGlassPane(bool east, bool north, bool south, bool waterlogged, bool west) {
            East = east;
            North = north;
            South = south;
            Waterlogged = waterlogged;
            West = west;
        }
    }
}