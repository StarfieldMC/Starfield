// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class BrownShulkerBoxBlock : BaseBlock {

        public Face Facing { get; }

        public BrownShulkerBoxBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 522, 9358) { }

        public BrownShulkerBoxBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 522, state) {
            if(state == 9354) {
                Facing = Face.North;
            } else if(state == 9355) {
                Facing = Face.East;
            } else if(state == 9356) {
                Facing = Face.South;
            } else if(state == 9357) {
                Facing = Face.West;
            } else if(state == 9358) {
                Facing = Face.Up;
            } else if(state == 9359) {
                Facing = Face.Down;
            }
        }

        public BrownShulkerBoxBlock(Chunk chunk, int x, int y, int z, Face facing) : base(chunk, x, y, z, 522, 9358) {
if(facing == Face.North) {
                State = 9354;
            } else if(facing == Face.East) {
                State = 9355;
            } else if(facing == Face.South) {
                State = 9356;
            } else if(facing == Face.West) {
                State = 9357;
            } else if(facing == Face.Up) {
                State = 9358;
            } else if(facing == Face.Down) {
                State = 9359;
            }
        }
    }
}
