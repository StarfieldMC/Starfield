// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class DarkOakButtonBlock : BaseBlock {

        public Face Face { get; }
        public Face Facing { get; }
        public bool Powered { get; }

        public DarkOakButtonBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 313, 6479) { }

        public DarkOakButtonBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 313, state) {
            if(state == 6470) {
                Face = Face.Floor;
                Facing = Face.North;
                Powered = true;
            } else if(state == 6471) {
                Face = Face.Floor;
                Facing = Face.North;
                Powered = false;
            } else if(state == 6472) {
                Face = Face.Floor;
                Facing = Face.South;
                Powered = true;
            } else if(state == 6473) {
                Face = Face.Floor;
                Facing = Face.South;
                Powered = false;
            } else if(state == 6474) {
                Face = Face.Floor;
                Facing = Face.West;
                Powered = true;
            } else if(state == 6475) {
                Face = Face.Floor;
                Facing = Face.West;
                Powered = false;
            } else if(state == 6476) {
                Face = Face.Floor;
                Facing = Face.East;
                Powered = true;
            } else if(state == 6477) {
                Face = Face.Floor;
                Facing = Face.East;
                Powered = false;
            } else if(state == 6478) {
                Face = Face.Wall;
                Facing = Face.North;
                Powered = true;
            } else if(state == 6479) {
                Face = Face.Wall;
                Facing = Face.North;
                Powered = false;
            } else if(state == 6480) {
                Face = Face.Wall;
                Facing = Face.South;
                Powered = true;
            } else if(state == 6481) {
                Face = Face.Wall;
                Facing = Face.South;
                Powered = false;
            } else if(state == 6482) {
                Face = Face.Wall;
                Facing = Face.West;
                Powered = true;
            } else if(state == 6483) {
                Face = Face.Wall;
                Facing = Face.West;
                Powered = false;
            } else if(state == 6484) {
                Face = Face.Wall;
                Facing = Face.East;
                Powered = true;
            } else if(state == 6485) {
                Face = Face.Wall;
                Facing = Face.East;
                Powered = false;
            } else if(state == 6486) {
                Face = Face.Ceiling;
                Facing = Face.North;
                Powered = true;
            } else if(state == 6487) {
                Face = Face.Ceiling;
                Facing = Face.North;
                Powered = false;
            } else if(state == 6488) {
                Face = Face.Ceiling;
                Facing = Face.South;
                Powered = true;
            } else if(state == 6489) {
                Face = Face.Ceiling;
                Facing = Face.South;
                Powered = false;
            } else if(state == 6490) {
                Face = Face.Ceiling;
                Facing = Face.West;
                Powered = true;
            } else if(state == 6491) {
                Face = Face.Ceiling;
                Facing = Face.West;
                Powered = false;
            } else if(state == 6492) {
                Face = Face.Ceiling;
                Facing = Face.East;
                Powered = true;
            } else if(state == 6493) {
                Face = Face.Ceiling;
                Facing = Face.East;
                Powered = false;
            }
        }

        public DarkOakButtonBlock(Chunk chunk, int x, int y, int z, Face face, Face facing, bool powered) : base(chunk, x, y, z, 313, 6479) {
if(face == Face.Floor && facing == Face.North && powered == true) {
                State = 6470;
            } else if(face == Face.Floor && facing == Face.North && powered == false) {
                State = 6471;
            } else if(face == Face.Floor && facing == Face.South && powered == true) {
                State = 6472;
            } else if(face == Face.Floor && facing == Face.South && powered == false) {
                State = 6473;
            } else if(face == Face.Floor && facing == Face.West && powered == true) {
                State = 6474;
            } else if(face == Face.Floor && facing == Face.West && powered == false) {
                State = 6475;
            } else if(face == Face.Floor && facing == Face.East && powered == true) {
                State = 6476;
            } else if(face == Face.Floor && facing == Face.East && powered == false) {
                State = 6477;
            } else if(face == Face.Wall && facing == Face.North && powered == true) {
                State = 6478;
            } else if(face == Face.Wall && facing == Face.North && powered == false) {
                State = 6479;
            } else if(face == Face.Wall && facing == Face.South && powered == true) {
                State = 6480;
            } else if(face == Face.Wall && facing == Face.South && powered == false) {
                State = 6481;
            } else if(face == Face.Wall && facing == Face.West && powered == true) {
                State = 6482;
            } else if(face == Face.Wall && facing == Face.West && powered == false) {
                State = 6483;
            } else if(face == Face.Wall && facing == Face.East && powered == true) {
                State = 6484;
            } else if(face == Face.Wall && facing == Face.East && powered == false) {
                State = 6485;
            } else if(face == Face.Ceiling && facing == Face.North && powered == true) {
                State = 6486;
            } else if(face == Face.Ceiling && facing == Face.North && powered == false) {
                State = 6487;
            } else if(face == Face.Ceiling && facing == Face.South && powered == true) {
                State = 6488;
            } else if(face == Face.Ceiling && facing == Face.South && powered == false) {
                State = 6489;
            } else if(face == Face.Ceiling && facing == Face.West && powered == true) {
                State = 6490;
            } else if(face == Face.Ceiling && facing == Face.West && powered == false) {
                State = 6491;
            } else if(face == Face.Ceiling && facing == Face.East && powered == true) {
                State = 6492;
            } else if(face == Face.Ceiling && facing == Face.East && powered == false) {
                State = 6493;
            }
        }
    }
}
