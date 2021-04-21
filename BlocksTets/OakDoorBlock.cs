// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class OakDoorBlock : BaseBlock {

        public Face Facing { get; }
        public Half Half { get; }
        public Hinge Hinge { get; }
        public bool Open { get; }
        public bool Powered { get; }

        public OakDoorBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 161, 3584) { }

        public OakDoorBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 161, state) {if(state == 3573) {
                Facing = Face.North;
                Half = Half.Upper;
                Hinge = Hinge.Left;
                Open = true;
                Powered = true;
            } else if(state == 3574) {
                Facing = Face.North;
                Half = Half.Upper;
                Hinge = Hinge.Left;
                Open = true;
                Powered = false;
            } else if(state == 3575) {
                Facing = Face.North;
                Half = Half.Upper;
                Hinge = Hinge.Left;
                Open = false;
                Powered = true;
            } else if(state == 3576) {
                Facing = Face.North;
                Half = Half.Upper;
                Hinge = Hinge.Left;
                Open = false;
                Powered = false;
            } else if(state == 3577) {
                Facing = Face.North;
                Half = Half.Upper;
                Hinge = Hinge.Right;
                Open = true;
                Powered = true;
            } else if(state == 3578) {
                Facing = Face.North;
                Half = Half.Upper;
                Hinge = Hinge.Right;
                Open = true;
                Powered = false;
            } else if(state == 3579) {
                Facing = Face.North;
                Half = Half.Upper;
                Hinge = Hinge.Right;
                Open = false;
                Powered = true;
            } else if(state == 3580) {
                Facing = Face.North;
                Half = Half.Upper;
                Hinge = Hinge.Right;
                Open = false;
                Powered = false;
            } else if(state == 3581) {
                Facing = Face.North;
                Half = Half.Lower;
                Hinge = Hinge.Left;
                Open = true;
                Powered = true;
            } else if(state == 3582) {
                Facing = Face.North;
                Half = Half.Lower;
                Hinge = Hinge.Left;
                Open = true;
                Powered = false;
            } else if(state == 3583) {
                Facing = Face.North;
                Half = Half.Lower;
                Hinge = Hinge.Left;
                Open = false;
                Powered = true;
            } else if(state == 3584) {
                Facing = Face.North;
                Half = Half.Lower;
                Hinge = Hinge.Left;
                Open = false;
                Powered = false;
            } else if(state == 3585) {
                Facing = Face.North;
                Half = Half.Lower;
                Hinge = Hinge.Right;
                Open = true;
                Powered = true;
            } else if(state == 3586) {
                Facing = Face.North;
                Half = Half.Lower;
                Hinge = Hinge.Right;
                Open = true;
                Powered = false;
            } else if(state == 3587) {
                Facing = Face.North;
                Half = Half.Lower;
                Hinge = Hinge.Right;
                Open = false;
                Powered = true;
            } else if(state == 3588) {
                Facing = Face.North;
                Half = Half.Lower;
                Hinge = Hinge.Right;
                Open = false;
                Powered = false;
            } else if(state == 3589) {
                Facing = Face.South;
                Half = Half.Upper;
                Hinge = Hinge.Left;
                Open = true;
                Powered = true;
            } else if(state == 3590) {
                Facing = Face.South;
                Half = Half.Upper;
                Hinge = Hinge.Left;
                Open = true;
                Powered = false;
            } else if(state == 3591) {
                Facing = Face.South;
                Half = Half.Upper;
                Hinge = Hinge.Left;
                Open = false;
                Powered = true;
            } else if(state == 3592) {
                Facing = Face.South;
                Half = Half.Upper;
                Hinge = Hinge.Left;
                Open = false;
                Powered = false;
            } else if(state == 3593) {
                Facing = Face.South;
                Half = Half.Upper;
                Hinge = Hinge.Right;
                Open = true;
                Powered = true;
            } else if(state == 3594) {
                Facing = Face.South;
                Half = Half.Upper;
                Hinge = Hinge.Right;
                Open = true;
                Powered = false;
            } else if(state == 3595) {
                Facing = Face.South;
                Half = Half.Upper;
                Hinge = Hinge.Right;
                Open = false;
                Powered = true;
            } else if(state == 3596) {
                Facing = Face.South;
                Half = Half.Upper;
                Hinge = Hinge.Right;
                Open = false;
                Powered = false;
            } else if(state == 3597) {
                Facing = Face.South;
                Half = Half.Lower;
                Hinge = Hinge.Left;
                Open = true;
                Powered = true;
            } else if(state == 3598) {
                Facing = Face.South;
                Half = Half.Lower;
                Hinge = Hinge.Left;
                Open = true;
                Powered = false;
            } else if(state == 3599) {
                Facing = Face.South;
                Half = Half.Lower;
                Hinge = Hinge.Left;
                Open = false;
                Powered = true;
            } else if(state == 3600) {
                Facing = Face.South;
                Half = Half.Lower;
                Hinge = Hinge.Left;
                Open = false;
                Powered = false;
            } else if(state == 3601) {
                Facing = Face.South;
                Half = Half.Lower;
                Hinge = Hinge.Right;
                Open = true;
                Powered = true;
            } else if(state == 3602) {
                Facing = Face.South;
                Half = Half.Lower;
                Hinge = Hinge.Right;
                Open = true;
                Powered = false;
            } else if(state == 3603) {
                Facing = Face.South;
                Half = Half.Lower;
                Hinge = Hinge.Right;
                Open = false;
                Powered = true;
            } else if(state == 3604) {
                Facing = Face.South;
                Half = Half.Lower;
                Hinge = Hinge.Right;
                Open = false;
                Powered = false;
            } else if(state == 3605) {
                Facing = Face.West;
                Half = Half.Upper;
                Hinge = Hinge.Left;
                Open = true;
                Powered = true;
            } else if(state == 3606) {
                Facing = Face.West;
                Half = Half.Upper;
                Hinge = Hinge.Left;
                Open = true;
                Powered = false;
            } else if(state == 3607) {
                Facing = Face.West;
                Half = Half.Upper;
                Hinge = Hinge.Left;
                Open = false;
                Powered = true;
            } else if(state == 3608) {
                Facing = Face.West;
                Half = Half.Upper;
                Hinge = Hinge.Left;
                Open = false;
                Powered = false;
            } else if(state == 3609) {
                Facing = Face.West;
                Half = Half.Upper;
                Hinge = Hinge.Right;
                Open = true;
                Powered = true;
            } else if(state == 3610) {
                Facing = Face.West;
                Half = Half.Upper;
                Hinge = Hinge.Right;
                Open = true;
                Powered = false;
            } else if(state == 3611) {
                Facing = Face.West;
                Half = Half.Upper;
                Hinge = Hinge.Right;
                Open = false;
                Powered = true;
            } else if(state == 3612) {
                Facing = Face.West;
                Half = Half.Upper;
                Hinge = Hinge.Right;
                Open = false;
                Powered = false;
            } else if(state == 3613) {
                Facing = Face.West;
                Half = Half.Lower;
                Hinge = Hinge.Left;
                Open = true;
                Powered = true;
            } else if(state == 3614) {
                Facing = Face.West;
                Half = Half.Lower;
                Hinge = Hinge.Left;
                Open = true;
                Powered = false;
            } else if(state == 3615) {
                Facing = Face.West;
                Half = Half.Lower;
                Hinge = Hinge.Left;
                Open = false;
                Powered = true;
            } else if(state == 3616) {
                Facing = Face.West;
                Half = Half.Lower;
                Hinge = Hinge.Left;
                Open = false;
                Powered = false;
            } else if(state == 3617) {
                Facing = Face.West;
                Half = Half.Lower;
                Hinge = Hinge.Right;
                Open = true;
                Powered = true;
            } else if(state == 3618) {
                Facing = Face.West;
                Half = Half.Lower;
                Hinge = Hinge.Right;
                Open = true;
                Powered = false;
            } else if(state == 3619) {
                Facing = Face.West;
                Half = Half.Lower;
                Hinge = Hinge.Right;
                Open = false;
                Powered = true;
            } else if(state == 3620) {
                Facing = Face.West;
                Half = Half.Lower;
                Hinge = Hinge.Right;
                Open = false;
                Powered = false;
            } else if(state == 3621) {
                Facing = Face.East;
                Half = Half.Upper;
                Hinge = Hinge.Left;
                Open = true;
                Powered = true;
            } else if(state == 3622) {
                Facing = Face.East;
                Half = Half.Upper;
                Hinge = Hinge.Left;
                Open = true;
                Powered = false;
            } else if(state == 3623) {
                Facing = Face.East;
                Half = Half.Upper;
                Hinge = Hinge.Left;
                Open = false;
                Powered = true;
            } else if(state == 3624) {
                Facing = Face.East;
                Half = Half.Upper;
                Hinge = Hinge.Left;
                Open = false;
                Powered = false;
            } else if(state == 3625) {
                Facing = Face.East;
                Half = Half.Upper;
                Hinge = Hinge.Right;
                Open = true;
                Powered = true;
            } else if(state == 3626) {
                Facing = Face.East;
                Half = Half.Upper;
                Hinge = Hinge.Right;
                Open = true;
                Powered = false;
            } else if(state == 3627) {
                Facing = Face.East;
                Half = Half.Upper;
                Hinge = Hinge.Right;
                Open = false;
                Powered = true;
            } else if(state == 3628) {
                Facing = Face.East;
                Half = Half.Upper;
                Hinge = Hinge.Right;
                Open = false;
                Powered = false;
            } else if(state == 3629) {
                Facing = Face.East;
                Half = Half.Lower;
                Hinge = Hinge.Left;
                Open = true;
                Powered = true;
            } else if(state == 3630) {
                Facing = Face.East;
                Half = Half.Lower;
                Hinge = Hinge.Left;
                Open = true;
                Powered = false;
            } else if(state == 3631) {
                Facing = Face.East;
                Half = Half.Lower;
                Hinge = Hinge.Left;
                Open = false;
                Powered = true;
            } else if(state == 3632) {
                Facing = Face.East;
                Half = Half.Lower;
                Hinge = Hinge.Left;
                Open = false;
                Powered = false;
            } else if(state == 3633) {
                Facing = Face.East;
                Half = Half.Lower;
                Hinge = Hinge.Right;
                Open = true;
                Powered = true;
            } else if(state == 3634) {
                Facing = Face.East;
                Half = Half.Lower;
                Hinge = Hinge.Right;
                Open = true;
                Powered = false;
            } else if(state == 3635) {
                Facing = Face.East;
                Half = Half.Lower;
                Hinge = Hinge.Right;
                Open = false;
                Powered = true;
            } else if(state == 3636) {
                Facing = Face.East;
                Half = Half.Lower;
                Hinge = Hinge.Right;
                Open = false;
                Powered = false;
            }
        }

        public OakDoorBlock(Chunk chunk, int x, int y, int z, Face facing, Half half, Hinge hinge, bool open, bool powered) : base(chunk, x, y, z, 161, 3584) {
if(facing == Face.North && half == Half.Upper && hinge == Hinge.Left && open == true && powered == true) {
                State = 3573;
            } else if(facing == Face.North && half == Half.Upper && hinge == Hinge.Left && open == true && powered == false) {
                State = 3574;
            } else if(facing == Face.North && half == Half.Upper && hinge == Hinge.Left && open == false && powered == true) {
                State = 3575;
            } else if(facing == Face.North && half == Half.Upper && hinge == Hinge.Left && open == false && powered == false) {
                State = 3576;
            } else if(facing == Face.North && half == Half.Upper && hinge == Hinge.Right && open == true && powered == true) {
                State = 3577;
            } else if(facing == Face.North && half == Half.Upper && hinge == Hinge.Right && open == true && powered == false) {
                State = 3578;
            } else if(facing == Face.North && half == Half.Upper && hinge == Hinge.Right && open == false && powered == true) {
                State = 3579;
            } else if(facing == Face.North && half == Half.Upper && hinge == Hinge.Right && open == false && powered == false) {
                State = 3580;
            } else if(facing == Face.North && half == Half.Lower && hinge == Hinge.Left && open == true && powered == true) {
                State = 3581;
            } else if(facing == Face.North && half == Half.Lower && hinge == Hinge.Left && open == true && powered == false) {
                State = 3582;
            } else if(facing == Face.North && half == Half.Lower && hinge == Hinge.Left && open == false && powered == true) {
                State = 3583;
            } else if(facing == Face.North && half == Half.Lower && hinge == Hinge.Left && open == false && powered == false) {
                State = 3584;
            } else if(facing == Face.North && half == Half.Lower && hinge == Hinge.Right && open == true && powered == true) {
                State = 3585;
            } else if(facing == Face.North && half == Half.Lower && hinge == Hinge.Right && open == true && powered == false) {
                State = 3586;
            } else if(facing == Face.North && half == Half.Lower && hinge == Hinge.Right && open == false && powered == true) {
                State = 3587;
            } else if(facing == Face.North && half == Half.Lower && hinge == Hinge.Right && open == false && powered == false) {
                State = 3588;
            } else if(facing == Face.South && half == Half.Upper && hinge == Hinge.Left && open == true && powered == true) {
                State = 3589;
            } else if(facing == Face.South && half == Half.Upper && hinge == Hinge.Left && open == true && powered == false) {
                State = 3590;
            } else if(facing == Face.South && half == Half.Upper && hinge == Hinge.Left && open == false && powered == true) {
                State = 3591;
            } else if(facing == Face.South && half == Half.Upper && hinge == Hinge.Left && open == false && powered == false) {
                State = 3592;
            } else if(facing == Face.South && half == Half.Upper && hinge == Hinge.Right && open == true && powered == true) {
                State = 3593;
            } else if(facing == Face.South && half == Half.Upper && hinge == Hinge.Right && open == true && powered == false) {
                State = 3594;
            } else if(facing == Face.South && half == Half.Upper && hinge == Hinge.Right && open == false && powered == true) {
                State = 3595;
            } else if(facing == Face.South && half == Half.Upper && hinge == Hinge.Right && open == false && powered == false) {
                State = 3596;
            } else if(facing == Face.South && half == Half.Lower && hinge == Hinge.Left && open == true && powered == true) {
                State = 3597;
            } else if(facing == Face.South && half == Half.Lower && hinge == Hinge.Left && open == true && powered == false) {
                State = 3598;
            } else if(facing == Face.South && half == Half.Lower && hinge == Hinge.Left && open == false && powered == true) {
                State = 3599;
            } else if(facing == Face.South && half == Half.Lower && hinge == Hinge.Left && open == false && powered == false) {
                State = 3600;
            } else if(facing == Face.South && half == Half.Lower && hinge == Hinge.Right && open == true && powered == true) {
                State = 3601;
            } else if(facing == Face.South && half == Half.Lower && hinge == Hinge.Right && open == true && powered == false) {
                State = 3602;
            } else if(facing == Face.South && half == Half.Lower && hinge == Hinge.Right && open == false && powered == true) {
                State = 3603;
            } else if(facing == Face.South && half == Half.Lower && hinge == Hinge.Right && open == false && powered == false) {
                State = 3604;
            } else if(facing == Face.West && half == Half.Upper && hinge == Hinge.Left && open == true && powered == true) {
                State = 3605;
            } else if(facing == Face.West && half == Half.Upper && hinge == Hinge.Left && open == true && powered == false) {
                State = 3606;
            } else if(facing == Face.West && half == Half.Upper && hinge == Hinge.Left && open == false && powered == true) {
                State = 3607;
            } else if(facing == Face.West && half == Half.Upper && hinge == Hinge.Left && open == false && powered == false) {
                State = 3608;
            } else if(facing == Face.West && half == Half.Upper && hinge == Hinge.Right && open == true && powered == true) {
                State = 3609;
            } else if(facing == Face.West && half == Half.Upper && hinge == Hinge.Right && open == true && powered == false) {
                State = 3610;
            } else if(facing == Face.West && half == Half.Upper && hinge == Hinge.Right && open == false && powered == true) {
                State = 3611;
            } else if(facing == Face.West && half == Half.Upper && hinge == Hinge.Right && open == false && powered == false) {
                State = 3612;
            } else if(facing == Face.West && half == Half.Lower && hinge == Hinge.Left && open == true && powered == true) {
                State = 3613;
            } else if(facing == Face.West && half == Half.Lower && hinge == Hinge.Left && open == true && powered == false) {
                State = 3614;
            } else if(facing == Face.West && half == Half.Lower && hinge == Hinge.Left && open == false && powered == true) {
                State = 3615;
            } else if(facing == Face.West && half == Half.Lower && hinge == Hinge.Left && open == false && powered == false) {
                State = 3616;
            } else if(facing == Face.West && half == Half.Lower && hinge == Hinge.Right && open == true && powered == true) {
                State = 3617;
            } else if(facing == Face.West && half == Half.Lower && hinge == Hinge.Right && open == true && powered == false) {
                State = 3618;
            } else if(facing == Face.West && half == Half.Lower && hinge == Hinge.Right && open == false && powered == true) {
                State = 3619;
            } else if(facing == Face.West && half == Half.Lower && hinge == Hinge.Right && open == false && powered == false) {
                State = 3620;
            } else if(facing == Face.East && half == Half.Upper && hinge == Hinge.Left && open == true && powered == true) {
                State = 3621;
            } else if(facing == Face.East && half == Half.Upper && hinge == Hinge.Left && open == true && powered == false) {
                State = 3622;
            } else if(facing == Face.East && half == Half.Upper && hinge == Hinge.Left && open == false && powered == true) {
                State = 3623;
            } else if(facing == Face.East && half == Half.Upper && hinge == Hinge.Left && open == false && powered == false) {
                State = 3624;
            } else if(facing == Face.East && half == Half.Upper && hinge == Hinge.Right && open == true && powered == true) {
                State = 3625;
            } else if(facing == Face.East && half == Half.Upper && hinge == Hinge.Right && open == true && powered == false) {
                State = 3626;
            } else if(facing == Face.East && half == Half.Upper && hinge == Hinge.Right && open == false && powered == true) {
                State = 3627;
            } else if(facing == Face.East && half == Half.Upper && hinge == Hinge.Right && open == false && powered == false) {
                State = 3628;
            } else if(facing == Face.East && half == Half.Lower && hinge == Hinge.Left && open == true && powered == true) {
                State = 3629;
            } else if(facing == Face.East && half == Half.Lower && hinge == Hinge.Left && open == true && powered == false) {
                State = 3630;
            } else if(facing == Face.East && half == Half.Lower && hinge == Hinge.Left && open == false && powered == true) {
                State = 3631;
            } else if(facing == Face.East && half == Half.Lower && hinge == Hinge.Left && open == false && powered == false) {
                State = 3632;
            } else if(facing == Face.East && half == Half.Lower && hinge == Hinge.Right && open == true && powered == true) {
                State = 3633;
            } else if(facing == Face.East && half == Half.Lower && hinge == Hinge.Right && open == true && powered == false) {
                State = 3634;
            } else if(facing == Face.East && half == Half.Lower && hinge == Hinge.Right && open == false && powered == true) {
                State = 3635;
            } else if(facing == Face.East && half == Half.Lower && hinge == Hinge.Right && open == false && powered == false) {
                State = 3636;
            }
        }

        public enum Hinge {
            
            Left,
            Right
        }
    }
}
