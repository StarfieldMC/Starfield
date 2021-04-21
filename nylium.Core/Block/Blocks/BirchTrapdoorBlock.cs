// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class BirchTrapdoorBlock : BaseBlock {

        public Face Facing { get; }
        public Half Half { get; }
        public bool Open { get; }
        public bool Powered { get; }
        public bool Waterlogged { get; }

        public BirchTrapdoorBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 224, 4254) { }

        public BirchTrapdoorBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 224, state) {
            if(state == 4239) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4240) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4241) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4242) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4243) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4244) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4245) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4246) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4247) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4248) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4249) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4250) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4251) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4252) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4253) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4254) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4255) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4256) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4257) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4258) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4259) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4260) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4261) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4262) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4263) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4264) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4265) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4266) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4267) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4268) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4269) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4270) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4271) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4272) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4273) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4274) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4275) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4276) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4277) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4278) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4279) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4280) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4281) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4282) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4283) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4284) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4285) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4286) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4287) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4288) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4289) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4290) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4291) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4292) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4293) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4294) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4295) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4296) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4297) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4298) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4299) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4300) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4301) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4302) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            }
        }

        public BirchTrapdoorBlock(Chunk chunk, int x, int y, int z, Face facing, Half half, bool open, bool powered, bool waterlogged) : base(chunk, x, y, z, 224, 4254) {
if(facing == Face.North && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 4239;
            } else if(facing == Face.North && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 4240;
            } else if(facing == Face.North && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 4241;
            } else if(facing == Face.North && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 4242;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 4243;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 4244;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 4245;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 4246;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 4247;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 4248;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 4249;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 4250;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 4251;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 4252;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 4253;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 4254;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 4255;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 4256;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 4257;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 4258;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 4259;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 4260;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 4261;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 4262;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 4263;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 4264;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 4265;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 4266;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 4267;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 4268;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 4269;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 4270;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 4271;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 4272;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 4273;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 4274;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 4275;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 4276;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 4277;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 4278;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 4279;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 4280;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 4281;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 4282;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 4283;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 4284;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 4285;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 4286;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 4287;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 4288;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 4289;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 4290;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 4291;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 4292;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 4293;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 4294;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 4295;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 4296;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 4297;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 4298;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 4299;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 4300;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 4301;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 4302;
            }
        }
    }
}
