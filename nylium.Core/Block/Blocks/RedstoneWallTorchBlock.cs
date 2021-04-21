// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class RedstoneWallTorchBlock : BaseBlock {

        public Face Facing { get; }
        public bool Lit { get; }

        public RedstoneWallTorchBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 182, 3889) { }

        public RedstoneWallTorchBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 182, state) {
            if(state == 3889) {
                Facing = Face.North;
                Lit = true;
            } else if(state == 3890) {
                Facing = Face.North;
                Lit = false;
            } else if(state == 3891) {
                Facing = Face.South;
                Lit = true;
            } else if(state == 3892) {
                Facing = Face.South;
                Lit = false;
            } else if(state == 3893) {
                Facing = Face.West;
                Lit = true;
            } else if(state == 3894) {
                Facing = Face.West;
                Lit = false;
            } else if(state == 3895) {
                Facing = Face.East;
                Lit = true;
            } else if(state == 3896) {
                Facing = Face.East;
                Lit = false;
            }
        }

        public RedstoneWallTorchBlock(Chunk chunk, int x, int y, int z, Face facing, bool lit) : base(chunk, x, y, z, 182, 3889) {
if(facing == Face.North && lit == true) {
                State = 3889;
            } else if(facing == Face.North && lit == false) {
                State = 3890;
            } else if(facing == Face.South && lit == true) {
                State = 3891;
            } else if(facing == Face.South && lit == false) {
                State = 3892;
            } else if(facing == Face.West && lit == true) {
                State = 3893;
            } else if(facing == Face.West && lit == false) {
                State = 3894;
            } else if(facing == Face.East && lit == true) {
                State = 3895;
            } else if(facing == Face.East && lit == false) {
                State = 3896;
            }
        }
    }
}
