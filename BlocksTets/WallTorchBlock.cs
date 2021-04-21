// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class WallTorchBlock : BaseBlock {

        public Face Facing { get; }

        public WallTorchBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 142, 1436) { }

        public WallTorchBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 142, state) {
            if(state == 1436) {
                Facing = Face.North;
            } else if(state == 1437) {
                Facing = Face.South;
            } else if(state == 1438) {
                Facing = Face.West;
            } else if(state == 1439) {
                Facing = Face.East;
            }
        }

        public WallTorchBlock(Chunk chunk, int x, int y, int z, Face facing) : base(chunk, x, y, z, 142, 1436) {
if(facing == Face.North) {
                State = 1436;
            } else if(facing == Face.South) {
                State = 1437;
            } else if(facing == Face.West) {
                State = 1438;
            } else if(facing == Face.East) {
                State = 1439;
            }
        }
    }
}
