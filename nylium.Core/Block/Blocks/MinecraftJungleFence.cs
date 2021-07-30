// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockJungleFence : BlockBase {

        public override string Id { get { return "minecraft:jungle_fence"; } }

        public override ushort MinimumState { get { return 8646; } }
        public override ushort MaximumState { get { return 8677; } }
        public override ushort DefaultState { get { return 8677; } }

        public override ushort State {
            get {
                if(East == true && North == true && South == true && Waterlogged == true && West == true) {
                    return 8646;
                }

                if(East == true && North == true && South == true && Waterlogged == true && West == false) {
                    return 8647;
                }

                if(East == true && North == true && South == true && Waterlogged == false && West == true) {
                    return 8648;
                }

                if(East == true && North == true && South == true && Waterlogged == false && West == false) {
                    return 8649;
                }

                if(East == true && North == true && South == false && Waterlogged == true && West == true) {
                    return 8650;
                }

                if(East == true && North == true && South == false && Waterlogged == true && West == false) {
                    return 8651;
                }

                if(East == true && North == true && South == false && Waterlogged == false && West == true) {
                    return 8652;
                }

                if(East == true && North == true && South == false && Waterlogged == false && West == false) {
                    return 8653;
                }

                if(East == true && North == false && South == true && Waterlogged == true && West == true) {
                    return 8654;
                }

                if(East == true && North == false && South == true && Waterlogged == true && West == false) {
                    return 8655;
                }

                if(East == true && North == false && South == true && Waterlogged == false && West == true) {
                    return 8656;
                }

                if(East == true && North == false && South == true && Waterlogged == false && West == false) {
                    return 8657;
                }

                if(East == true && North == false && South == false && Waterlogged == true && West == true) {
                    return 8658;
                }

                if(East == true && North == false && South == false && Waterlogged == true && West == false) {
                    return 8659;
                }

                if(East == true && North == false && South == false && Waterlogged == false && West == true) {
                    return 8660;
                }

                if(East == true && North == false && South == false && Waterlogged == false && West == false) {
                    return 8661;
                }

                if(East == false && North == true && South == true && Waterlogged == true && West == true) {
                    return 8662;
                }

                if(East == false && North == true && South == true && Waterlogged == true && West == false) {
                    return 8663;
                }

                if(East == false && North == true && South == true && Waterlogged == false && West == true) {
                    return 8664;
                }

                if(East == false && North == true && South == true && Waterlogged == false && West == false) {
                    return 8665;
                }

                if(East == false && North == true && South == false && Waterlogged == true && West == true) {
                    return 8666;
                }

                if(East == false && North == true && South == false && Waterlogged == true && West == false) {
                    return 8667;
                }

                if(East == false && North == true && South == false && Waterlogged == false && West == true) {
                    return 8668;
                }

                if(East == false && North == true && South == false && Waterlogged == false && West == false) {
                    return 8669;
                }

                if(East == false && North == false && South == true && Waterlogged == true && West == true) {
                    return 8670;
                }

                if(East == false && North == false && South == true && Waterlogged == true && West == false) {
                    return 8671;
                }

                if(East == false && North == false && South == true && Waterlogged == false && West == true) {
                    return 8672;
                }

                if(East == false && North == false && South == true && Waterlogged == false && West == false) {
                    return 8673;
                }

                if(East == false && North == false && South == false && Waterlogged == true && West == true) {
                    return 8674;
                }

                if(East == false && North == false && South == false && Waterlogged == true && West == false) {
                    return 8675;
                }

                if(East == false && North == false && South == false && Waterlogged == false && West == true) {
                    return 8676;
                }

                if(East == false && North == false && South == false && Waterlogged == false && West == false) {
                    return 8677;
                }

                return DefaultState;
            }

            set {
                if(value == 8646) {
                    East = true;
North = true;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 8647) {
                    East = true;
North = true;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 8648) {
                    East = true;
North = true;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 8649) {
                    East = true;
North = true;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 8650) {
                    East = true;
North = true;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 8651) {
                    East = true;
North = true;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 8652) {
                    East = true;
North = true;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 8653) {
                    East = true;
North = true;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 8654) {
                    East = true;
North = false;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 8655) {
                    East = true;
North = false;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 8656) {
                    East = true;
North = false;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 8657) {
                    East = true;
North = false;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 8658) {
                    East = true;
North = false;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 8659) {
                    East = true;
North = false;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 8660) {
                    East = true;
North = false;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 8661) {
                    East = true;
North = false;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 8662) {
                    East = false;
North = true;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 8663) {
                    East = false;
North = true;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 8664) {
                    East = false;
North = true;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 8665) {
                    East = false;
North = true;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 8666) {
                    East = false;
North = true;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 8667) {
                    East = false;
North = true;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 8668) {
                    East = false;
North = true;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 8669) {
                    East = false;
North = true;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 8670) {
                    East = false;
North = false;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 8671) {
                    East = false;
North = false;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 8672) {
                    East = false;
North = false;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 8673) {
                    East = false;
North = false;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 8674) {
                    East = false;
North = false;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 8675) {
                    East = false;
North = false;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 8676) {
                    East = false;
North = false;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 8677) {
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

        public BlockJungleFence() {
            State = DefaultState;
        }

        public BlockJungleFence(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockJungleFence(bool east, bool north, bool south, bool waterlogged, bool west) {
            East = east;
            North = north;
            South = south;
            Waterlogged = waterlogged;
            West = west;
        }
    }
}