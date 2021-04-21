// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class BlackShulkerBoxBlock : BaseBlock {

        public Face Facing { get; }

        public BlackShulkerBoxBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 525, 9376) { }

        public BlackShulkerBoxBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 525, state) {
            if(state == 9372) {
                Facing = Face.North;
            } else if(state == 9373) {
                Facing = Face.East;
            } else if(state == 9374) {
                Facing = Face.South;
            } else if(state == 9375) {
                Facing = Face.West;
            } else if(state == 9376) {
                Facing = Face.Up;
            } else if(state == 9377) {
                Facing = Face.Down;
            }
        }

        public BlackShulkerBoxBlock(Chunk chunk, int x, int y, int z, Face facing) : base(chunk, x, y, z, 525, 9376) {
if(facing == Face.North) {
                State = 9372;
            } else if(facing == Face.East) {
                State = 9373;
            } else if(facing == Face.South) {
                State = 9374;
            } else if(facing == Face.West) {
                State = 9375;
            } else if(facing == Face.Up) {
                State = 9376;
            } else if(facing == Face.Down) {
                State = 9377;
            }
        }
    }
}
