// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockBirchTrapdoor : BlockBase {

        public override string Id { get { return "minecraft:birch_trapdoor"; } }

        public override ushort MinimumState { get { return 4239; } }
        public override ushort MaximumState { get { return 4302; } }
        public override ushort DefaultState { get { return 4254; } }

        public override ushort State {
            get {
                if(Facing == "north" && Half == "top" && Open == true && Powered == true && Waterlogged == true) {
                    return 4239;
                }

                if(Facing == "north" && Half == "top" && Open == true && Powered == true && Waterlogged == false) {
                    return 4240;
                }

                if(Facing == "north" && Half == "top" && Open == true && Powered == false && Waterlogged == true) {
                    return 4241;
                }

                if(Facing == "north" && Half == "top" && Open == true && Powered == false && Waterlogged == false) {
                    return 4242;
                }

                if(Facing == "north" && Half == "top" && Open == false && Powered == true && Waterlogged == true) {
                    return 4243;
                }

                if(Facing == "north" && Half == "top" && Open == false && Powered == true && Waterlogged == false) {
                    return 4244;
                }

                if(Facing == "north" && Half == "top" && Open == false && Powered == false && Waterlogged == true) {
                    return 4245;
                }

                if(Facing == "north" && Half == "top" && Open == false && Powered == false && Waterlogged == false) {
                    return 4246;
                }

                if(Facing == "north" && Half == "bottom" && Open == true && Powered == true && Waterlogged == true) {
                    return 4247;
                }

                if(Facing == "north" && Half == "bottom" && Open == true && Powered == true && Waterlogged == false) {
                    return 4248;
                }

                if(Facing == "north" && Half == "bottom" && Open == true && Powered == false && Waterlogged == true) {
                    return 4249;
                }

                if(Facing == "north" && Half == "bottom" && Open == true && Powered == false && Waterlogged == false) {
                    return 4250;
                }

                if(Facing == "north" && Half == "bottom" && Open == false && Powered == true && Waterlogged == true) {
                    return 4251;
                }

                if(Facing == "north" && Half == "bottom" && Open == false && Powered == true && Waterlogged == false) {
                    return 4252;
                }

                if(Facing == "north" && Half == "bottom" && Open == false && Powered == false && Waterlogged == true) {
                    return 4253;
                }

                if(Facing == "north" && Half == "bottom" && Open == false && Powered == false && Waterlogged == false) {
                    return 4254;
                }

                if(Facing == "south" && Half == "top" && Open == true && Powered == true && Waterlogged == true) {
                    return 4255;
                }

                if(Facing == "south" && Half == "top" && Open == true && Powered == true && Waterlogged == false) {
                    return 4256;
                }

                if(Facing == "south" && Half == "top" && Open == true && Powered == false && Waterlogged == true) {
                    return 4257;
                }

                if(Facing == "south" && Half == "top" && Open == true && Powered == false && Waterlogged == false) {
                    return 4258;
                }

                if(Facing == "south" && Half == "top" && Open == false && Powered == true && Waterlogged == true) {
                    return 4259;
                }

                if(Facing == "south" && Half == "top" && Open == false && Powered == true && Waterlogged == false) {
                    return 4260;
                }

                if(Facing == "south" && Half == "top" && Open == false && Powered == false && Waterlogged == true) {
                    return 4261;
                }

                if(Facing == "south" && Half == "top" && Open == false && Powered == false && Waterlogged == false) {
                    return 4262;
                }

                if(Facing == "south" && Half == "bottom" && Open == true && Powered == true && Waterlogged == true) {
                    return 4263;
                }

                if(Facing == "south" && Half == "bottom" && Open == true && Powered == true && Waterlogged == false) {
                    return 4264;
                }

                if(Facing == "south" && Half == "bottom" && Open == true && Powered == false && Waterlogged == true) {
                    return 4265;
                }

                if(Facing == "south" && Half == "bottom" && Open == true && Powered == false && Waterlogged == false) {
                    return 4266;
                }

                if(Facing == "south" && Half == "bottom" && Open == false && Powered == true && Waterlogged == true) {
                    return 4267;
                }

                if(Facing == "south" && Half == "bottom" && Open == false && Powered == true && Waterlogged == false) {
                    return 4268;
                }

                if(Facing == "south" && Half == "bottom" && Open == false && Powered == false && Waterlogged == true) {
                    return 4269;
                }

                if(Facing == "south" && Half == "bottom" && Open == false && Powered == false && Waterlogged == false) {
                    return 4270;
                }

                if(Facing == "west" && Half == "top" && Open == true && Powered == true && Waterlogged == true) {
                    return 4271;
                }

                if(Facing == "west" && Half == "top" && Open == true && Powered == true && Waterlogged == false) {
                    return 4272;
                }

                if(Facing == "west" && Half == "top" && Open == true && Powered == false && Waterlogged == true) {
                    return 4273;
                }

                if(Facing == "west" && Half == "top" && Open == true && Powered == false && Waterlogged == false) {
                    return 4274;
                }

                if(Facing == "west" && Half == "top" && Open == false && Powered == true && Waterlogged == true) {
                    return 4275;
                }

                if(Facing == "west" && Half == "top" && Open == false && Powered == true && Waterlogged == false) {
                    return 4276;
                }

                if(Facing == "west" && Half == "top" && Open == false && Powered == false && Waterlogged == true) {
                    return 4277;
                }

                if(Facing == "west" && Half == "top" && Open == false && Powered == false && Waterlogged == false) {
                    return 4278;
                }

                if(Facing == "west" && Half == "bottom" && Open == true && Powered == true && Waterlogged == true) {
                    return 4279;
                }

                if(Facing == "west" && Half == "bottom" && Open == true && Powered == true && Waterlogged == false) {
                    return 4280;
                }

                if(Facing == "west" && Half == "bottom" && Open == true && Powered == false && Waterlogged == true) {
                    return 4281;
                }

                if(Facing == "west" && Half == "bottom" && Open == true && Powered == false && Waterlogged == false) {
                    return 4282;
                }

                if(Facing == "west" && Half == "bottom" && Open == false && Powered == true && Waterlogged == true) {
                    return 4283;
                }

                if(Facing == "west" && Half == "bottom" && Open == false && Powered == true && Waterlogged == false) {
                    return 4284;
                }

                if(Facing == "west" && Half == "bottom" && Open == false && Powered == false && Waterlogged == true) {
                    return 4285;
                }

                if(Facing == "west" && Half == "bottom" && Open == false && Powered == false && Waterlogged == false) {
                    return 4286;
                }

                if(Facing == "east" && Half == "top" && Open == true && Powered == true && Waterlogged == true) {
                    return 4287;
                }

                if(Facing == "east" && Half == "top" && Open == true && Powered == true && Waterlogged == false) {
                    return 4288;
                }

                if(Facing == "east" && Half == "top" && Open == true && Powered == false && Waterlogged == true) {
                    return 4289;
                }

                if(Facing == "east" && Half == "top" && Open == true && Powered == false && Waterlogged == false) {
                    return 4290;
                }

                if(Facing == "east" && Half == "top" && Open == false && Powered == true && Waterlogged == true) {
                    return 4291;
                }

                if(Facing == "east" && Half == "top" && Open == false && Powered == true && Waterlogged == false) {
                    return 4292;
                }

                if(Facing == "east" && Half == "top" && Open == false && Powered == false && Waterlogged == true) {
                    return 4293;
                }

                if(Facing == "east" && Half == "top" && Open == false && Powered == false && Waterlogged == false) {
                    return 4294;
                }

                if(Facing == "east" && Half == "bottom" && Open == true && Powered == true && Waterlogged == true) {
                    return 4295;
                }

                if(Facing == "east" && Half == "bottom" && Open == true && Powered == true && Waterlogged == false) {
                    return 4296;
                }

                if(Facing == "east" && Half == "bottom" && Open == true && Powered == false && Waterlogged == true) {
                    return 4297;
                }

                if(Facing == "east" && Half == "bottom" && Open == true && Powered == false && Waterlogged == false) {
                    return 4298;
                }

                if(Facing == "east" && Half == "bottom" && Open == false && Powered == true && Waterlogged == true) {
                    return 4299;
                }

                if(Facing == "east" && Half == "bottom" && Open == false && Powered == true && Waterlogged == false) {
                    return 4300;
                }

                if(Facing == "east" && Half == "bottom" && Open == false && Powered == false && Waterlogged == true) {
                    return 4301;
                }

                if(Facing == "east" && Half == "bottom" && Open == false && Powered == false && Waterlogged == false) {
                    return 4302;
                }

                return DefaultState;
            }

            set {
                if(value == 4239) {
                    Facing = "north";
Half = "top";
Open = true;
Powered = true;
Waterlogged = true;
                }

                if(value == 4240) {
                    Facing = "north";
Half = "top";
Open = true;
Powered = true;
Waterlogged = false;
                }

                if(value == 4241) {
                    Facing = "north";
Half = "top";
Open = true;
Powered = false;
Waterlogged = true;
                }

                if(value == 4242) {
                    Facing = "north";
Half = "top";
Open = true;
Powered = false;
Waterlogged = false;
                }

                if(value == 4243) {
                    Facing = "north";
Half = "top";
Open = false;
Powered = true;
Waterlogged = true;
                }

                if(value == 4244) {
                    Facing = "north";
Half = "top";
Open = false;
Powered = true;
Waterlogged = false;
                }

                if(value == 4245) {
                    Facing = "north";
Half = "top";
Open = false;
Powered = false;
Waterlogged = true;
                }

                if(value == 4246) {
                    Facing = "north";
Half = "top";
Open = false;
Powered = false;
Waterlogged = false;
                }

                if(value == 4247) {
                    Facing = "north";
Half = "bottom";
Open = true;
Powered = true;
Waterlogged = true;
                }

                if(value == 4248) {
                    Facing = "north";
Half = "bottom";
Open = true;
Powered = true;
Waterlogged = false;
                }

                if(value == 4249) {
                    Facing = "north";
Half = "bottom";
Open = true;
Powered = false;
Waterlogged = true;
                }

                if(value == 4250) {
                    Facing = "north";
Half = "bottom";
Open = true;
Powered = false;
Waterlogged = false;
                }

                if(value == 4251) {
                    Facing = "north";
Half = "bottom";
Open = false;
Powered = true;
Waterlogged = true;
                }

                if(value == 4252) {
                    Facing = "north";
Half = "bottom";
Open = false;
Powered = true;
Waterlogged = false;
                }

                if(value == 4253) {
                    Facing = "north";
Half = "bottom";
Open = false;
Powered = false;
Waterlogged = true;
                }

                if(value == 4254) {
                    Facing = "north";
Half = "bottom";
Open = false;
Powered = false;
Waterlogged = false;
                }

                if(value == 4255) {
                    Facing = "south";
Half = "top";
Open = true;
Powered = true;
Waterlogged = true;
                }

                if(value == 4256) {
                    Facing = "south";
Half = "top";
Open = true;
Powered = true;
Waterlogged = false;
                }

                if(value == 4257) {
                    Facing = "south";
Half = "top";
Open = true;
Powered = false;
Waterlogged = true;
                }

                if(value == 4258) {
                    Facing = "south";
Half = "top";
Open = true;
Powered = false;
Waterlogged = false;
                }

                if(value == 4259) {
                    Facing = "south";
Half = "top";
Open = false;
Powered = true;
Waterlogged = true;
                }

                if(value == 4260) {
                    Facing = "south";
Half = "top";
Open = false;
Powered = true;
Waterlogged = false;
                }

                if(value == 4261) {
                    Facing = "south";
Half = "top";
Open = false;
Powered = false;
Waterlogged = true;
                }

                if(value == 4262) {
                    Facing = "south";
Half = "top";
Open = false;
Powered = false;
Waterlogged = false;
                }

                if(value == 4263) {
                    Facing = "south";
Half = "bottom";
Open = true;
Powered = true;
Waterlogged = true;
                }

                if(value == 4264) {
                    Facing = "south";
Half = "bottom";
Open = true;
Powered = true;
Waterlogged = false;
                }

                if(value == 4265) {
                    Facing = "south";
Half = "bottom";
Open = true;
Powered = false;
Waterlogged = true;
                }

                if(value == 4266) {
                    Facing = "south";
Half = "bottom";
Open = true;
Powered = false;
Waterlogged = false;
                }

                if(value == 4267) {
                    Facing = "south";
Half = "bottom";
Open = false;
Powered = true;
Waterlogged = true;
                }

                if(value == 4268) {
                    Facing = "south";
Half = "bottom";
Open = false;
Powered = true;
Waterlogged = false;
                }

                if(value == 4269) {
                    Facing = "south";
Half = "bottom";
Open = false;
Powered = false;
Waterlogged = true;
                }

                if(value == 4270) {
                    Facing = "south";
Half = "bottom";
Open = false;
Powered = false;
Waterlogged = false;
                }

                if(value == 4271) {
                    Facing = "west";
Half = "top";
Open = true;
Powered = true;
Waterlogged = true;
                }

                if(value == 4272) {
                    Facing = "west";
Half = "top";
Open = true;
Powered = true;
Waterlogged = false;
                }

                if(value == 4273) {
                    Facing = "west";
Half = "top";
Open = true;
Powered = false;
Waterlogged = true;
                }

                if(value == 4274) {
                    Facing = "west";
Half = "top";
Open = true;
Powered = false;
Waterlogged = false;
                }

                if(value == 4275) {
                    Facing = "west";
Half = "top";
Open = false;
Powered = true;
Waterlogged = true;
                }

                if(value == 4276) {
                    Facing = "west";
Half = "top";
Open = false;
Powered = true;
Waterlogged = false;
                }

                if(value == 4277) {
                    Facing = "west";
Half = "top";
Open = false;
Powered = false;
Waterlogged = true;
                }

                if(value == 4278) {
                    Facing = "west";
Half = "top";
Open = false;
Powered = false;
Waterlogged = false;
                }

                if(value == 4279) {
                    Facing = "west";
Half = "bottom";
Open = true;
Powered = true;
Waterlogged = true;
                }

                if(value == 4280) {
                    Facing = "west";
Half = "bottom";
Open = true;
Powered = true;
Waterlogged = false;
                }

                if(value == 4281) {
                    Facing = "west";
Half = "bottom";
Open = true;
Powered = false;
Waterlogged = true;
                }

                if(value == 4282) {
                    Facing = "west";
Half = "bottom";
Open = true;
Powered = false;
Waterlogged = false;
                }

                if(value == 4283) {
                    Facing = "west";
Half = "bottom";
Open = false;
Powered = true;
Waterlogged = true;
                }

                if(value == 4284) {
                    Facing = "west";
Half = "bottom";
Open = false;
Powered = true;
Waterlogged = false;
                }

                if(value == 4285) {
                    Facing = "west";
Half = "bottom";
Open = false;
Powered = false;
Waterlogged = true;
                }

                if(value == 4286) {
                    Facing = "west";
Half = "bottom";
Open = false;
Powered = false;
Waterlogged = false;
                }

                if(value == 4287) {
                    Facing = "east";
Half = "top";
Open = true;
Powered = true;
Waterlogged = true;
                }

                if(value == 4288) {
                    Facing = "east";
Half = "top";
Open = true;
Powered = true;
Waterlogged = false;
                }

                if(value == 4289) {
                    Facing = "east";
Half = "top";
Open = true;
Powered = false;
Waterlogged = true;
                }

                if(value == 4290) {
                    Facing = "east";
Half = "top";
Open = true;
Powered = false;
Waterlogged = false;
                }

                if(value == 4291) {
                    Facing = "east";
Half = "top";
Open = false;
Powered = true;
Waterlogged = true;
                }

                if(value == 4292) {
                    Facing = "east";
Half = "top";
Open = false;
Powered = true;
Waterlogged = false;
                }

                if(value == 4293) {
                    Facing = "east";
Half = "top";
Open = false;
Powered = false;
Waterlogged = true;
                }

                if(value == 4294) {
                    Facing = "east";
Half = "top";
Open = false;
Powered = false;
Waterlogged = false;
                }

                if(value == 4295) {
                    Facing = "east";
Half = "bottom";
Open = true;
Powered = true;
Waterlogged = true;
                }

                if(value == 4296) {
                    Facing = "east";
Half = "bottom";
Open = true;
Powered = true;
Waterlogged = false;
                }

                if(value == 4297) {
                    Facing = "east";
Half = "bottom";
Open = true;
Powered = false;
Waterlogged = true;
                }

                if(value == 4298) {
                    Facing = "east";
Half = "bottom";
Open = true;
Powered = false;
Waterlogged = false;
                }

                if(value == 4299) {
                    Facing = "east";
Half = "bottom";
Open = false;
Powered = true;
Waterlogged = true;
                }

                if(value == 4300) {
                    Facing = "east";
Half = "bottom";
Open = false;
Powered = true;
Waterlogged = false;
                }

                if(value == 4301) {
                    Facing = "east";
Half = "bottom";
Open = false;
Powered = false;
Waterlogged = true;
                }

                if(value == 4302) {
                    Facing = "east";
Half = "bottom";
Open = false;
Powered = false;
Waterlogged = false;
                }

            }
        }

        public string Facing { get; set; } = "north";
        public string Half { get; set; } = "bottom";
        public bool Open { get; set; } = false;
        public bool Powered { get; set; } = false;
        public bool Waterlogged { get; set; } = false;

        public BlockBirchTrapdoor() {
            State = DefaultState;
        }

        public BlockBirchTrapdoor(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBirchTrapdoor(string facing, string half, bool open, bool powered, bool waterlogged) {
            Facing = facing;
            Half = half;
            Open = open;
            Powered = powered;
            Waterlogged = waterlogged;
        }
    }
}