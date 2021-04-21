// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class TallGrassBlock : BaseBlock {

        public Half Half { get; }

        public TallGrassBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 414, 7898) { }

        public TallGrassBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 414, state) {
            if(state == 7897) {
                Half = Half.Upper;
            } else if(state == 7898) {
                Half = Half.Lower;
            }
        }

        public TallGrassBlock(Chunk chunk, int x, int y, int z, Half half) : base(chunk, x, y, z, 414, 7898) {
if(half == Half.Upper) {
                State = 7897;
            } else if(half == Half.Lower) {
                State = 7898;
            }
        }
    }
}
