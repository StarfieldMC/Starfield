// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class GreenShulkerBoxBlock : BaseBlock {

        public Face Facing { get; }

        public GreenShulkerBoxBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 523, 9364) { }

        public GreenShulkerBoxBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 523, state) {
            if(state == 9360) {
                Facing = Face.North;
            } else if(state == 9361) {
                Facing = Face.East;
            } else if(state == 9362) {
                Facing = Face.South;
            } else if(state == 9363) {
                Facing = Face.West;
            } else if(state == 9364) {
                Facing = Face.Up;
            } else if(state == 9365) {
                Facing = Face.Down;
            }
        }

        public GreenShulkerBoxBlock(Chunk chunk, int x, int y, int z, Face facing) : base(chunk, x, y, z, 523, 9364) {
if(facing == Face.North) {
                State = 9360;
            } else if(facing == Face.East) {
                State = 9361;
            } else if(facing == Face.South) {
                State = 9362;
            } else if(facing == Face.West) {
                State = 9363;
            } else if(facing == Face.Up) {
                State = 9364;
            } else if(facing == Face.Down) {
                State = 9365;
            }
        }
    }
}
