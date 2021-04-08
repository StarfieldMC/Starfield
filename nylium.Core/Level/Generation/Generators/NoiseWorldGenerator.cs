using System;
using System.Collections.Generic;
using Medallion;
using Microsoft.CSharp.RuntimeBinder;
using nylium.Core.Blocks;
using nylium.Extensions;

namespace nylium.Core.Level.Generation.Generators {

    public class NoiseWorldGenerator : AbstractWorldGenerator {

        // temporary - move to Chunk.cs later
        private readonly Dictionary<Chunk, Biome> biomeDict = new();

        private long Seed { get; set; }

        private Random Random { get; set; }
        private FastNoiseLite Noise { get; set; }

        public override void Initialize(World world, object args) {
            base.Initialize(world, args);

            try {
                Seed = ((dynamic) args).seed;
            } catch(RuntimeBinderException) {
                Seed = world.Seed;
            }

            Random = Rand.CreateJavaRandom(Seed);

            Noise = new(Seed);
            Noise.SetNoiseType(FastNoiseLite.NoiseType.OpenSimplex2S);
            Noise.SetFractalType(FastNoiseLite.FractalType.FBm);
        }

        public override void GenerateChunk(Chunk chunk) {
            Chunk[] adjacentChunks = chunk.GetAdjacentChunks();
            Dictionary<Biome, float> chances = new() {
                { Biome.Plains, 0.5f },
                { Biome.Mountains, 0.5f }
            };

            foreach(Chunk c in adjacentChunks) {
                if(c == null) continue;

                if(biomeDict.ContainsKey(c)) {
                    foreach(KeyValuePair<Biome, float> entry in chances) {
                        if(entry.Key == biomeDict[c]) {
                            chances[entry.Key] += 0.25f;
                        } else {
                            chances[entry.Key] -= 0.25f;
                        }
                    }
                }
            }

            Biome biome = chances.RandomElementByWeight(e => e.Value, Random).Key;
            biomeDict[chunk] = biome;

            for(int x = 0; x < Chunk.X_SIZE; x++) {
                for(int z = 0; z < Chunk.Z_SIZE; z++) {
                    int worldX = (chunk.X * Chunk.X_SIZE) + x;
                    int worldZ = (chunk.Z * Chunk.Z_SIZE) + z;

                    float y = Noise.GetNoise(worldX, worldZ);
                    y = (y - -1) / (1 - -1);
                    y *= 80;

                    chunk.SetBlock(Block.Create(World, biome == Biome.Plains ? (ushort) 9 : (ushort) 1), x, (int) Math.Floor(y), z);

                    for(int _y = 0; _y < (int) Math.Floor(y); _y++) {
                        chunk.SetBlock(Block.Create(World, 10), x, _y, z); // fill with dirt blocks
                    }
                }
            }
        }

        public override string GetName() {
            return "noise";
        }

        private enum Biome {

            Plains,
            Mountains
        }
    }
}