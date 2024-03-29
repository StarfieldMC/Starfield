// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:oak_button", 308, 6350, 6373, 6359)]
    public class BlockOakButton : BlockBase {

        public override ushort State {
            get {
                if(Face == "floor" && Facing == "north" && Powered == true) {
                    return 6350;
                }

                if(Face == "floor" && Facing == "north" && Powered == false) {
                    return 6351;
                }

                if(Face == "floor" && Facing == "south" && Powered == true) {
                    return 6352;
                }

                if(Face == "floor" && Facing == "south" && Powered == false) {
                    return 6353;
                }

                if(Face == "floor" && Facing == "west" && Powered == true) {
                    return 6354;
                }

                if(Face == "floor" && Facing == "west" && Powered == false) {
                    return 6355;
                }

                if(Face == "floor" && Facing == "east" && Powered == true) {
                    return 6356;
                }

                if(Face == "floor" && Facing == "east" && Powered == false) {
                    return 6357;
                }

                if(Face == "wall" && Facing == "north" && Powered == true) {
                    return 6358;
                }

                if(Face == "wall" && Facing == "north" && Powered == false) {
                    return 6359;
                }

                if(Face == "wall" && Facing == "south" && Powered == true) {
                    return 6360;
                }

                if(Face == "wall" && Facing == "south" && Powered == false) {
                    return 6361;
                }

                if(Face == "wall" && Facing == "west" && Powered == true) {
                    return 6362;
                }

                if(Face == "wall" && Facing == "west" && Powered == false) {
                    return 6363;
                }

                if(Face == "wall" && Facing == "east" && Powered == true) {
                    return 6364;
                }

                if(Face == "wall" && Facing == "east" && Powered == false) {
                    return 6365;
                }

                if(Face == "ceiling" && Facing == "north" && Powered == true) {
                    return 6366;
                }

                if(Face == "ceiling" && Facing == "north" && Powered == false) {
                    return 6367;
                }

                if(Face == "ceiling" && Facing == "south" && Powered == true) {
                    return 6368;
                }

                if(Face == "ceiling" && Facing == "south" && Powered == false) {
                    return 6369;
                }

                if(Face == "ceiling" && Facing == "west" && Powered == true) {
                    return 6370;
                }

                if(Face == "ceiling" && Facing == "west" && Powered == false) {
                    return 6371;
                }

                if(Face == "ceiling" && Facing == "east" && Powered == true) {
                    return 6372;
                }

                if(Face == "ceiling" && Facing == "east" && Powered == false) {
                    return 6373;
                }

                return DefaultState;
            }

            set {
                if(value == 6350) {
                    Face = "floor";
Facing = "north";
Powered = true;
                }

                if(value == 6351) {
                    Face = "floor";
Facing = "north";
Powered = false;
                }

                if(value == 6352) {
                    Face = "floor";
Facing = "south";
Powered = true;
                }

                if(value == 6353) {
                    Face = "floor";
Facing = "south";
Powered = false;
                }

                if(value == 6354) {
                    Face = "floor";
Facing = "west";
Powered = true;
                }

                if(value == 6355) {
                    Face = "floor";
Facing = "west";
Powered = false;
                }

                if(value == 6356) {
                    Face = "floor";
Facing = "east";
Powered = true;
                }

                if(value == 6357) {
                    Face = "floor";
Facing = "east";
Powered = false;
                }

                if(value == 6358) {
                    Face = "wall";
Facing = "north";
Powered = true;
                }

                if(value == 6359) {
                    Face = "wall";
Facing = "north";
Powered = false;
                }

                if(value == 6360) {
                    Face = "wall";
Facing = "south";
Powered = true;
                }

                if(value == 6361) {
                    Face = "wall";
Facing = "south";
Powered = false;
                }

                if(value == 6362) {
                    Face = "wall";
Facing = "west";
Powered = true;
                }

                if(value == 6363) {
                    Face = "wall";
Facing = "west";
Powered = false;
                }

                if(value == 6364) {
                    Face = "wall";
Facing = "east";
Powered = true;
                }

                if(value == 6365) {
                    Face = "wall";
Facing = "east";
Powered = false;
                }

                if(value == 6366) {
                    Face = "ceiling";
Facing = "north";
Powered = true;
                }

                if(value == 6367) {
                    Face = "ceiling";
Facing = "north";
Powered = false;
                }

                if(value == 6368) {
                    Face = "ceiling";
Facing = "south";
Powered = true;
                }

                if(value == 6369) {
                    Face = "ceiling";
Facing = "south";
Powered = false;
                }

                if(value == 6370) {
                    Face = "ceiling";
Facing = "west";
Powered = true;
                }

                if(value == 6371) {
                    Face = "ceiling";
Facing = "west";
Powered = false;
                }

                if(value == 6372) {
                    Face = "ceiling";
Facing = "east";
Powered = true;
                }

                if(value == 6373) {
                    Face = "ceiling";
Facing = "east";
Powered = false;
                }

            }
        }

        public string Face { get; set; } = "wall";
        public string Facing { get; set; } = "north";
        public bool Powered { get; set; } = false;

        public BlockOakButton() {
            State = DefaultState;
        }

        public BlockOakButton(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockOakButton(string face, string facing, bool powered) {
            Face = face;
            Facing = facing;
            Powered = powered;
        }
    }
}