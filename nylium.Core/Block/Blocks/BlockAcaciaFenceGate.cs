// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:acacia_fence_gate", 478, 8518, 8549, 8525)]
    public class BlockAcaciaFenceGate : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north" && InWall == true && Open == true && Powered == true) {
                    return 8518;
                }

                if(Facing == "north" && InWall == true && Open == true && Powered == false) {
                    return 8519;
                }

                if(Facing == "north" && InWall == true && Open == false && Powered == true) {
                    return 8520;
                }

                if(Facing == "north" && InWall == true && Open == false && Powered == false) {
                    return 8521;
                }

                if(Facing == "north" && InWall == false && Open == true && Powered == true) {
                    return 8522;
                }

                if(Facing == "north" && InWall == false && Open == true && Powered == false) {
                    return 8523;
                }

                if(Facing == "north" && InWall == false && Open == false && Powered == true) {
                    return 8524;
                }

                if(Facing == "north" && InWall == false && Open == false && Powered == false) {
                    return 8525;
                }

                if(Facing == "south" && InWall == true && Open == true && Powered == true) {
                    return 8526;
                }

                if(Facing == "south" && InWall == true && Open == true && Powered == false) {
                    return 8527;
                }

                if(Facing == "south" && InWall == true && Open == false && Powered == true) {
                    return 8528;
                }

                if(Facing == "south" && InWall == true && Open == false && Powered == false) {
                    return 8529;
                }

                if(Facing == "south" && InWall == false && Open == true && Powered == true) {
                    return 8530;
                }

                if(Facing == "south" && InWall == false && Open == true && Powered == false) {
                    return 8531;
                }

                if(Facing == "south" && InWall == false && Open == false && Powered == true) {
                    return 8532;
                }

                if(Facing == "south" && InWall == false && Open == false && Powered == false) {
                    return 8533;
                }

                if(Facing == "west" && InWall == true && Open == true && Powered == true) {
                    return 8534;
                }

                if(Facing == "west" && InWall == true && Open == true && Powered == false) {
                    return 8535;
                }

                if(Facing == "west" && InWall == true && Open == false && Powered == true) {
                    return 8536;
                }

                if(Facing == "west" && InWall == true && Open == false && Powered == false) {
                    return 8537;
                }

                if(Facing == "west" && InWall == false && Open == true && Powered == true) {
                    return 8538;
                }

                if(Facing == "west" && InWall == false && Open == true && Powered == false) {
                    return 8539;
                }

                if(Facing == "west" && InWall == false && Open == false && Powered == true) {
                    return 8540;
                }

                if(Facing == "west" && InWall == false && Open == false && Powered == false) {
                    return 8541;
                }

                if(Facing == "east" && InWall == true && Open == true && Powered == true) {
                    return 8542;
                }

                if(Facing == "east" && InWall == true && Open == true && Powered == false) {
                    return 8543;
                }

                if(Facing == "east" && InWall == true && Open == false && Powered == true) {
                    return 8544;
                }

                if(Facing == "east" && InWall == true && Open == false && Powered == false) {
                    return 8545;
                }

                if(Facing == "east" && InWall == false && Open == true && Powered == true) {
                    return 8546;
                }

                if(Facing == "east" && InWall == false && Open == true && Powered == false) {
                    return 8547;
                }

                if(Facing == "east" && InWall == false && Open == false && Powered == true) {
                    return 8548;
                }

                if(Facing == "east" && InWall == false && Open == false && Powered == false) {
                    return 8549;
                }

                return DefaultState;
            }

            set {
                if(value == 8518) {
                    Facing = "north";
InWall = true;
Open = true;
Powered = true;
                }

                if(value == 8519) {
                    Facing = "north";
InWall = true;
Open = true;
Powered = false;
                }

                if(value == 8520) {
                    Facing = "north";
InWall = true;
Open = false;
Powered = true;
                }

                if(value == 8521) {
                    Facing = "north";
InWall = true;
Open = false;
Powered = false;
                }

                if(value == 8522) {
                    Facing = "north";
InWall = false;
Open = true;
Powered = true;
                }

                if(value == 8523) {
                    Facing = "north";
InWall = false;
Open = true;
Powered = false;
                }

                if(value == 8524) {
                    Facing = "north";
InWall = false;
Open = false;
Powered = true;
                }

                if(value == 8525) {
                    Facing = "north";
InWall = false;
Open = false;
Powered = false;
                }

                if(value == 8526) {
                    Facing = "south";
InWall = true;
Open = true;
Powered = true;
                }

                if(value == 8527) {
                    Facing = "south";
InWall = true;
Open = true;
Powered = false;
                }

                if(value == 8528) {
                    Facing = "south";
InWall = true;
Open = false;
Powered = true;
                }

                if(value == 8529) {
                    Facing = "south";
InWall = true;
Open = false;
Powered = false;
                }

                if(value == 8530) {
                    Facing = "south";
InWall = false;
Open = true;
Powered = true;
                }

                if(value == 8531) {
                    Facing = "south";
InWall = false;
Open = true;
Powered = false;
                }

                if(value == 8532) {
                    Facing = "south";
InWall = false;
Open = false;
Powered = true;
                }

                if(value == 8533) {
                    Facing = "south";
InWall = false;
Open = false;
Powered = false;
                }

                if(value == 8534) {
                    Facing = "west";
InWall = true;
Open = true;
Powered = true;
                }

                if(value == 8535) {
                    Facing = "west";
InWall = true;
Open = true;
Powered = false;
                }

                if(value == 8536) {
                    Facing = "west";
InWall = true;
Open = false;
Powered = true;
                }

                if(value == 8537) {
                    Facing = "west";
InWall = true;
Open = false;
Powered = false;
                }

                if(value == 8538) {
                    Facing = "west";
InWall = false;
Open = true;
Powered = true;
                }

                if(value == 8539) {
                    Facing = "west";
InWall = false;
Open = true;
Powered = false;
                }

                if(value == 8540) {
                    Facing = "west";
InWall = false;
Open = false;
Powered = true;
                }

                if(value == 8541) {
                    Facing = "west";
InWall = false;
Open = false;
Powered = false;
                }

                if(value == 8542) {
                    Facing = "east";
InWall = true;
Open = true;
Powered = true;
                }

                if(value == 8543) {
                    Facing = "east";
InWall = true;
Open = true;
Powered = false;
                }

                if(value == 8544) {
                    Facing = "east";
InWall = true;
Open = false;
Powered = true;
                }

                if(value == 8545) {
                    Facing = "east";
InWall = true;
Open = false;
Powered = false;
                }

                if(value == 8546) {
                    Facing = "east";
InWall = false;
Open = true;
Powered = true;
                }

                if(value == 8547) {
                    Facing = "east";
InWall = false;
Open = true;
Powered = false;
                }

                if(value == 8548) {
                    Facing = "east";
InWall = false;
Open = false;
Powered = true;
                }

                if(value == 8549) {
                    Facing = "east";
InWall = false;
Open = false;
Powered = false;
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool InWall { get; set; } = false;
        public bool Open { get; set; } = false;
        public bool Powered { get; set; } = false;

        public BlockAcaciaFenceGate() {
            State = DefaultState;
        }

        public BlockAcaciaFenceGate(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockAcaciaFenceGate(string facing, bool in_wall, bool open, bool powered) {
            Facing = facing;
            InWall = in_wall;
            Open = open;
            Powered = powered;
        }
    }
}