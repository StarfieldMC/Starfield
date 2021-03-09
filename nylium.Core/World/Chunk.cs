using B = nylium.Core.Block;

namespace nylium.Core.World {

    public class Chunk {

        public const int XSize = 16;
        public const int ZSize = 16;
        public const int YSize = 256;

        public World Parent { get; }

        public int X { get; }
        public int Z { get; }

        public B.Block[][][] Blocks { get; }

        public Chunk(World parent, int x, int z) {
            Parent = parent;

            X = x;
            Z = z;

            Blocks = new B.Block[YSize][][];
        }

        public Chunk(World parent, int x, int z, B.Block[][][] blocks) {
            Parent = parent;

            X = x;
            Z = z;

            Blocks = blocks;
        }

        public void SetBlock(B.Block block, int x, int y, int z) {
            if(Blocks[y] == null) {
                Blocks[y] = new B.Block[XSize][];
            }

            if(Blocks[y][x] == null) {
                Blocks[y][x] = new B.Block[ZSize];
            }

            Blocks[y][x][z] = block;
        }

        public B.Block GetBlock(int x, int y, int z) {
            if(Blocks[y] == null) return null;
            if(Blocks[y][x] == null) return null;

            return Blocks[y][x][z];
        }
    }
}
