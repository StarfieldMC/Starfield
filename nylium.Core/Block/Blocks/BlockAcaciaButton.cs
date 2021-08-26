// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:acacia_button", 312, 6446, 6469, 6455)]
    public class BlockAcaciaButton : BlockBase {

        public override ushort State {
            get {
                if(Face == "floor" && Facing == "north" && Powered == true) {
                    return 6446;
                }

                if(Face == "floor" && Facing == "north" && Powered == false) {
                    return 6447;
                }

                if(Face == "floor" && Facing == "south" && Powered == true) {
                    return 6448;
                }

                if(Face == "floor" && Facing == "south" && Powered == false) {
                    return 6449;
                }

                if(Face == "floor" && Facing == "west" && Powered == true) {
                    return 6450;
                }

                if(Face == "floor" && Facing == "west" && Powered == false) {
                    return 6451;
                }

                if(Face == "floor" && Facing == "east" && Powered == true) {
                    return 6452;
                }

                if(Face == "floor" && Facing == "east" && Powered == false) {
                    return 6453;
                }

                if(Face == "wall" && Facing == "north" && Powered == true) {
                    return 6454;
                }

                if(Face == "wall" && Facing == "north" && Powered == false) {
                    return 6455;
                }

                if(Face == "wall" && Facing == "south" && Powered == true) {
                    return 6456;
                }

                if(Face == "wall" && Facing == "south" && Powered == false) {
                    return 6457;
                }

                if(Face == "wall" && Facing == "west" && Powered == true) {
                    return 6458;
                }

                if(Face == "wall" && Facing == "west" && Powered == false) {
                    return 6459;
                }

                if(Face == "wall" && Facing == "east" && Powered == true) {
                    return 6460;
                }

                if(Face == "wall" && Facing == "east" && Powered == false) {
                    return 6461;
                }

                if(Face == "ceiling" && Facing == "north" && Powered == true) {
                    return 6462;
                }

                if(Face == "ceiling" && Facing == "north" && Powered == false) {
                    return 6463;
                }

                if(Face == "ceiling" && Facing == "south" && Powered == true) {
                    return 6464;
                }

                if(Face == "ceiling" && Facing == "south" && Powered == false) {
                    return 6465;
                }

                if(Face == "ceiling" && Facing == "west" && Powered == true) {
                    return 6466;
                }

                if(Face == "ceiling" && Facing == "west" && Powered == false) {
                    return 6467;
                }

                if(Face == "ceiling" && Facing == "east" && Powered == true) {
                    return 6468;
                }

                if(Face == "ceiling" && Facing == "east" && Powered == false) {
                    return 6469;
                }

                return DefaultState;
            }

            set {
                if(value == 6446) {
                    Face = "floor";
Facing = "north";
Powered = true;
                }

                if(value == 6447) {
                    Face = "floor";
Facing = "north";
Powered = false;
                }

                if(value == 6448) {
                    Face = "floor";
Facing = "south";
Powered = true;
                }

                if(value == 6449) {
                    Face = "floor";
Facing = "south";
Powered = false;
                }

                if(value == 6450) {
                    Face = "floor";
Facing = "west";
Powered = true;
                }

                if(value == 6451) {
                    Face = "floor";
Facing = "west";
Powered = false;
                }

                if(value == 6452) {
                    Face = "floor";
Facing = "east";
Powered = true;
                }

                if(value == 6453) {
                    Face = "floor";
Facing = "east";
Powered = false;
                }

                if(value == 6454) {
                    Face = "wall";
Facing = "north";
Powered = true;
                }

                if(value == 6455) {
                    Face = "wall";
Facing = "north";
Powered = false;
                }

                if(value == 6456) {
                    Face = "wall";
Facing = "south";
Powered = true;
                }

                if(value == 6457) {
                    Face = "wall";
Facing = "south";
Powered = false;
                }

                if(value == 6458) {
                    Face = "wall";
Facing = "west";
Powered = true;
                }

                if(value == 6459) {
                    Face = "wall";
Facing = "west";
Powered = false;
                }

                if(value == 6460) {
                    Face = "wall";
Facing = "east";
Powered = true;
                }

                if(value == 6461) {
                    Face = "wall";
Facing = "east";
Powered = false;
                }

                if(value == 6462) {
                    Face = "ceiling";
Facing = "north";
Powered = true;
                }

                if(value == 6463) {
                    Face = "ceiling";
Facing = "north";
Powered = false;
                }

                if(value == 6464) {
                    Face = "ceiling";
Facing = "south";
Powered = true;
                }

                if(value == 6465) {
                    Face = "ceiling";
Facing = "south";
Powered = false;
                }

                if(value == 6466) {
                    Face = "ceiling";
Facing = "west";
Powered = true;
                }

                if(value == 6467) {
                    Face = "ceiling";
Facing = "west";
Powered = false;
                }

                if(value == 6468) {
                    Face = "ceiling";
Facing = "east";
Powered = true;
                }

                if(value == 6469) {
                    Face = "ceiling";
Facing = "east";
Powered = false;
                }

            }
        }

        public string Face { get; set; } = "wall";
        public string Facing { get; set; } = "north";
        public bool Powered { get; set; } = false;

        public BlockAcaciaButton() {
            State = DefaultState;
        }

        public BlockAcaciaButton(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockAcaciaButton(string face, string facing, bool powered) {
            Face = face;
            Facing = facing;
            Powered = powered;
        }
    }
}