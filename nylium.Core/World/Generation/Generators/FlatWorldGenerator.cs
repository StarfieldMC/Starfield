using nylium.Core.Block;

namespace nylium.Core.World.Generation.Generators {

    public class FlatWorldGenerator : IWorldGenerator {

        public void GenerateChunk(GameWorld world, Chunk chunk) {
            for(int x = 0; x < Chunk.X_SIZE; x++) {
                for(int z = 0; z < Chunk.Z_SIZE; z++) {
                    chunk.SetBlock(GameBlock.Create(world, "minecraft:bedrock"), x, 0, z);

                    // checkerboard pattern
                    if((chunk.X + chunk.Z) % 2 != 0) {
                        chunk.SetBlock(GameBlock.Create(world, "minecraft:cobblestone"), x, 1, z);
                    }
                }
            }
        }
    }
}
