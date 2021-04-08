using System;
using nylium.Core.Blocks;

namespace nylium.Core.Level.Generation.Generators {

    public class NoiseWorldGenerator : AbstractWorldGenerator {

        private FastNoiseLite Noise { get; set; }

        public override void Initialize(World world, object args) {
            base.Initialize(world, args);
            Noise = new(world.Seed);
            Noise.SetNoiseType(FastNoiseLite.NoiseType.Perlin);
            Noise.SetFractalType(FastNoiseLite.FractalType.FBm);
        }

        public override void GenerateChunk(Chunk chunk) {
            for(int x = 0; x < Chunk.X_SIZE; x++) {
                for(int z = 0; z < Chunk.Z_SIZE; z++) {
                    int worldX = (chunk.X * Chunk.X_SIZE) + x;
                    int worldZ = (chunk.Z * Chunk.Z_SIZE) + z;

                    float y = Noise.GetNoise(worldX, worldZ);
                    y = (y - -1) / (1 - -1);
                    y *= 80;

                    chunk.SetBlock(Block.Create(World, 9), x, (int) Math.Floor(y), z); // grass block

                    for(int _y = 0; _y < (int) Math.Floor(y); _y++) {
                        chunk.SetBlock(Block.Create(World, 10), x, _y, z); // fill with dirt blocks
                    }
                }
            }
        }

        public override string GetName() {
            return "noise";
        }
    }
}