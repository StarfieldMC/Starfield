// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class HornCoralWallFanBlock : BaseBlock {

        public Face Facing { get; }
        public bool Waterlogged { get; }

        public HornCoralWallFanBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 617, 9636) { }

        public HornCoralWallFanBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 617, state) {
            if(state == 9636) {
                Facing = Face.North;
                Waterlogged = true;
            } else if(state == 9637) {
                Facing = Face.North;
                Waterlogged = false;
            } else if(state == 9638) {
                Facing = Face.South;
                Waterlogged = true;
            } else if(state == 9639) {
                Facing = Face.South;
                Waterlogged = false;
            } else if(state == 9640) {
                Facing = Face.West;
                Waterlogged = true;
            } else if(state == 9641) {
                Facing = Face.West;
                Waterlogged = false;
            } else if(state == 9642) {
                Facing = Face.East;
                Waterlogged = true;
            } else if(state == 9643) {
                Facing = Face.East;
                Waterlogged = false;
            }
        }

        public HornCoralWallFanBlock(Chunk chunk, int x, int y, int z, Face facing, bool waterlogged) : base(chunk, x, y, z, 617, 9636) {
if(facing == Face.North && waterlogged == true) {
                State = 9636;
            } else if(facing == Face.North && waterlogged == false) {
                State = 9637;
            } else if(facing == Face.South && waterlogged == true) {
                State = 9638;
            } else if(facing == Face.South && waterlogged == false) {
                State = 9639;
            } else if(facing == Face.West && waterlogged == true) {
                State = 9640;
            } else if(facing == Face.West && waterlogged == false) {
                State = 9641;
            } else if(facing == Face.East && waterlogged == true) {
                State = 9642;
            } else if(facing == Face.East && waterlogged == false) {
                State = 9643;
            }
        }
    }
}
