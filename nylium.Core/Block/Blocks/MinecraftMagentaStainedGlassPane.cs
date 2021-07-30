// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockMagentaStainedGlassPane : BlockBase {

        public override string Id { get { return "minecraft:magenta_stained_glass_pane"; } }

        public override ushort MinimumState { get { return 6931; } }
        public override ushort MaximumState { get { return 6962; } }
        public override ushort DefaultState { get { return 6962; } }

        public override ushort State {
            get {
                if(East == true && North == true && South == true && Waterlogged == true && West == true) {
                    return 6931;
                }

                if(East == true && North == true && South == true && Waterlogged == true && West == false) {
                    return 6932;
                }

                if(East == true && North == true && South == true && Waterlogged == false && West == true) {
                    return 6933;
                }

                if(East == true && North == true && South == true && Waterlogged == false && West == false) {
                    return 6934;
                }

                if(East == true && North == true && South == false && Waterlogged == true && West == true) {
                    return 6935;
                }

                if(East == true && North == true && South == false && Waterlogged == true && West == false) {
                    return 6936;
                }

                if(East == true && North == true && South == false && Waterlogged == false && West == true) {
                    return 6937;
                }

                if(East == true && North == true && South == false && Waterlogged == false && West == false) {
                    return 6938;
                }

                if(East == true && North == false && South == true && Waterlogged == true && West == true) {
                    return 6939;
                }

                if(East == true && North == false && South == true && Waterlogged == true && West == false) {
                    return 6940;
                }

                if(East == true && North == false && South == true && Waterlogged == false && West == true) {
                    return 6941;
                }

                if(East == true && North == false && South == true && Waterlogged == false && West == false) {
                    return 6942;
                }

                if(East == true && North == false && South == false && Waterlogged == true && West == true) {
                    return 6943;
                }

                if(East == true && North == false && South == false && Waterlogged == true && West == false) {
                    return 6944;
                }

                if(East == true && North == false && South == false && Waterlogged == false && West == true) {
                    return 6945;
                }

                if(East == true && North == false && South == false && Waterlogged == false && West == false) {
                    return 6946;
                }

                if(East == false && North == true && South == true && Waterlogged == true && West == true) {
                    return 6947;
                }

                if(East == false && North == true && South == true && Waterlogged == true && West == false) {
                    return 6948;
                }

                if(East == false && North == true && South == true && Waterlogged == false && West == true) {
                    return 6949;
                }

                if(East == false && North == true && South == true && Waterlogged == false && West == false) {
                    return 6950;
                }

                if(East == false && North == true && South == false && Waterlogged == true && West == true) {
                    return 6951;
                }

                if(East == false && North == true && South == false && Waterlogged == true && West == false) {
                    return 6952;
                }

                if(East == false && North == true && South == false && Waterlogged == false && West == true) {
                    return 6953;
                }

                if(East == false && North == true && South == false && Waterlogged == false && West == false) {
                    return 6954;
                }

                if(East == false && North == false && South == true && Waterlogged == true && West == true) {
                    return 6955;
                }

                if(East == false && North == false && South == true && Waterlogged == true && West == false) {
                    return 6956;
                }

                if(East == false && North == false && South == true && Waterlogged == false && West == true) {
                    return 6957;
                }

                if(East == false && North == false && South == true && Waterlogged == false && West == false) {
                    return 6958;
                }

                if(East == false && North == false && South == false && Waterlogged == true && West == true) {
                    return 6959;
                }

                if(East == false && North == false && South == false && Waterlogged == true && West == false) {
                    return 6960;
                }

                if(East == false && North == false && South == false && Waterlogged == false && West == true) {
                    return 6961;
                }

                if(East == false && North == false && South == false && Waterlogged == false && West == false) {
                    return 6962;
                }

                return DefaultState;
            }

            set {
                if(value == 6931) {
                    East = true;
North = true;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 6932) {
                    East = true;
North = true;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 6933) {
                    East = true;
North = true;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 6934) {
                    East = true;
North = true;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 6935) {
                    East = true;
North = true;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 6936) {
                    East = true;
North = true;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 6937) {
                    East = true;
North = true;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 6938) {
                    East = true;
North = true;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 6939) {
                    East = true;
North = false;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 6940) {
                    East = true;
North = false;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 6941) {
                    East = true;
North = false;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 6942) {
                    East = true;
North = false;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 6943) {
                    East = true;
North = false;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 6944) {
                    East = true;
North = false;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 6945) {
                    East = true;
North = false;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 6946) {
                    East = true;
North = false;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 6947) {
                    East = false;
North = true;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 6948) {
                    East = false;
North = true;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 6949) {
                    East = false;
North = true;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 6950) {
                    East = false;
North = true;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 6951) {
                    East = false;
North = true;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 6952) {
                    East = false;
North = true;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 6953) {
                    East = false;
North = true;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 6954) {
                    East = false;
North = true;
South = false;
Waterlogged = false;
West = false;
                }

                if(value == 6955) {
                    East = false;
North = false;
South = true;
Waterlogged = true;
West = true;
                }

                if(value == 6956) {
                    East = false;
North = false;
South = true;
Waterlogged = true;
West = false;
                }

                if(value == 6957) {
                    East = false;
North = false;
South = true;
Waterlogged = false;
West = true;
                }

                if(value == 6958) {
                    East = false;
North = false;
South = true;
Waterlogged = false;
West = false;
                }

                if(value == 6959) {
                    East = false;
North = false;
South = false;
Waterlogged = true;
West = true;
                }

                if(value == 6960) {
                    East = false;
North = false;
South = false;
Waterlogged = true;
West = false;
                }

                if(value == 6961) {
                    East = false;
North = false;
South = false;
Waterlogged = false;
West = true;
                }

                if(value == 6962) {
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

        public BlockMagentaStainedGlassPane() {
            State = DefaultState;
        }

        public BlockMagentaStainedGlassPane(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockMagentaStainedGlassPane(bool east, bool north, bool south, bool waterlogged, bool west) {
            East = east;
            North = north;
            South = south;
            Waterlogged = waterlogged;
            West = west;
        }
    }
}