// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:warped_fence_gate", 715, 15295, 15326, 15302)]
    public class BlockWarpedFenceGate : BlockBase {

        public override ushort State {
            get {
                if(Facing == "north" && InWall == true && Open == true && Powered == true) {
                    return 15295;
                }

                if(Facing == "north" && InWall == true && Open == true && Powered == false) {
                    return 15296;
                }

                if(Facing == "north" && InWall == true && Open == false && Powered == true) {
                    return 15297;
                }

                if(Facing == "north" && InWall == true && Open == false && Powered == false) {
                    return 15298;
                }

                if(Facing == "north" && InWall == false && Open == true && Powered == true) {
                    return 15299;
                }

                if(Facing == "north" && InWall == false && Open == true && Powered == false) {
                    return 15300;
                }

                if(Facing == "north" && InWall == false && Open == false && Powered == true) {
                    return 15301;
                }

                if(Facing == "north" && InWall == false && Open == false && Powered == false) {
                    return 15302;
                }

                if(Facing == "south" && InWall == true && Open == true && Powered == true) {
                    return 15303;
                }

                if(Facing == "south" && InWall == true && Open == true && Powered == false) {
                    return 15304;
                }

                if(Facing == "south" && InWall == true && Open == false && Powered == true) {
                    return 15305;
                }

                if(Facing == "south" && InWall == true && Open == false && Powered == false) {
                    return 15306;
                }

                if(Facing == "south" && InWall == false && Open == true && Powered == true) {
                    return 15307;
                }

                if(Facing == "south" && InWall == false && Open == true && Powered == false) {
                    return 15308;
                }

                if(Facing == "south" && InWall == false && Open == false && Powered == true) {
                    return 15309;
                }

                if(Facing == "south" && InWall == false && Open == false && Powered == false) {
                    return 15310;
                }

                if(Facing == "west" && InWall == true && Open == true && Powered == true) {
                    return 15311;
                }

                if(Facing == "west" && InWall == true && Open == true && Powered == false) {
                    return 15312;
                }

                if(Facing == "west" && InWall == true && Open == false && Powered == true) {
                    return 15313;
                }

                if(Facing == "west" && InWall == true && Open == false && Powered == false) {
                    return 15314;
                }

                if(Facing == "west" && InWall == false && Open == true && Powered == true) {
                    return 15315;
                }

                if(Facing == "west" && InWall == false && Open == true && Powered == false) {
                    return 15316;
                }

                if(Facing == "west" && InWall == false && Open == false && Powered == true) {
                    return 15317;
                }

                if(Facing == "west" && InWall == false && Open == false && Powered == false) {
                    return 15318;
                }

                if(Facing == "east" && InWall == true && Open == true && Powered == true) {
                    return 15319;
                }

                if(Facing == "east" && InWall == true && Open == true && Powered == false) {
                    return 15320;
                }

                if(Facing == "east" && InWall == true && Open == false && Powered == true) {
                    return 15321;
                }

                if(Facing == "east" && InWall == true && Open == false && Powered == false) {
                    return 15322;
                }

                if(Facing == "east" && InWall == false && Open == true && Powered == true) {
                    return 15323;
                }

                if(Facing == "east" && InWall == false && Open == true && Powered == false) {
                    return 15324;
                }

                if(Facing == "east" && InWall == false && Open == false && Powered == true) {
                    return 15325;
                }

                if(Facing == "east" && InWall == false && Open == false && Powered == false) {
                    return 15326;
                }

                return DefaultState;
            }

            set {
                if(value == 15295) {
                    Facing = "north";
InWall = true;
Open = true;
Powered = true;
                }

                if(value == 15296) {
                    Facing = "north";
InWall = true;
Open = true;
Powered = false;
                }

                if(value == 15297) {
                    Facing = "north";
InWall = true;
Open = false;
Powered = true;
                }

                if(value == 15298) {
                    Facing = "north";
InWall = true;
Open = false;
Powered = false;
                }

                if(value == 15299) {
                    Facing = "north";
InWall = false;
Open = true;
Powered = true;
                }

                if(value == 15300) {
                    Facing = "north";
InWall = false;
Open = true;
Powered = false;
                }

                if(value == 15301) {
                    Facing = "north";
InWall = false;
Open = false;
Powered = true;
                }

                if(value == 15302) {
                    Facing = "north";
InWall = false;
Open = false;
Powered = false;
                }

                if(value == 15303) {
                    Facing = "south";
InWall = true;
Open = true;
Powered = true;
                }

                if(value == 15304) {
                    Facing = "south";
InWall = true;
Open = true;
Powered = false;
                }

                if(value == 15305) {
                    Facing = "south";
InWall = true;
Open = false;
Powered = true;
                }

                if(value == 15306) {
                    Facing = "south";
InWall = true;
Open = false;
Powered = false;
                }

                if(value == 15307) {
                    Facing = "south";
InWall = false;
Open = true;
Powered = true;
                }

                if(value == 15308) {
                    Facing = "south";
InWall = false;
Open = true;
Powered = false;
                }

                if(value == 15309) {
                    Facing = "south";
InWall = false;
Open = false;
Powered = true;
                }

                if(value == 15310) {
                    Facing = "south";
InWall = false;
Open = false;
Powered = false;
                }

                if(value == 15311) {
                    Facing = "west";
InWall = true;
Open = true;
Powered = true;
                }

                if(value == 15312) {
                    Facing = "west";
InWall = true;
Open = true;
Powered = false;
                }

                if(value == 15313) {
                    Facing = "west";
InWall = true;
Open = false;
Powered = true;
                }

                if(value == 15314) {
                    Facing = "west";
InWall = true;
Open = false;
Powered = false;
                }

                if(value == 15315) {
                    Facing = "west";
InWall = false;
Open = true;
Powered = true;
                }

                if(value == 15316) {
                    Facing = "west";
InWall = false;
Open = true;
Powered = false;
                }

                if(value == 15317) {
                    Facing = "west";
InWall = false;
Open = false;
Powered = true;
                }

                if(value == 15318) {
                    Facing = "west";
InWall = false;
Open = false;
Powered = false;
                }

                if(value == 15319) {
                    Facing = "east";
InWall = true;
Open = true;
Powered = true;
                }

                if(value == 15320) {
                    Facing = "east";
InWall = true;
Open = true;
Powered = false;
                }

                if(value == 15321) {
                    Facing = "east";
InWall = true;
Open = false;
Powered = true;
                }

                if(value == 15322) {
                    Facing = "east";
InWall = true;
Open = false;
Powered = false;
                }

                if(value == 15323) {
                    Facing = "east";
InWall = false;
Open = true;
Powered = true;
                }

                if(value == 15324) {
                    Facing = "east";
InWall = false;
Open = true;
Powered = false;
                }

                if(value == 15325) {
                    Facing = "east";
InWall = false;
Open = false;
Powered = true;
                }

                if(value == 15326) {
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

        public BlockWarpedFenceGate() {
            State = DefaultState;
        }

        public BlockWarpedFenceGate(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockWarpedFenceGate(string facing, bool in_wall, bool open, bool powered) {
            Facing = facing;
            InWall = in_wall;
            Open = open;
            Powered = powered;
        }
    }
}