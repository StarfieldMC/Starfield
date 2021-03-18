using B = nylium.Core.Block;

namespace nylium.Core.World {

    public class Chunk {

        public const int X_SIZE = 16;
        public const int Z_SIZE = 16;
        public const int Y_SIZE = 256;

        public GameWorld Parent { get; }

        public int X { get; }
        public int Z { get; }

        public B.GameBlock[][][] Blocks { get; }

        public Chunk(GameWorld parent, int x, int z) {
            Parent = parent;

            X = x;
            Z = z;

            Blocks = new B.GameBlock[Y_SIZE][][];
        }

        public Chunk(GameWorld parent, int x, int z, B.GameBlock[][][] blocks) {
            Parent = parent;

            X = x;
            Z = z;

            Blocks = blocks;
        }

        public void SetBlock(B.GameBlock block, int x, int y, int z) {
            if(Blocks[y] == null) {
                Blocks[y] = new B.GameBlock[X_SIZE][];
            }

            if(Blocks[y][x] == null) {
                Blocks[y][x] = new B.GameBlock[Z_SIZE];
            }

            Blocks[y][x][z] = block;
        }

        public B.GameBlock GetBlock(int x, int y, int z) {
            if(Blocks[y] == null) return null;
            if(Blocks[y][x] == null) return null;

            return Blocks[y][x][z];
        }

        public int GetBlockCountInSection(int section, bool nonAir = true) {
            int count = 0;

            int startY = section * 16;
            int endY = startY + 15;

            if(nonAir) {
                for(int y = startY; y <= endY; y++) {
                    for(int z = 0; z < Z_SIZE; z++) {
                        for(int x = 0; x < X_SIZE; x++) {
                            B.GameBlock block = GetBlock(x, y, z);

                            if(block != null) {
                                count++;
                            }
                        }
                    }
                }
            } else {
                for(int y = startY; y <= endY; y++) {
                    for(int z = 0; z < Z_SIZE; z++) {
                        for(int x = 0; x < X_SIZE; x++) {
                            B.GameBlock block = GetBlock(x, y, z);

                            if(block == null) {
                                count++;
                            }
                        }
                    }
                }
            }

            return count;
        }

        public int[] GetBlocksInSection(int section) {
            int[] blocks = new int[16 * 16 * 16];

            int startY = section * 16;
            int endY = startY + 15;

            int i = 0;

            for(int y = startY; y <= endY; y++) {
                for(int z = 0; z < Z_SIZE; z++) {
                    for(int x = 0; x < X_SIZE; x++) {
                        B.GameBlock block = GetBlock(x, y, z);

                        if(block != null) {
                            blocks[i] = block.StateId;
                        } else {
                            blocks[i] = 0;
                        }

                        i++;
                    }
                }
            }

            return blocks;
        }
    }
}
