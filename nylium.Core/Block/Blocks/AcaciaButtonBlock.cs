// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class AcaciaButtonBlock : BaseBlock {

        public Face Face { get; }
        public Face Facing { get; }
        public bool Powered { get; }

        public AcaciaButtonBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 312, 6455) { }

        public AcaciaButtonBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 312, state) {
            if(state == 6446) {
                Face = Face.Floor;
                Facing = Face.North;
                Powered = true;
            } else if(state == 6447) {
                Face = Face.Floor;
                Facing = Face.North;
                Powered = false;
            } else if(state == 6448) {
                Face = Face.Floor;
                Facing = Face.South;
                Powered = true;
            } else if(state == 6449) {
                Face = Face.Floor;
                Facing = Face.South;
                Powered = false;
            } else if(state == 6450) {
                Face = Face.Floor;
                Facing = Face.West;
                Powered = true;
            } else if(state == 6451) {
                Face = Face.Floor;
                Facing = Face.West;
                Powered = false;
            } else if(state == 6452) {
                Face = Face.Floor;
                Facing = Face.East;
                Powered = true;
            } else if(state == 6453) {
                Face = Face.Floor;
                Facing = Face.East;
                Powered = false;
            } else if(state == 6454) {
                Face = Face.Wall;
                Facing = Face.North;
                Powered = true;
            } else if(state == 6455) {
                Face = Face.Wall;
                Facing = Face.North;
                Powered = false;
            } else if(state == 6456) {
                Face = Face.Wall;
                Facing = Face.South;
                Powered = true;
            } else if(state == 6457) {
                Face = Face.Wall;
                Facing = Face.South;
                Powered = false;
            } else if(state == 6458) {
                Face = Face.Wall;
                Facing = Face.West;
                Powered = true;
            } else if(state == 6459) {
                Face = Face.Wall;
                Facing = Face.West;
                Powered = false;
            } else if(state == 6460) {
                Face = Face.Wall;
                Facing = Face.East;
                Powered = true;
            } else if(state == 6461) {
                Face = Face.Wall;
                Facing = Face.East;
                Powered = false;
            } else if(state == 6462) {
                Face = Face.Ceiling;
                Facing = Face.North;
                Powered = true;
            } else if(state == 6463) {
                Face = Face.Ceiling;
                Facing = Face.North;
                Powered = false;
            } else if(state == 6464) {
                Face = Face.Ceiling;
                Facing = Face.South;
                Powered = true;
            } else if(state == 6465) {
                Face = Face.Ceiling;
                Facing = Face.South;
                Powered = false;
            } else if(state == 6466) {
                Face = Face.Ceiling;
                Facing = Face.West;
                Powered = true;
            } else if(state == 6467) {
                Face = Face.Ceiling;
                Facing = Face.West;
                Powered = false;
            } else if(state == 6468) {
                Face = Face.Ceiling;
                Facing = Face.East;
                Powered = true;
            } else if(state == 6469) {
                Face = Face.Ceiling;
                Facing = Face.East;
                Powered = false;
            }
        }

        public AcaciaButtonBlock(Chunk chunk, int x, int y, int z, Face face, Face facing, bool powered) : base(chunk, x, y, z, 312, 6455) {
if(face == Face.Floor && facing == Face.North && powered == true) {
                State = 6446;
            } else if(face == Face.Floor && facing == Face.North && powered == false) {
                State = 6447;
            } else if(face == Face.Floor && facing == Face.South && powered == true) {
                State = 6448;
            } else if(face == Face.Floor && facing == Face.South && powered == false) {
                State = 6449;
            } else if(face == Face.Floor && facing == Face.West && powered == true) {
                State = 6450;
            } else if(face == Face.Floor && facing == Face.West && powered == false) {
                State = 6451;
            } else if(face == Face.Floor && facing == Face.East && powered == true) {
                State = 6452;
            } else if(face == Face.Floor && facing == Face.East && powered == false) {
                State = 6453;
            } else if(face == Face.Wall && facing == Face.North && powered == true) {
                State = 6454;
            } else if(face == Face.Wall && facing == Face.North && powered == false) {
                State = 6455;
            } else if(face == Face.Wall && facing == Face.South && powered == true) {
                State = 6456;
            } else if(face == Face.Wall && facing == Face.South && powered == false) {
                State = 6457;
            } else if(face == Face.Wall && facing == Face.West && powered == true) {
                State = 6458;
            } else if(face == Face.Wall && facing == Face.West && powered == false) {
                State = 6459;
            } else if(face == Face.Wall && facing == Face.East && powered == true) {
                State = 6460;
            } else if(face == Face.Wall && facing == Face.East && powered == false) {
                State = 6461;
            } else if(face == Face.Ceiling && facing == Face.North && powered == true) {
                State = 6462;
            } else if(face == Face.Ceiling && facing == Face.North && powered == false) {
                State = 6463;
            } else if(face == Face.Ceiling && facing == Face.South && powered == true) {
                State = 6464;
            } else if(face == Face.Ceiling && facing == Face.South && powered == false) {
                State = 6465;
            } else if(face == Face.Ceiling && facing == Face.West && powered == true) {
                State = 6466;
            } else if(face == Face.Ceiling && facing == Face.West && powered == false) {
                State = 6467;
            } else if(face == Face.Ceiling && facing == Face.East && powered == true) {
                State = 6468;
            } else if(face == Face.Ceiling && facing == Face.East && powered == false) {
                State = 6469;
            }
        }
    }
}
