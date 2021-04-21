using nylium.Core.Block.Blocks;

namespace nylium.Core.Level.Generation.Generators {

    public class FlatWorldGenerator : IWorldGenerator {

        public void GenerateChunk(World world, Chunk chunk) {
            for(int x = 0; x < Chunk.X_SIZE; x++) {
                for(int z = 0; z < Chunk.Z_SIZE; z++) {
                    //chunk.SetBlock(Blocks.BaseBlock.Create(world, "minecraft:bedrock"), x, 0, z);
                    chunk.SetBlock(new BedrockBlock(chunk, x, 0, z), x, 0, z);

                    // checkerboard pattern
                    if((chunk.X + chunk.Z) % 2 != 0) {
                        //chunk.SetBlock(Blocks.BaseBlock.Create(world, "minecraft:cobblestone"), x, 1, z);
                        chunk.SetBlock(new CobblestoneBlock(chunk, x, 0, z), x, 0, z);
                    }
                }
            }
        }

        public string GetName() {
            return "flat";
        }
    }
}
