// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:white_stained_glass_pane", 359, 6867, 6898, 6898)]
    public class BlockWhiteStainedGlassPane : BlockBase {

        public override ushort State {
            get {
                if(East == true && North == true && South == true && Waterlogged == true && West == true) {
                    return 6867;
                }

                if(East == true && North == true && South == true && Waterlogged == true && West == false) {
                    return 6868;
                }

                if(East == true && North == true && South == true && Waterlogged == false && West == true) {
                    return 6869;
                }

                if(East == true && North == true && South == true && Waterlogged == false && West == false) {
                    return 6870;
                }

                if(East == true && North == true && South == false && Waterlogged == true && West == true) {
                    return 6871;
                }

                if(East == true && North == true && South == false && Waterlogged == true && West == false) {
                    return 6872;
                }

                if(East == true && North == true && South == false && Waterlogged == false && West == true) {
                    return 6873;
                }

                if(East == true && North == true && South == false && Waterlogged == false && West == false) {
                    return 6874;
                }

                if(East == true && North == false && South == true && Waterlogged == true && West == true) {
                    return 6875;
                }

                if(East == true && North == false && South == true && Waterlogged == true && West == false) {
                    return 6876;
                }

                if(East == true && North == false && South == true && Waterlogged == false && West == true) {
                    return 6877;
                }

                if(East == true && North == false && South == true && Waterlogged == false && West == false) {
                    return 6878;
                }

                if(East == true && North == false && South == false && Waterlogged == true && West == true) {
                    return 6879;
                }

                if(East == true && North == false && South == false && Waterlogged == true && West == false) {
                    return 6880;
                }

                if(East == true && North == false && South == false && Waterlogged == false && West == true) {
                    return 6881;
                }

                if(East == true && North == false && South == false && Waterlogged == false && West == false) {
                    return 6882;
                }

                if(East == false && North == true && South == true && Waterlogged == true && West == true) {
                    return 6883;
                }

                if(East == false && North == true && South == true && Waterlogged == true && West == false) {
                    return 6884;
                }

                if(East == false && North == true && South == true && Waterlogged == false && West == true) {
                    return 6885;
                }

                if(East == false && North == true && South == true && Waterlogged == false && West == false) {
                    return 6886;
                }

                if(East == false && North == true && South == false && Waterlogged == true && West == true) {
                    return 6887;
                }

                if(East == false && North == true && South == false && Waterlogged == true && West == false) {
                    return 6888;
                }

                if(East == false && North == true && South == false && Waterlogged == false && West == true) {
                    return 6889;
                }

                if(East == false && North == true && South == false && Waterlogged == false && West == false) {
                    return 6890;
                }

                if(East == false && North == false && South == true && Waterlogged == true && West == true) {
                    return 6891;
                }

                if(East == false && North == false && South == true && Waterlogged == true && West == false) {
                    return 6892;
                }

                if(East == false && North == false && South == true && Waterlogged == false && West == true) {
                    return 6893;
                }

                if(East == false && North == false && South == true && Waterlogged == false && West == false) {
                    return 6894;
                }

                if(East == false && North == false && South == false && Waterlogged == true && West == true) {
                    return 6895;
                }

                if(East == false && North == false && South == false && Waterlogged == true && West == false) {
                    return 6896;
                }

                if(East == false && North == false && South == false && Waterlogged == false && West == true) {
                    return 6897;
                }

                if(East == false && North == false && South == false && Waterlogged == false && West == false) {
                    return 6898;
                }

                return DefaultState;
            }

            set {
                if(value == 6867) {
                    East = true;
North = true;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 6868) {
                    East = true;
North = true;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 6869) {
                    East = true;
North = true;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 6870) {
                    East = true;
North = true;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 6871) {
                    East = true;
North = true;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 6872) {
                    East = true;
North = true;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 6873) {
                    East = true;
North = true;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 6874) {
                    East = true;
North = true;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 6875) {
                    East = true;
North = false;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 6876) {
                    East = true;
North = false;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 6877) {
                    East = true;
North = false;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 6878) {
                    East = true;
North = false;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 6879) {
                    East = true;
North = false;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 6880) {
                    East = true;
North = false;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 6881) {
                    East = true;
North = false;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 6882) {
                    East = true;
North = false;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 6883) {
                    East = false;
North = true;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 6884) {
                    East = false;
North = true;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 6885) {
                    East = false;
North = true;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 6886) {
                    East = false;
North = true;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 6887) {
                    East = false;
North = true;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 6888) {
                    East = false;
North = true;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 6889) {
                    East = false;
North = true;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 6890) {
                    East = false;
North = true;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 6891) {
                    East = false;
North = false;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 6892) {
                    East = false;
North = false;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 6893) {
                    East = false;
North = false;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 6894) {
                    East = false;
North = false;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 6895) {
                    East = false;
North = false;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 6896) {
                    East = false;
North = false;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 6897) {
                    East = false;
North = false;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 6898) {
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

        public BlockWhiteStainedGlassPane() {
            State = DefaultState;
        }

        public BlockWhiteStainedGlassPane(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockWhiteStainedGlassPane(bool east, bool north, bool south, bool waterlogged, bool west) {
            East = east;
            North = north;
            South = south;
            Waterlogged = waterlogged;
            West = west;
        }
    }
}