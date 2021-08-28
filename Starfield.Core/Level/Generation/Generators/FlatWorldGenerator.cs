using Starfield.Core.Block.Blocks;

namespace Starfield.Core.Level.Generation.Generators {

    public class FlatWorldGenerator : IWorldGenerator {

        public void GenerateChunk(World world, Chunk chunk) {
            for(int x = 0; x < Chunk.X_SIZE; x++) {
                for(int z = 0; z < Chunk.Z_SIZE; z++) {
                    chunk.SetBlock(new BlockBedrock(), x, 0, z);

                    // checkerboard pattern
                    if((chunk.X + chunk.Z) % 2 != 0) {
                        chunk.SetBlock(new BlockCobblestone(), x, 1, z);
                    }
                }
            }
        }

        public string GetName() {
            return "flat";
        }
    }
}
