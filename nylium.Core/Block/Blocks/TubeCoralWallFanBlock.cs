// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class TubeCoralWallFanBlock : BaseBlock {

        public Face Facing { get; }
        public bool Waterlogged { get; }

        public TubeCoralWallFanBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 613, 9604) { }

        public TubeCoralWallFanBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 613, state) {
            if(state == 9604) {
                Facing = Face.North;
                Waterlogged = true;
            } else if(state == 9605) {
                Facing = Face.North;
                Waterlogged = false;
            } else if(state == 9606) {
                Facing = Face.South;
                Waterlogged = true;
            } else if(state == 9607) {
                Facing = Face.South;
                Waterlogged = false;
            } else if(state == 9608) {
                Facing = Face.West;
                Waterlogged = true;
            } else if(state == 9609) {
                Facing = Face.West;
                Waterlogged = false;
            } else if(state == 9610) {
                Facing = Face.East;
                Waterlogged = true;
            } else if(state == 9611) {
                Facing = Face.East;
                Waterlogged = false;
            }
        }

        public TubeCoralWallFanBlock(Chunk chunk, int x, int y, int z, Face facing, bool waterlogged) : base(chunk, x, y, z, 613, 9604) {
if(facing == Face.North && waterlogged == true) {
                State = 9604;
            } else if(facing == Face.North && waterlogged == false) {
                State = 9605;
            } else if(facing == Face.South && waterlogged == true) {
                State = 9606;
            } else if(facing == Face.South && waterlogged == false) {
                State = 9607;
            } else if(facing == Face.West && waterlogged == true) {
                State = 9608;
            } else if(facing == Face.West && waterlogged == false) {
                State = 9609;
            } else if(facing == Face.East && waterlogged == true) {
                State = 9610;
            } else if(facing == Face.East && waterlogged == false) {
                State = 9611;
            }
        }
    }
}
