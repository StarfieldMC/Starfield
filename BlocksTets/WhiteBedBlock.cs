// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class WhiteBedBlock : BaseBlock {

        public Face Facing { get; }
        public bool Occupied { get; }
        public Part Part { get; }

        public WhiteBedBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 75, 1052) { }

        public WhiteBedBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 75, state) {
            if(state == 1049) {
                Facing = Face.North;
                Occupied = true;
                Part = Part.Head;
            } else if(state == 1050) {
                Facing = Face.North;
                Occupied = true;
                Part = Part.Foot;
            } else if(state == 1051) {
                Facing = Face.North;
                Occupied = false;
                Part = Part.Head;
            } else if(state == 1052) {
                Facing = Face.North;
                Occupied = false;
                Part = Part.Foot;
            } else if(state == 1053) {
                Facing = Face.South;
                Occupied = true;
                Part = Part.Head;
            } else if(state == 1054) {
                Facing = Face.South;
                Occupied = true;
                Part = Part.Foot;
            } else if(state == 1055) {
                Facing = Face.South;
                Occupied = false;
                Part = Part.Head;
            } else if(state == 1056) {
                Facing = Face.South;
                Occupied = false;
                Part = Part.Foot;
            } else if(state == 1057) {
                Facing = Face.West;
                Occupied = true;
                Part = Part.Head;
            } else if(state == 1058) {
                Facing = Face.West;
                Occupied = true;
                Part = Part.Foot;
            } else if(state == 1059) {
                Facing = Face.West;
                Occupied = false;
                Part = Part.Head;
            } else if(state == 1060) {
                Facing = Face.West;
                Occupied = false;
                Part = Part.Foot;
            } else if(state == 1061) {
                Facing = Face.East;
                Occupied = true;
                Part = Part.Head;
            } else if(state == 1062) {
                Facing = Face.East;
                Occupied = true;
                Part = Part.Foot;
            } else if(state == 1063) {
                Facing = Face.East;
                Occupied = false;
                Part = Part.Head;
            } else if(state == 1064) {
                Facing = Face.East;
                Occupied = false;
                Part = Part.Foot;
            }
        }

        public WhiteBedBlock(Chunk chunk, int x, int y, int z, Face facing, bool occupied, Part part) : base(chunk, x, y, z, 75, 1052) {
if(facing == Face.North && occupied == true && part == Part.Head) {
                State = 1049;
            } else if(facing == Face.North && occupied == true && part == Part.Foot) {
                State = 1050;
            } else if(facing == Face.North && occupied == false && part == Part.Head) {
                State = 1051;
            } else if(facing == Face.North && occupied == false && part == Part.Foot) {
                State = 1052;
            } else if(facing == Face.South && occupied == true && part == Part.Head) {
                State = 1053;
            } else if(facing == Face.South && occupied == true && part == Part.Foot) {
                State = 1054;
            } else if(facing == Face.South && occupied == false && part == Part.Head) {
                State = 1055;
            } else if(facing == Face.South && occupied == false && part == Part.Foot) {
                State = 1056;
            } else if(facing == Face.West && occupied == true && part == Part.Head) {
                State = 1057;
            } else if(facing == Face.West && occupied == true && part == Part.Foot) {
                State = 1058;
            } else if(facing == Face.West && occupied == false && part == Part.Head) {
                State = 1059;
            } else if(facing == Face.West && occupied == false && part == Part.Foot) {
                State = 1060;
            } else if(facing == Face.East && occupied == true && part == Part.Head) {
                State = 1061;
            } else if(facing == Face.East && occupied == true && part == Part.Foot) {
                State = 1062;
            } else if(facing == Face.East && occupied == false && part == Part.Head) {
                State = 1063;
            } else if(facing == Face.East && occupied == false && part == Part.Foot) {
                State = 1064;
            }
        }
    }
}
