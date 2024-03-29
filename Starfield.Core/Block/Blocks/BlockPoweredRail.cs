// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:powered_rail", 91, 1305, 1316, 1311)]
    public class BlockPoweredRail : BlockBase {

        public override ushort State {
            get {
                if(Powered == true && Shape == "north_south") {
                    return 1305;
                }

                if(Powered == true && Shape == "east_west") {
                    return 1306;
                }

                if(Powered == true && Shape == "ascending_east") {
                    return 1307;
                }

                if(Powered == true && Shape == "ascending_west") {
                    return 1308;
                }

                if(Powered == true && Shape == "ascending_north") {
                    return 1309;
                }

                if(Powered == true && Shape == "ascending_south") {
                    return 1310;
                }

                if(Powered == false && Shape == "north_south") {
                    return 1311;
                }

                if(Powered == false && Shape == "east_west") {
                    return 1312;
                }

                if(Powered == false && Shape == "ascending_east") {
                    return 1313;
                }

                if(Powered == false && Shape == "ascending_west") {
                    return 1314;
                }

                if(Powered == false && Shape == "ascending_north") {
                    return 1315;
                }

                if(Powered == false && Shape == "ascending_south") {
                    return 1316;
                }

                return DefaultState;
            }

            set {
                if(value == 1305) {
                    Powered = true;
Shape = "north_south";
                }

                if(value == 1306) {
                    Powered = true;
Shape = "east_west";
                }

                if(value == 1307) {
                    Powered = true;
Shape = "ascending_east";
                }

                if(value == 1308) {
                    Powered = true;
Shape = "ascending_west";
                }

                if(value == 1309) {
                    Powered = true;
Shape = "ascending_north";
                }

                if(value == 1310) {
                    Powered = true;
Shape = "ascending_south";
                }

                if(value == 1311) {
                    Powered = false;
Shape = "north_south";
                }

                if(value == 1312) {
                    Powered = false;
Shape = "east_west";
                }

                if(value == 1313) {
                    Powered = false;
Shape = "ascending_east";
                }

                if(value == 1314) {
                    Powered = false;
Shape = "ascending_west";
                }

                if(value == 1315) {
                    Powered = false;
Shape = "ascending_north";
                }

                if(value == 1316) {
                    Powered = false;
Shape = "ascending_south";
                }

            }
        }

        public bool Powered { get; set; } = false;
        public string Shape { get; set; } = "north_south";

        public BlockPoweredRail() {
            State = DefaultState;
        }

        public BlockPoweredRail(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockPoweredRail(bool powered, string shape) {
            Powered = powered;
            Shape = shape;
        }
    }
}