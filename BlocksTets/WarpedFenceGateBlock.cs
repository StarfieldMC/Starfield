// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class WarpedFenceGateBlock : BaseBlock {

        public Face Facing { get; }
        public bool In_Wall { get; }
        public bool Open { get; }
        public bool Powered { get; }

        public WarpedFenceGateBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 715, 15302) { }

        public WarpedFenceGateBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 715, state) {
            if(state == 15295) {
                Facing = Face.North;
                In_Wall = true;
                Open = true;
                Powered = true;
            } else if(state == 15296) {
                Facing = Face.North;
                In_Wall = true;
                Open = true;
                Powered = false;
            } else if(state == 15297) {
                Facing = Face.North;
                In_Wall = true;
                Open = false;
                Powered = true;
            } else if(state == 15298) {
                Facing = Face.North;
                In_Wall = true;
                Open = false;
                Powered = false;
            } else if(state == 15299) {
                Facing = Face.North;
                In_Wall = false;
                Open = true;
                Powered = true;
            } else if(state == 15300) {
                Facing = Face.North;
                In_Wall = false;
                Open = true;
                Powered = false;
            } else if(state == 15301) {
                Facing = Face.North;
                In_Wall = false;
                Open = false;
                Powered = true;
            } else if(state == 15302) {
                Facing = Face.North;
                In_Wall = false;
                Open = false;
                Powered = false;
            } else if(state == 15303) {
                Facing = Face.South;
                In_Wall = true;
                Open = true;
                Powered = true;
            } else if(state == 15304) {
                Facing = Face.South;
                In_Wall = true;
                Open = true;
                Powered = false;
            } else if(state == 15305) {
                Facing = Face.South;
                In_Wall = true;
                Open = false;
                Powered = true;
            } else if(state == 15306) {
                Facing = Face.South;
                In_Wall = true;
                Open = false;
                Powered = false;
            } else if(state == 15307) {
                Facing = Face.South;
                In_Wall = false;
                Open = true;
                Powered = true;
            } else if(state == 15308) {
                Facing = Face.South;
                In_Wall = false;
                Open = true;
                Powered = false;
            } else if(state == 15309) {
                Facing = Face.South;
                In_Wall = false;
                Open = false;
                Powered = true;
            } else if(state == 15310) {
                Facing = Face.South;
                In_Wall = false;
                Open = false;
                Powered = false;
            } else if(state == 15311) {
                Facing = Face.West;
                In_Wall = true;
                Open = true;
                Powered = true;
            } else if(state == 15312) {
                Facing = Face.West;
                In_Wall = true;
                Open = true;
                Powered = false;
            } else if(state == 15313) {
                Facing = Face.West;
                In_Wall = true;
                Open = false;
                Powered = true;
            } else if(state == 15314) {
                Facing = Face.West;
                In_Wall = true;
                Open = false;
                Powered = false;
            } else if(state == 15315) {
                Facing = Face.West;
                In_Wall = false;
                Open = true;
                Powered = true;
            } else if(state == 15316) {
                Facing = Face.West;
                In_Wall = false;
                Open = true;
                Powered = false;
            } else if(state == 15317) {
                Facing = Face.West;
                In_Wall = false;
                Open = false;
                Powered = true;
            } else if(state == 15318) {
                Facing = Face.West;
                In_Wall = false;
                Open = false;
                Powered = false;
            } else if(state == 15319) {
                Facing = Face.East;
                In_Wall = true;
                Open = true;
                Powered = true;
            } else if(state == 15320) {
                Facing = Face.East;
                In_Wall = true;
                Open = true;
                Powered = false;
            } else if(state == 15321) {
                Facing = Face.East;
                In_Wall = true;
                Open = false;
                Powered = true;
            } else if(state == 15322) {
                Facing = Face.East;
                In_Wall = true;
                Open = false;
                Powered = false;
            } else if(state == 15323) {
                Facing = Face.East;
                In_Wall = false;
                Open = true;
                Powered = true;
            } else if(state == 15324) {
                Facing = Face.East;
                In_Wall = false;
                Open = true;
                Powered = false;
            } else if(state == 15325) {
                Facing = Face.East;
                In_Wall = false;
                Open = false;
                Powered = true;
            } else if(state == 15326) {
                Facing = Face.East;
                In_Wall = false;
                Open = false;
                Powered = false;
            }
        }

        public WarpedFenceGateBlock(Chunk chunk, int x, int y, int z, Face facing, bool in_wall, bool open, bool powered) : base(chunk, x, y, z, 715, 15302) {
if(facing == Face.North && in_wall == true && open == true && powered == true) {
                State = 15295;
            } else if(facing == Face.North && in_wall == true && open == true && powered == false) {
                State = 15296;
            } else if(facing == Face.North && in_wall == true && open == false && powered == true) {
                State = 15297;
            } else if(facing == Face.North && in_wall == true && open == false && powered == false) {
                State = 15298;
            } else if(facing == Face.North && in_wall == false && open == true && powered == true) {
                State = 15299;
            } else if(facing == Face.North && in_wall == false && open == true && powered == false) {
                State = 15300;
            } else if(facing == Face.North && in_wall == false && open == false && powered == true) {
                State = 15301;
            } else if(facing == Face.North && in_wall == false && open == false && powered == false) {
                State = 15302;
            } else if(facing == Face.South && in_wall == true && open == true && powered == true) {
                State = 15303;
            } else if(facing == Face.South && in_wall == true && open == true && powered == false) {
                State = 15304;
            } else if(facing == Face.South && in_wall == true && open == false && powered == true) {
                State = 15305;
            } else if(facing == Face.South && in_wall == true && open == false && powered == false) {
                State = 15306;
            } else if(facing == Face.South && in_wall == false && open == true && powered == true) {
                State = 15307;
            } else if(facing == Face.South && in_wall == false && open == true && powered == false) {
                State = 15308;
            } else if(facing == Face.South && in_wall == false && open == false && powered == true) {
                State = 15309;
            } else if(facing == Face.South && in_wall == false && open == false && powered == false) {
                State = 15310;
            } else if(facing == Face.West && in_wall == true && open == true && powered == true) {
                State = 15311;
            } else if(facing == Face.West && in_wall == true && open == true && powered == false) {
                State = 15312;
            } else if(facing == Face.West && in_wall == true && open == false && powered == true) {
                State = 15313;
            } else if(facing == Face.West && in_wall == true && open == false && powered == false) {
                State = 15314;
            } else if(facing == Face.West && in_wall == false && open == true && powered == true) {
                State = 15315;
            } else if(facing == Face.West && in_wall == false && open == true && powered == false) {
                State = 15316;
            } else if(facing == Face.West && in_wall == false && open == false && powered == true) {
                State = 15317;
            } else if(facing == Face.West && in_wall == false && open == false && powered == false) {
                State = 15318;
            } else if(facing == Face.East && in_wall == true && open == true && powered == true) {
                State = 15319;
            } else if(facing == Face.East && in_wall == true && open == true && powered == false) {
                State = 15320;
            } else if(facing == Face.East && in_wall == true && open == false && powered == true) {
                State = 15321;
            } else if(facing == Face.East && in_wall == true && open == false && powered == false) {
                State = 15322;
            } else if(facing == Face.East && in_wall == false && open == true && powered == true) {
                State = 15323;
            } else if(facing == Face.East && in_wall == false && open == true && powered == false) {
                State = 15324;
            } else if(facing == Face.East && in_wall == false && open == false && powered == true) {
                State = 15325;
            } else if(facing == Face.East && in_wall == false && open == false && powered == false) {
                State = 15326;
            }
        }
    }
}
