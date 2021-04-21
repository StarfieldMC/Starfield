// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class ZombieWallHeadBlock : BaseBlock {

        public Face Facing { get; }

        public ZombieWallHeadBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 319, 6550) { }

        public ZombieWallHeadBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 319, state) {
            if(state == 6550) {
                Facing = Face.North;
            } else if(state == 6551) {
                Facing = Face.South;
            } else if(state == 6552) {
                Facing = Face.West;
            } else if(state == 6553) {
                Facing = Face.East;
            }
        }

        public ZombieWallHeadBlock(Chunk chunk, int x, int y, int z, Face facing) : base(chunk, x, y, z, 319, 6550) {
if(facing == Face.North) {
                State = 6550;
            } else if(facing == Face.South) {
                State = 6551;
            } else if(facing == Face.West) {
                State = 6552;
            } else if(facing == Face.East) {
                State = 6553;
            }
        }
    }
}
