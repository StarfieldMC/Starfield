// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class OakTrapdoorBlock : BaseBlock {

        public Face Facing { get; }
        public Half Half { get; }
        public bool Open { get; }
        public bool Powered { get; }
        public bool Waterlogged { get; }

        public OakTrapdoorBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 222, 4126) { }

        public OakTrapdoorBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 222, state) {
            if(state == 4111) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4112) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4113) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4114) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4115) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4116) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4117) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4118) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4119) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4120) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4121) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4122) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4123) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4124) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4125) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4126) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4127) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4128) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4129) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4130) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4131) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4132) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4133) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4134) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4135) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4136) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4137) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4138) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4139) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4140) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4141) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4142) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4143) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4144) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4145) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4146) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4147) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4148) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4149) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4150) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4151) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4152) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4153) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4154) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4155) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4156) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4157) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4158) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4159) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4160) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4161) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4162) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4163) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4164) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4165) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4166) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4167) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4168) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4169) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4170) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 4171) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 4172) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 4173) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 4174) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            }
        }

        public OakTrapdoorBlock(Chunk chunk, int x, int y, int z, Face facing, Half half, bool open, bool powered, bool waterlogged) : base(chunk, x, y, z, 222, 4126) {
if(facing == Face.North && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 4111;
            } else if(facing == Face.North && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 4112;
            } else if(facing == Face.North && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 4113;
            } else if(facing == Face.North && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 4114;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 4115;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 4116;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 4117;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 4118;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 4119;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 4120;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 4121;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 4122;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 4123;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 4124;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 4125;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 4126;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 4127;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 4128;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 4129;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 4130;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 4131;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 4132;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 4133;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 4134;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 4135;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 4136;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 4137;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 4138;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 4139;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 4140;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 4141;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 4142;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 4143;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 4144;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 4145;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 4146;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 4147;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 4148;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 4149;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 4150;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 4151;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 4152;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 4153;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 4154;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 4155;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 4156;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 4157;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 4158;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 4159;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 4160;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 4161;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 4162;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 4163;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 4164;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 4165;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 4166;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 4167;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 4168;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 4169;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 4170;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 4171;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 4172;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 4173;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 4174;
            }
        }
    }
}
