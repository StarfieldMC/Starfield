// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class JungleFenceGateBlock : BaseBlock {

        public Face Facing { get; }
        public bool In_Wall { get; }
        public bool Open { get; }
        public bool Powered { get; }

        public JungleFenceGateBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 477, 8493) { }

        public JungleFenceGateBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 477, state) {
            if(state == 8486) {
                Facing = Face.North;
                In_Wall = true;
                Open = true;
                Powered = true;
            } else if(state == 8487) {
                Facing = Face.North;
                In_Wall = true;
                Open = true;
                Powered = false;
            } else if(state == 8488) {
                Facing = Face.North;
                In_Wall = true;
                Open = false;
                Powered = true;
            } else if(state == 8489) {
                Facing = Face.North;
                In_Wall = true;
                Open = false;
                Powered = false;
            } else if(state == 8490) {
                Facing = Face.North;
                In_Wall = false;
                Open = true;
                Powered = true;
            } else if(state == 8491) {
                Facing = Face.North;
                In_Wall = false;
                Open = true;
                Powered = false;
            } else if(state == 8492) {
                Facing = Face.North;
                In_Wall = false;
                Open = false;
                Powered = true;
            } else if(state == 8493) {
                Facing = Face.North;
                In_Wall = false;
                Open = false;
                Powered = false;
            } else if(state == 8494) {
                Facing = Face.South;
                In_Wall = true;
                Open = true;
                Powered = true;
            } else if(state == 8495) {
                Facing = Face.South;
                In_Wall = true;
                Open = true;
                Powered = false;
            } else if(state == 8496) {
                Facing = Face.South;
                In_Wall = true;
                Open = false;
                Powered = true;
            } else if(state == 8497) {
                Facing = Face.South;
                In_Wall = true;
                Open = false;
                Powered = false;
            } else if(state == 8498) {
                Facing = Face.South;
                In_Wall = false;
                Open = true;
                Powered = true;
            } else if(state == 8499) {
                Facing = Face.South;
                In_Wall = false;
                Open = true;
                Powered = false;
            } else if(state == 8500) {
                Facing = Face.South;
                In_Wall = false;
                Open = false;
                Powered = true;
            } else if(state == 8501) {
                Facing = Face.South;
                In_Wall = false;
                Open = false;
                Powered = false;
            } else if(state == 8502) {
                Facing = Face.West;
                In_Wall = true;
                Open = true;
                Powered = true;
            } else if(state == 8503) {
                Facing = Face.West;
                In_Wall = true;
                Open = true;
                Powered = false;
            } else if(state == 8504) {
                Facing = Face.West;
                In_Wall = true;
                Open = false;
                Powered = true;
            } else if(state == 8505) {
                Facing = Face.West;
                In_Wall = true;
                Open = false;
                Powered = false;
            } else if(state == 8506) {
                Facing = Face.West;
                In_Wall = false;
                Open = true;
                Powered = true;
            } else if(state == 8507) {
                Facing = Face.West;
                In_Wall = false;
                Open = true;
                Powered = false;
            } else if(state == 8508) {
                Facing = Face.West;
                In_Wall = false;
                Open = false;
                Powered = true;
            } else if(state == 8509) {
                Facing = Face.West;
                In_Wall = false;
                Open = false;
                Powered = false;
            } else if(state == 8510) {
                Facing = Face.East;
                In_Wall = true;
                Open = true;
                Powered = true;
            } else if(state == 8511) {
                Facing = Face.East;
                In_Wall = true;
                Open = true;
                Powered = false;
            } else if(state == 8512) {
                Facing = Face.East;
                In_Wall = true;
                Open = false;
                Powered = true;
            } else if(state == 8513) {
                Facing = Face.East;
                In_Wall = true;
                Open = false;
                Powered = false;
            } else if(state == 8514) {
                Facing = Face.East;
                In_Wall = false;
                Open = true;
                Powered = true;
            } else if(state == 8515) {
                Facing = Face.East;
                In_Wall = false;
                Open = true;
                Powered = false;
            } else if(state == 8516) {
                Facing = Face.East;
                In_Wall = false;
                Open = false;
                Powered = true;
            } else if(state == 8517) {
                Facing = Face.East;
                In_Wall = false;
                Open = false;
                Powered = false;
            }
        }

        public JungleFenceGateBlock(Chunk chunk, int x, int y, int z, Face facing, bool in_wall, bool open, bool powered) : base(chunk, x, y, z, 477, 8493) {
if(facing == Face.North && in_wall == true && open == true && powered == true) {
                State = 8486;
            } else if(facing == Face.North && in_wall == true && open == true && powered == false) {
                State = 8487;
            } else if(facing == Face.North && in_wall == true && open == false && powered == true) {
                State = 8488;
            } else if(facing == Face.North && in_wall == true && open == false && powered == false) {
                State = 8489;
            } else if(facing == Face.North && in_wall == false && open == true && powered == true) {
                State = 8490;
            } else if(facing == Face.North && in_wall == false && open == true && powered == false) {
                State = 8491;
            } else if(facing == Face.North && in_wall == false && open == false && powered == true) {
                State = 8492;
            } else if(facing == Face.North && in_wall == false && open == false && powered == false) {
                State = 8493;
            } else if(facing == Face.South && in_wall == true && open == true && powered == true) {
                State = 8494;
            } else if(facing == Face.South && in_wall == true && open == true && powered == false) {
                State = 8495;
            } else if(facing == Face.South && in_wall == true && open == false && powered == true) {
                State = 8496;
            } else if(facing == Face.South && in_wall == true && open == false && powered == false) {
                State = 8497;
            } else if(facing == Face.South && in_wall == false && open == true && powered == true) {
                State = 8498;
            } else if(facing == Face.South && in_wall == false && open == true && powered == false) {
                State = 8499;
            } else if(facing == Face.South && in_wall == false && open == false && powered == true) {
                State = 8500;
            } else if(facing == Face.South && in_wall == false && open == false && powered == false) {
                State = 8501;
            } else if(facing == Face.West && in_wall == true && open == true && powered == true) {
                State = 8502;
            } else if(facing == Face.West && in_wall == true && open == true && powered == false) {
                State = 8503;
            } else if(facing == Face.West && in_wall == true && open == false && powered == true) {
                State = 8504;
            } else if(facing == Face.West && in_wall == true && open == false && powered == false) {
                State = 8505;
            } else if(facing == Face.West && in_wall == false && open == true && powered == true) {
                State = 8506;
            } else if(facing == Face.West && in_wall == false && open == true && powered == false) {
                State = 8507;
            } else if(facing == Face.West && in_wall == false && open == false && powered == true) {
                State = 8508;
            } else if(facing == Face.West && in_wall == false && open == false && powered == false) {
                State = 8509;
            } else if(facing == Face.East && in_wall == true && open == true && powered == true) {
                State = 8510;
            } else if(facing == Face.East && in_wall == true && open == true && powered == false) {
                State = 8511;
            } else if(facing == Face.East && in_wall == true && open == false && powered == true) {
                State = 8512;
            } else if(facing == Face.East && in_wall == true && open == false && powered == false) {
                State = 8513;
            } else if(facing == Face.East && in_wall == false && open == true && powered == true) {
                State = 8514;
            } else if(facing == Face.East && in_wall == false && open == true && powered == false) {
                State = 8515;
            } else if(facing == Face.East && in_wall == false && open == false && powered == true) {
                State = 8516;
            } else if(facing == Face.East && in_wall == false && open == false && powered == false) {
                State = 8517;
            }
        }
    }
}
