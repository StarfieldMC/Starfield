using nylium.Core.Blocks;

namespace nylium.Core.Level.Generation.Generators {

    public class FlatWorldGenerator : AbstractWorldGenerator {

        public FlatWorldGenerator(World world, dynamic args) : base(world, (object) args) {
            // TODO process arguments here for generating custom flat worlds
        }

        public override void GenerateChunk(Chunk chunk) {
            for(int x = 0; x < Chunk.X_SIZE; x++) {
                for(int z = 0; z < Chunk.Z_SIZE; z++) {
                    chunk.SetBlock(Block.Create(World, "minecraft:bedrock"), x, 0, z);

                    // checkerboard pattern
                    if((chunk.X + chunk.Z) % 2 != 0) {
                        chunk.SetBlock(Block.Create(World, "minecraft:cobblestone"), x, 1, z);
                    }
                }
            }
        }

        public override string GetName() {
            return "flat";
        }
    }
}
