// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:purple_stained_glass_pane", 369, 7187, 7218, 7218)]
    public class BlockPurpleStainedGlassPane : BlockBase {

        public override ushort State {
            get {
                if(East == true && North == true && South == true && Waterlogged == true && West == true) {
                    return 7187;
                }

                if(East == true && North == true && South == true && Waterlogged == true && West == false) {
                    return 7188;
                }

                if(East == true && North == true && South == true && Waterlogged == false && West == true) {
                    return 7189;
                }

                if(East == true && North == true && South == true && Waterlogged == false && West == false) {
                    return 7190;
                }

                if(East == true && North == true && South == false && Waterlogged == true && West == true) {
                    return 7191;
                }

                if(East == true && North == true && South == false && Waterlogged == true && West == false) {
                    return 7192;
                }

                if(East == true && North == true && South == false && Waterlogged == false && West == true) {
                    return 7193;
                }

                if(East == true && North == true && South == false && Waterlogged == false && West == false) {
                    return 7194;
                }

                if(East == true && North == false && South == true && Waterlogged == true && West == true) {
                    return 7195;
                }

                if(East == true && North == false && South == true && Waterlogged == true && West == false) {
                    return 7196;
                }

                if(East == true && North == false && South == true && Waterlogged == false && West == true) {
                    return 7197;
                }

                if(East == true && North == false && South == true && Waterlogged == false && West == false) {
                    return 7198;
                }

                if(East == true && North == false && South == false && Waterlogged == true && West == true) {
                    return 7199;
                }

                if(East == true && North == false && South == false && Waterlogged == true && West == false) {
                    return 7200;
                }

                if(East == true && North == false && South == false && Waterlogged == false && West == true) {
                    return 7201;
                }

                if(East == true && North == false && South == false && Waterlogged == false && West == false) {
                    return 7202;
                }

                if(East == false && North == true && South == true && Waterlogged == true && West == true) {
                    return 7203;
                }

                if(East == false && North == true && South == true && Waterlogged == true && West == false) {
                    return 7204;
                }

                if(East == false && North == true && South == true && Waterlogged == false && West == true) {
                    return 7205;
                }

                if(East == false && North == true && South == true && Waterlogged == false && West == false) {
                    return 7206;
                }

                if(East == false && North == true && South == false && Waterlogged == true && West == true) {
                    return 7207;
                }

                if(East == false && North == true && South == false && Waterlogged == true && West == false) {
                    return 7208;
                }

                if(East == false && North == true && South == false && Waterlogged == false && West == true) {
                    return 7209;
                }

                if(East == false && North == true && South == false && Waterlogged == false && West == false) {
                    return 7210;
                }

                if(East == false && North == false && South == true && Waterlogged == true && West == true) {
                    return 7211;
                }

                if(East == false && North == false && South == true && Waterlogged == true && West == false) {
                    return 7212;
                }

                if(East == false && North == false && South == true && Waterlogged == false && West == true) {
                    return 7213;
                }

                if(East == false && North == false && South == true && Waterlogged == false && West == false) {
                    return 7214;
                }

                if(East == false && North == false && South == false && Waterlogged == true && West == true) {
                    return 7215;
                }

                if(East == false && North == false && South == false && Waterlogged == true && West == false) {
                    return 7216;
                }

                if(East == false && North == false && South == false && Waterlogged == false && West == true) {
                    return 7217;
                }

                if(East == false && North == false && South == false && Waterlogged == false && West == false) {
                    return 7218;
                }

                return DefaultState;
            }

            set {
                if(value == 7187) {
                    East = true;
North = true;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 7188) {
                    East = true;
North = true;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 7189) {
                    East = true;
North = true;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 7190) {
                    East = true;
North = true;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 7191) {
                    East = true;
North = true;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 7192) {
                    East = true;
North = true;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 7193) {
                    East = true;
North = true;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 7194) {
                    East = true;
North = true;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 7195) {
                    East = true;
North = false;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 7196) {
                    East = true;
North = false;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 7197) {
                    East = true;
North = false;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 7198) {
                    East = true;
North = false;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 7199) {
                    East = true;
North = false;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 7200) {
                    East = true;
North = false;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 7201) {
                    East = true;
North = false;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 7202) {
                    East = true;
North = false;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 7203) {
                    East = false;
North = true;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 7204) {
                    East = false;
North = true;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 7205) {
                    East = false;
North = true;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 7206) {
                    East = false;
North = true;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 7207) {
                    East = false;
North = true;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 7208) {
                    East = false;
North = true;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 7209) {
                    East = false;
North = true;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 7210) {
                    East = false;
North = true;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 7211) {
                    East = false;
North = false;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 7212) {
                    East = false;
North = false;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 7213) {
                    East = false;
North = false;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 7214) {
                    East = false;
North = false;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 7215) {
                    East = false;
North = false;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 7216) {
                    East = false;
North = false;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 7217) {
                    East = false;
North = false;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 7218) {
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

        public BlockPurpleStainedGlassPane() {
            State = DefaultState;
        }

        public BlockPurpleStainedGlassPane(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockPurpleStainedGlassPane(bool east, bool north, bool south, bool waterlogged, bool west) {
            East = east;
            North = north;
            South = south;
            Waterlogged = waterlogged;
            West = west;
        }
    }
}