namespace nylium.Core.World.Generation.Generators {

    public class FlatWorldGenerator : IWorldGenerator {

        public void GenerateChunk(World world, Chunk chunk) {
            for(int x = 0; x < Chunk.XSize; x++) {
                for(int z = 0; z < Chunk.ZSize; z++) {
                    chunk.SetBlock(Block.Block.Create(world, 1, x, 0, z), x, 0, z); // stone
                }
            }
        }
    }
}
