// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class DeadBubbleCoralWallFanBlock : BaseBlock {

        public Face Facing { get; }
        public bool Waterlogged { get; }

        public DeadBubbleCoralWallFanBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 610, 9580) { }

        public DeadBubbleCoralWallFanBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 610, state) {
            if(state == 9580) {
                Facing = Face.North;
                Waterlogged = true;
            } else if(state == 9581) {
                Facing = Face.North;
                Waterlogged = false;
            } else if(state == 9582) {
                Facing = Face.South;
                Waterlogged = true;
            } else if(state == 9583) {
                Facing = Face.South;
                Waterlogged = false;
            } else if(state == 9584) {
                Facing = Face.West;
                Waterlogged = true;
            } else if(state == 9585) {
                Facing = Face.West;
                Waterlogged = false;
            } else if(state == 9586) {
                Facing = Face.East;
                Waterlogged = true;
            } else if(state == 9587) {
                Facing = Face.East;
                Waterlogged = false;
            }
        }

        public DeadBubbleCoralWallFanBlock(Chunk chunk, int x, int y, int z, Face facing, bool waterlogged) : base(chunk, x, y, z, 610, 9580) {
if(facing == Face.North && waterlogged == true) {
                State = 9580;
            } else if(facing == Face.North && waterlogged == false) {
                State = 9581;
            } else if(facing == Face.South && waterlogged == true) {
                State = 9582;
            } else if(facing == Face.South && waterlogged == false) {
                State = 9583;
            } else if(facing == Face.West && waterlogged == true) {
                State = 9584;
            } else if(facing == Face.West && waterlogged == false) {
                State = 9585;
            } else if(facing == Face.East && waterlogged == true) {
                State = 9586;
            } else if(facing == Face.East && waterlogged == false) {
                State = 9587;
            }
        }
    }
}
