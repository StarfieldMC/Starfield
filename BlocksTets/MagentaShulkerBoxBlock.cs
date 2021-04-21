// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class MagentaShulkerBoxBlock : BaseBlock {

        public Face Facing { get; }

        public MagentaShulkerBoxBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 512, 9298) { }

        public MagentaShulkerBoxBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 512, state) {
            if(state == 9294) {
                Facing = Face.North;
            } else if(state == 9295) {
                Facing = Face.East;
            } else if(state == 9296) {
                Facing = Face.South;
            } else if(state == 9297) {
                Facing = Face.West;
            } else if(state == 9298) {
                Facing = Face.Up;
            } else if(state == 9299) {
                Facing = Face.Down;
            }
        }

        public MagentaShulkerBoxBlock(Chunk chunk, int x, int y, int z, Face facing) : base(chunk, x, y, z, 512, 9298) {
if(facing == Face.North) {
                State = 9294;
            } else if(facing == Face.East) {
                State = 9295;
            } else if(facing == Face.South) {
                State = 9296;
            } else if(facing == Face.West) {
                State = 9297;
            } else if(facing == Face.Up) {
                State = 9298;
            } else if(facing == Face.Down) {
                State = 9299;
            }
        }
    }
}
