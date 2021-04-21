// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class SpruceTrapdoorBlock : BaseBlock {

        public Face Facing { get; }
        public Half Half { get; }
        public bool Open { get; }
        public bool Powered { get; }
        public bool Waterlogged { get; }

        public SpruceTrapdoorBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 223, 4190) { }

        public SpruceTrapdoorBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 223, state) {
            if(state == 4175) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4176) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4177) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4178) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4179) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4180) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4181) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4182) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4183) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4184) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4185) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4186) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4187) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4188) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4189) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4190) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4191) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4192) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4193) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4194) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4195) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4196) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4197) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4198) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4199) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4200) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4201) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4202) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4203) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4204) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4205) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4206) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4207) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4208) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4209) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4210) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4211) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4212) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4213) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4214) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4215) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4216) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4217) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4218) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4219) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4220) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4221) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4222) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4223) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4224) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4225) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4226) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4227) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4228) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4229) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4230) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4231) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4232) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4233) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4234) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4235) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4236) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4237) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4238) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            }
        }

        public SpruceTrapdoorBlock(Chunk chunk, int x, int y, int z, Face facing, Half half, bool open, bool powered, bool waterlogged) : base(chunk, x, y, z, 223, 4190) {
if(facing == Face.North && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 4175;
            } else if(facing == Face.North && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 4176;
            } else if(facing == Face.North && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 4177;
            } else if(facing == Face.North && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 4178;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 4179;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 4180;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 4181;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 4182;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 4183;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 4184;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 4185;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 4186;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 4187;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 4188;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 4189;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 4190;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 4191;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 4192;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 4193;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 4194;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 4195;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 4196;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 4197;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 4198;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 4199;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 4200;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 4201;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 4202;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 4203;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 4204;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 4205;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 4206;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 4207;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 4208;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 4209;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 4210;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 4211;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 4212;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 4213;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 4214;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 4215;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 4216;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 4217;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 4218;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 4219;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 4220;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 4221;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 4222;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 4223;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 4224;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 4225;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 4226;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 4227;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 4228;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 4229;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 4230;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 4231;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 4232;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 4233;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 4234;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 4235;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 4236;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 4237;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 4238;
            }
        }
    }
}
