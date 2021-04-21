// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class AcaciaFenceGateBlock : BaseBlock {

        public Face Facing { get; }
        public bool In_Wall { get; }
        public bool Open { get; }
        public bool Powered { get; }

        public AcaciaFenceGateBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 478, 8525) { }

        public AcaciaFenceGateBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 478, state) {
            if(state == 8518) {
                Facing = Face.North;
                In_Wall = true;
                Open = true;
                Powered = true;
            } else if(state == 8519) {
                Facing = Face.North;
                In_Wall = true;
                Open = true;
                Powered = false;
            } else if(state == 8520) {
                Facing = Face.North;
                In_Wall = true;
                Open = false;
                Powered = true;
            } else if(state == 8521) {
                Facing = Face.North;
                In_Wall = true;
                Open = false;
                Powered = false;
            } else if(state == 8522) {
                Facing = Face.North;
                In_Wall = false;
                Open = true;
                Powered = true;
            } else if(state == 8523) {
                Facing = Face.North;
                In_Wall = false;
                Open = true;
                Powered = false;
            } else if(state == 8524) {
                Facing = Face.North;
                In_Wall = false;
                Open = false;
                Powered = true;
            } else if(state == 8525) {
                Facing = Face.North;
                In_Wall = false;
                Open = false;
                Powered = false;
            } else if(state == 8526) {
                Facing = Face.South;
                In_Wall = true;
                Open = true;
                Powered = true;
            } else if(state == 8527) {
                Facing = Face.South;
                In_Wall = true;
                Open = true;
                Powered = false;
            } else if(state == 8528) {
                Facing = Face.South;
                In_Wall = true;
                Open = false;
                Powered = true;
            } else if(state == 8529) {
                Facing = Face.South;
                In_Wall = true;
                Open = false;
                Powered = false;
            } else if(state == 8530) {
                Facing = Face.South;
                In_Wall = false;
                Open = true;
                Powered = true;
            } else if(state == 8531) {
                Facing = Face.South;
                In_Wall = false;
                Open = true;
                Powered = false;
            } else if(state == 8532) {
                Facing = Face.South;
                In_Wall = false;
                Open = false;
                Powered = true;
            } else if(state == 8533) {
                Facing = Face.South;
                In_Wall = false;
                Open = false;
                Powered = false;
            } else if(state == 8534) {
                Facing = Face.West;
                In_Wall = true;
                Open = true;
                Powered = true;
            } else if(state == 8535) {
                Facing = Face.West;
                In_Wall = true;
                Open = true;
                Powered = false;
            } else if(state == 8536) {
                Facing = Face.West;
                In_Wall = true;
                Open = false;
                Powered = true;
            } else if(state == 8537) {
                Facing = Face.West;
                In_Wall = true;
                Open = false;
                Powered = false;
            } else if(state == 8538) {
                Facing = Face.West;
                In_Wall = false;
                Open = true;
                Powered = true;
            } else if(state == 8539) {
                Facing = Face.West;
                In_Wall = false;
                Open = true;
                Powered = false;
            } else if(state == 8540) {
                Facing = Face.West;
                In_Wall = false;
                Open = false;
                Powered = true;
            } else if(state == 8541) {
                Facing = Face.West;
                In_Wall = false;
                Open = false;
                Powered = false;
            } else if(state == 8542) {
                Facing = Face.East;
                In_Wall = true;
                Open = true;
                Powered = true;
            } else if(state == 8543) {
                Facing = Face.East;
                In_Wall = true;
                Open = true;
                Powered = false;
            } else if(state == 8544) {
                Facing = Face.East;
                In_Wall = true;
                Open = false;
                Powered = true;
            } else if(state == 8545) {
                Facing = Face.East;
                In_Wall = true;
                Open = false;
                Powered = false;
            } else if(state == 8546) {
                Facing = Face.East;
                In_Wall = false;
                Open = true;
                Powered = true;
            } else if(state == 8547) {
                Facing = Face.East;
                In_Wall = false;
                Open = true;
                Powered = false;
            } else if(state == 8548) {
                Facing = Face.East;
                In_Wall = false;
                Open = false;
                Powered = true;
            } else if(state == 8549) {
                Facing = Face.East;
                In_Wall = false;
                Open = false;
                Powered = false;
            }
        }

        public AcaciaFenceGateBlock(Chunk chunk, int x, int y, int z, Face facing, bool in_wall, bool open, bool powered) : base(chunk, x, y, z, 478, 8525) {
if(facing == Face.North && in_wall == true && open == true && powered == true) {
                State = 8518;
            } else if(facing == Face.North && in_wall == true && open == true && powered == false) {
                State = 8519;
            } else if(facing == Face.North && in_wall == true && open == false && powered == true) {
                State = 8520;
            } else if(facing == Face.North && in_wall == true && open == false && powered == false) {
                State = 8521;
            } else if(facing == Face.North && in_wall == false && open == true && powered == true) {
                State = 8522;
            } else if(facing == Face.North && in_wall == false && open == true && powered == false) {
                State = 8523;
            } else if(facing == Face.North && in_wall == false && open == false && powered == true) {
                State = 8524;
            } else if(facing == Face.North && in_wall == false && open == false && powered == false) {
                State = 8525;
            } else if(facing == Face.South && in_wall == true && open == true && powered == true) {
                State = 8526;
            } else if(facing == Face.South && in_wall == true && open == true && powered == false) {
                State = 8527;
            } else if(facing == Face.South && in_wall == true && open == false && powered == true) {
                State = 8528;
            } else if(facing == Face.South && in_wall == true && open == false && powered == false) {
                State = 8529;
            } else if(facing == Face.South && in_wall == false && open == true && powered == true) {
                State = 8530;
            } else if(facing == Face.South && in_wall == false && open == true && powered == false) {
                State = 8531;
            } else if(facing == Face.South && in_wall == false && open == false && powered == true) {
                State = 8532;
            } else if(facing == Face.South && in_wall == false && open == false && powered == false) {
                State = 8533;
            } else if(facing == Face.West && in_wall == true && open == true && powered == true) {
                State = 8534;
            } else if(facing == Face.West && in_wall == true && open == true && powered == false) {
                State = 8535;
            } else if(facing == Face.West && in_wall == true && open == false && powered == true) {
                State = 8536;
            } else if(facing == Face.West && in_wall == true && open == false && powered == false) {
                State = 8537;
            } else if(facing == Face.West && in_wall == false && open == true && powered == true) {
                State = 8538;
            } else if(facing == Face.West && in_wall == false && open == true && powered == false) {
                State = 8539;
            } else if(facing == Face.West && in_wall == false && open == false && powered == true) {
                State = 8540;
            } else if(facing == Face.West && in_wall == false && open == false && powered == false) {
                State = 8541;
            } else if(facing == Face.East && in_wall == true && open == true && powered == true) {
                State = 8542;
            } else if(facing == Face.East && in_wall == true && open == true && powered == false) {
                State = 8543;
            } else if(facing == Face.East && in_wall == true && open == false && powered == true) {
                State = 8544;
            } else if(facing == Face.East && in_wall == true && open == false && powered == false) {
                State = 8545;
            } else if(facing == Face.East && in_wall == false && open == true && powered == true) {
                State = 8546;
            } else if(facing == Face.East && in_wall == false && open == true && powered == false) {
                State = 8547;
            } else if(facing == Face.East && in_wall == false && open == false && powered == true) {
                State = 8548;
            } else if(facing == Face.East && in_wall == false && open == false && powered == false) {
                State = 8549;
            }
        }
    }
}
