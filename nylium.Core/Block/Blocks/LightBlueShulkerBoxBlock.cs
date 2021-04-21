// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class LightBlueShulkerBoxBlock : BaseBlock {

        public Face Facing { get; }

        public LightBlueShulkerBoxBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 513, 9304) { }

        public LightBlueShulkerBoxBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 513, state) {
            if(state == 9300) {
                Facing = Face.North;
            } else if(state == 9301) {
                Facing = Face.East;
            } else if(state == 9302) {
                Facing = Face.South;
            } else if(state == 9303) {
                Facing = Face.West;
            } else if(state == 9304) {
                Facing = Face.Up;
            } else if(state == 9305) {
                Facing = Face.Down;
            }
        }

        public LightBlueShulkerBoxBlock(Chunk chunk, int x, int y, int z, Face facing) : base(chunk, x, y, z, 513, 9304) {
if(facing == Face.North) {
                State = 9300;
            } else if(facing == Face.East) {
                State = 9301;
            } else if(facing == Face.South) {
                State = 9302;
            } else if(facing == Face.West) {
                State = 9303;
            } else if(facing == Face.Up) {
                State = 9304;
            } else if(facing == Face.Down) {
                State = 9305;
            }
        }
    }
}
