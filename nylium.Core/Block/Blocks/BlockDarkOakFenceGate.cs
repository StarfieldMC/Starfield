// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:dark_oak_fence_gate", 479, 8550, 8581, 8557)]
    public class BlockDarkOakFenceGate : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north" && InWall == true && Open == true && Powered == true) {
                    return 8550;
                }

                if(Facing == "north" && InWall == true && Open == true && Powered == false) {
                    return 8551;
                }

                if(Facing == "north" && InWall == true && Open == false && Powered == true) {
                    return 8552;
                }

                if(Facing == "north" && InWall == true && Open == false && Powered == false) {
                    return 8553;
                }

                if(Facing == "north" && InWall == false && Open == true && Powered == true) {
                    return 8554;
                }

                if(Facing == "north" && InWall == false && Open == true && Powered == false) {
                    return 8555;
                }

                if(Facing == "north" && InWall == false && Open == false && Powered == true) {
                    return 8556;
                }

                if(Facing == "north" && InWall == false && Open == false && Powered == false) {
                    return 8557;
                }

                if(Facing == "south" && InWall == true && Open == true && Powered == true) {
                    return 8558;
                }

                if(Facing == "south" && InWall == true && Open == true && Powered == false) {
                    return 8559;
                }

                if(Facing == "south" && InWall == true && Open == false && Powered == true) {
                    return 8560;
                }

                if(Facing == "south" && InWall == true && Open == false && Powered == false) {
                    return 8561;
                }

                if(Facing == "south" && InWall == false && Open == true && Powered == true) {
                    return 8562;
                }

                if(Facing == "south" && InWall == false && Open == true && Powered == false) {
                    return 8563;
                }

                if(Facing == "south" && InWall == false && Open == false && Powered == true) {
                    return 8564;
                }

                if(Facing == "south" && InWall == false && Open == false && Powered == false) {
                    return 8565;
                }

                if(Facing == "west" && InWall == true && Open == true && Powered == true) {
                    return 8566;
                }

                if(Facing == "west" && InWall == true && Open == true && Powered == false) {
                    return 8567;
                }

                if(Facing == "west" && InWall == true && Open == false && Powered == true) {
                    return 8568;
                }

                if(Facing == "west" && InWall == true && Open == false && Powered == false) {
                    return 8569;
                }

                if(Facing == "west" && InWall == false && Open == true && Powered == true) {
                    return 8570;
                }

                if(Facing == "west" && InWall == false && Open == true && Powered == false) {
                    return 8571;
                }

                if(Facing == "west" && InWall == false && Open == false && Powered == true) {
                    return 8572;
                }

                if(Facing == "west" && InWall == false && Open == false && Powered == false) {
                    return 8573;
                }

                if(Facing == "east" && InWall == true && Open == true && Powered == true) {
                    return 8574;
                }

                if(Facing == "east" && InWall == true && Open == true && Powered == false) {
                    return 8575;
                }

                if(Facing == "east" && InWall == true && Open == false && Powered == true) {
                    return 8576;
                }

                if(Facing == "east" && InWall == true && Open == false && Powered == false) {
                    return 8577;
                }

                if(Facing == "east" && InWall == false && Open == true && Powered == true) {
                    return 8578;
                }

                if(Facing == "east" && InWall == false && Open == true && Powered == false) {
                    return 8579;
                }

                if(Facing == "east" && InWall == false && Open == false && Powered == true) {
                    return 8580;
                }

                if(Facing == "east" && InWall == false && Open == false && Powered == false) {
                    return 8581;
                }

                return DefaultState;
            }

            set {
                if(value == 8550) {
                    Facing = "north";
InWall = true;
Open = true;
Powered = true;
                }

                if(value == 8551) {
                    Facing = "north";
InWall = true;
Open = true;
Powered = false;
                }

                if(value == 8552) {
                    Facing = "north";
InWall = true;
Open = false;
Powered = true;
                }

                if(value == 8553) {
                    Facing = "north";
InWall = true;
Open = false;
Powered = false;
                }

                if(value == 8554) {
                    Facing = "north";
InWall = false;
Open = true;
Powered = true;
                }

                if(value == 8555) {
                    Facing = "north";
InWall = false;
Open = true;
Powered = false;
                }

                if(value == 8556) {
                    Facing = "north";
InWall = false;
Open = false;
Powered = true;
                }

                if(value == 8557) {
                    Facing = "north";
InWall = false;
Open = false;
Powered = false;
                }

                if(value == 8558) {
                    Facing = "south";
InWall = true;
Open = true;
Powered = true;
                }

                if(value == 8559) {
                    Facing = "south";
InWall = true;
Open = true;
Powered = false;
                }

                if(value == 8560) {
                    Facing = "south";
InWall = true;
Open = false;
Powered = true;
                }

                if(value == 8561) {
                    Facing = "south";
InWall = true;
Open = false;
Powered = false;
                }

                if(value == 8562) {
                    Facing = "south";
InWall = false;
Open = true;
Powered = true;
                }

                if(value == 8563) {
                    Facing = "south";
InWall = false;
Open = true;
Powered = false;
                }

                if(value == 8564) {
                    Facing = "south";
InWall = false;
Open = false;
Powered = true;
                }

                if(value == 8565) {
                    Facing = "south";
InWall = false;
Open = false;
Powered = false;
                }

                if(value == 8566) {
                    Facing = "west";
InWall = true;
Open = true;
Powered = true;
                }

                if(value == 8567) {
                    Facing = "west";
InWall = true;
Open = true;
Powered = false;
                }

                if(value == 8568) {
                    Facing = "west";
InWall = true;
Open = false;
Powered = true;
                }

                if(value == 8569) {
                    Facing = "west";
InWall = true;
Open = false;
Powered = false;
                }

                if(value == 8570) {
                    Facing = "west";
InWall = false;
Open = true;
Powered = true;
                }

                if(value == 8571) {
                    Facing = "west";
InWall = false;
Open = true;
Powered = false;
                }

                if(value == 8572) {
                    Facing = "west";
InWall = false;
Open = false;
Powered = true;
                }

                if(value == 8573) {
                    Facing = "west";
InWall = false;
Open = false;
Powered = false;
                }

                if(value == 8574) {
                    Facing = "east";
InWall = true;
Open = true;
Powered = true;
                }

                if(value == 8575) {
                    Facing = "east";
InWall = true;
Open = true;
Powered = false;
                }

                if(value == 8576) {
                    Facing = "east";
InWall = true;
Open = false;
Powered = true;
                }

                if(value == 8577) {
                    Facing = "east";
InWall = true;
Open = false;
Powered = false;
                }

                if(value == 8578) {
                    Facing = "east";
InWall = false;
Open = true;
Powered = true;
                }

                if(value == 8579) {
                    Facing = "east";
InWall = false;
Open = true;
Powered = false;
                }

                if(value == 8580) {
                    Facing = "east";
InWall = false;
Open = false;
Powered = true;
                }

                if(value == 8581) {
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

        public BlockDarkOakFenceGate() {
            State = DefaultState;
        }

        public BlockDarkOakFenceGate(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockDarkOakFenceGate(string facing, bool in_wall, bool open, bool powered) {
            Facing = facing;
            InWall = in_wall;
            Open = open;
            Powered = powered;
        }
    }
}