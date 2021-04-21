// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class IronTrapdoorBlock : BaseBlock {

        public Face Facing { get; }
        public Half Half { get; }
        public bool Open { get; }
        public bool Powered { get; }
        public bool Waterlogged { get; }

        public IronTrapdoorBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 379, 7556) { }

        public IronTrapdoorBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 379, state) {
            if(state == 7541) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 7542) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 7543) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 7544) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 7545) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 7546) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 7547) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 7548) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 7549) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 7550) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 7551) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 7552) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 7553) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 7554) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 7555) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 7556) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 7557) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 7558) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 7559) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 7560) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 7561) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 7562) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 7563) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 7564) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 7565) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 7566) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 7567) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 7568) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 7569) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 7570) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 7571) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 7572) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 7573) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 7574) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 7575) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 7576) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 7577) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 7578) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 7579) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 7580) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 7581) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 7582) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 7583) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 7584) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 7585) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 7586) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 7587) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 7588) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 7589) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 7590) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 7591) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 7592) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 7593) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 7594) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 7595) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 7596) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 7597) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 7598) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 7599) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 7600) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 7601) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 7602) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 7603) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 7604) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            }
        }

        public IronTrapdoorBlock(Chunk chunk, int x, int y, int z, Face facing, Half half, bool open, bool powered, bool waterlogged) : base(chunk, x, y, z, 379, 7556) {
if(facing == Face.North && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 7541;
            } else if(facing == Face.North && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 7542;
            } else if(facing == Face.North && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 7543;
            } else if(facing == Face.North && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 7544;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 7545;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 7546;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 7547;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 7548;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 7549;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 7550;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 7551;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 7552;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 7553;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 7554;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 7555;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 7556;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 7557;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 7558;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 7559;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 7560;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 7561;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 7562;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 7563;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 7564;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 7565;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 7566;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 7567;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 7568;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 7569;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 7570;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 7571;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 7572;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 7573;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 7574;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 7575;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 7576;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 7577;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 7578;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 7579;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 7580;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 7581;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 7582;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 7583;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 7584;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 7585;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 7586;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 7587;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 7588;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 7589;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 7590;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 7591;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 7592;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 7593;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 7594;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 7595;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 7596;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 7597;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 7598;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 7599;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 7600;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 7601;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 7602;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 7603;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 7604;
            }
        }
    }
}
