using System;
using System.Threading.Tasks;
using Microsoft.CSharp.RuntimeBinder;
using nylium.Core.Blocks;

namespace nylium.Core.Level.Generation.Generators {

    public class NoiseWorldGenerator : AbstractWorldGenerator {

        private const int SEA_LEVEL = 64;

        private FastNoiseLite Noise { get; set; }

        public override void Initialize(World world, object args) {
            base.Initialize(world, args);

            try {
                Noise = new(((dynamic) args).seed);
            } catch(RuntimeBinderException) {
                Noise = new(world.Seed);
            }

            Noise.SetNoiseType(FastNoiseLite.NoiseType.OpenSimplex2S);
            Noise.SetFractalType(FastNoiseLite.FractalType.FBm);
            Noise.SetRotationType3D(FastNoiseLite.RotationType3D.ImproveXYPlanes);
        }

        public override void GenerateChunk(Chunk chunk) {
            Parallel.For(0, Chunk.X_SIZE, x => {
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
            });

            //Parallel.For(0, Chunk.Y_SIZE / 2, y => {
            //    for(int x = 0; x < Chunk.X_SIZE; x++) {
            //        for(int z = 0; z < Chunk.Z_SIZE; z++) {
            //            int worldX = (chunk.X * Chunk.X_SIZE) + x;
            //            int worldZ = (chunk.Z * Chunk.Z_SIZE) + z;

            //            float noise = Noise.GetNoise(worldX, worldZ);
            //            noise = (y - -1) / (1 - -1);
            //            noise *= 80;

            //            int height = (int) Math.Floor(noise);

            //        }
            //    }
            //});
        }

        public override string GetName() {
            return "noise";
        }
    }
}