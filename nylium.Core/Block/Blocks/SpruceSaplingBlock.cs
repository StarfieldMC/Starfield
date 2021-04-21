// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class SpruceSaplingBlock : BaseBlock {

        public int Stage { get; }

        public SpruceSaplingBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 20, 23) { }

        public SpruceSaplingBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 20, state) {
            if(state == 23) {
                Stage = 0;
            } else if(state == 24) {
                Stage = 1;
            }
        }

        public SpruceSaplingBlock(Chunk chunk, int x, int y, int z, int stage) : base(chunk, x, y, z, 20, 23) {
if(stage == 0) {
                State = 23;
            } else if(stage == 1) {
                State = 24;
            }
        }
    }
}
