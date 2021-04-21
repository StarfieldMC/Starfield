// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class RedBedBlock : BaseBlock {

        public Face Facing { get; }
        public bool Occupied { get; }
        public Part Part { get; }

        public RedBedBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 89, 1276) { }

        public RedBedBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 89, state) {
            if(state == 1273) {
                Facing = Face.North;
                Occupied = true;
                Part = Part.Head;
            } else if(state == 1274) {
                Facing = Face.North;
                Occupied = true;
                Part = Part.Foot;
            } else if(state == 1275) {
                Facing = Face.North;
                Occupied = false;
                Part = Part.Head;
            } else if(state == 1276) {
                Facing = Face.North;
                Occupied = false;
                Part = Part.Foot;
            } else if(state == 1277) {
                Facing = Face.South;
                Occupied = true;
                Part = Part.Head;
            } else if(state == 1278) {
                Facing = Face.South;
                Occupied = true;
                Part = Part.Foot;
            } else if(state == 1279) {
                Facing = Face.South;
                Occupied = false;
                Part = Part.Head;
            } else if(state == 1280) {
                Facing = Face.South;
                Occupied = false;
                Part = Part.Foot;
            } else if(state == 1281) {
                Facing = Face.West;
                Occupied = true;
                Part = Part.Head;
            } else if(state == 1282) {
                Facing = Face.West;
                Occupied = true;
                Part = Part.Foot;
            } else if(state == 1283) {
                Facing = Face.West;
                Occupied = false;
                Part = Part.Head;
            } else if(state == 1284) {
                Facing = Face.West;
                Occupied = false;
                Part = Part.Foot;
            } else if(state == 1285) {
                Facing = Face.East;
                Occupied = true;
                Part = Part.Head;
            } else if(state == 1286) {
                Facing = Face.East;
                Occupied = true;
                Part = Part.Foot;
            } else if(state == 1287) {
                Facing = Face.East;
                Occupied = false;
                Part = Part.Head;
            } else if(state == 1288) {
                Facing = Face.East;
                Occupied = false;
                Part = Part.Foot;
            }
        }

        public RedBedBlock(Chunk chunk, int x, int y, int z, Face facing, bool occupied, Part part) : base(chunk, x, y, z, 89, 1276) {
if(facing == Face.North && occupied == true && part == Part.Head) {
                State = 1273;
            } else if(facing == Face.North && occupied == true && part == Part.Foot) {
                State = 1274;
            } else if(facing == Face.North && occupied == false && part == Part.Head) {
                State = 1275;
            } else if(facing == Face.North && occupied == false && part == Part.Foot) {
                State = 1276;
            } else if(facing == Face.South && occupied == true && part == Part.Head) {
                State = 1277;
            } else if(facing == Face.South && occupied == true && part == Part.Foot) {
                State = 1278;
            } else if(facing == Face.South && occupied == false && part == Part.Head) {
                State = 1279;
            } else if(facing == Face.South && occupied == false && part == Part.Foot) {
                State = 1280;
            } else if(facing == Face.West && occupied == true && part == Part.Head) {
                State = 1281;
            } else if(facing == Face.West && occupied == true && part == Part.Foot) {
                State = 1282;
            } else if(facing == Face.West && occupied == false && part == Part.Head) {
                State = 1283;
            } else if(facing == Face.West && occupied == false && part == Part.Foot) {
                State = 1284;
            } else if(facing == Face.East && occupied == true && part == Part.Head) {
                State = 1285;
            } else if(facing == Face.East && occupied == true && part == Part.Foot) {
                State = 1286;
            } else if(facing == Face.East && occupied == false && part == Part.Head) {
                State = 1287;
            } else if(facing == Face.East && occupied == false && part == Part.Foot) {
                State = 1288;
            }
        }
    }
}
