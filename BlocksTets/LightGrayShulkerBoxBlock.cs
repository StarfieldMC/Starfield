// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class LightGrayShulkerBoxBlock : BaseBlock {

        public Face Facing { get; }

        public LightGrayShulkerBoxBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 518, 9334) { }

        public LightGrayShulkerBoxBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 518, state) {
            if(state == 9330) {
                Facing = Face.North;
            } else if(state == 9331) {
                Facing = Face.East;
            } else if(state == 9332) {
                Facing = Face.South;
            } else if(state == 9333) {
                Facing = Face.West;
            } else if(state == 9334) {
                Facing = Face.Up;
            } else if(state == 9335) {
                Facing = Face.Down;
            }
        }

        public LightGrayShulkerBoxBlock(Chunk chunk, int x, int y, int z, Face facing) : base(chunk, x, y, z, 518, 9334) {
if(facing == Face.North) {
                State = 9330;
            } else if(facing == Face.East) {
                State = 9331;
            } else if(facing == Face.South) {
                State = 9332;
            } else if(facing == Face.West) {
                State = 9333;
            } else if(facing == Face.Up) {
                State = 9334;
            } else if(facing == Face.Down) {
                State = 9335;
            }
        }
    }
}
