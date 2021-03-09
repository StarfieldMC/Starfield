using System;
using System.Collections.Generic;
using System.Diagnostics;
using nylium.Core.World.Generation;
using E = nylium.Core.Entity;

namespace nylium.Core.World {

    public class World {

        private const int initializationChunks = 15; // how big of a chunk grid (square) to generate on initialization
        private int lastEntityId = 0;

        public string Name { get; }

        public List<Chunk> Chunks { get; }
        public List<E.Entity> Entities { get; }

        public IWorldGenerator Generator { get; set; }

        public World(string name, List<Chunk> chunks, List<E.Entity> entities, IWorldGenerator generator) {
            Name = name;
            Chunks = chunks;
            Entities = entities;

            Generator = generator;
        }

        public World(string name, IWorldGenerator generator) {
            Name = name;

            Chunks = new List<Chunk>();
            Entities = new List<E.Entity>();

            Generator = generator;

            int a = (int) Math.Floor(initializationChunks / 2d);
            //int i = 0;

            //Stopwatch chunkStopwatch = new();
            Stopwatch totalStopwatch = new();

            totalStopwatch.Start();

            for(int x = -a; x <= a; x++) {
                for(int z = -a; z <= a; z++) {
                    //Console.Write(string.Format("Generating chunk at [{0},{1}] ({2}/{3})... ", x, z, i + 1, Math.Pow(initializationChunks, 2)));

                    //chunkStopwatch.Start();
                    Chunks.Add(GenerateChunk(x, z));
                    //i++;
                    //chunkStopwatch.Stop();

                    //Console.WriteLine(Math.Round(chunkStopwatch.Elapsed.TotalMilliseconds, 4) + "μs");
                    //chunkStopwatch.Reset();
                }
            }

            totalStopwatch.Stop();
            Console.WriteLine(string.Format("Finished generating world! Took {0}ms", Math.Round(totalStopwatch.Elapsed.TotalMilliseconds, 2)));
        }

        // TODO better way to do this?
        public int GetNextEntityId(E.Entity entity) {
            return ++lastEntityId;
        }

        public Block.Block GetBlock(int x, int y, int z) {
            Chunk chunk = GetChunk((int) Math.Floor(x / (double) Chunk.XSize), (int) Math.Floor(z / (double) Chunk.ZSize));
            return chunk.GetBlock(x % Chunk.XSize, y, z % Chunk.ZSize);
        }

        public void SetBlock(Block.Block block, int x, int y, int z) {
            Chunk chunk = GetChunk((int) Math.Floor(x / (double) Chunk.XSize), (int) Math.Floor(z / (double) Chunk.ZSize));
            chunk.SetBlock(block, x % Chunk.XSize, y, z % Chunk.ZSize);
        }

        // TODO better way to do this?
        public Chunk GetChunk(int x, int z) {
            for(int i = 0; i < Chunks.Count; i++) {
                Chunk chunk = Chunks[i];

                if(chunk.X == x && chunk.Z == z) {
                    return chunk;
                }
            }

            Chunk generated = GenerateChunk(x, z);
            Chunks.Add(generated);

            return generated;
        }

        public Chunk GenerateChunk(int x, int z) {
            Chunk chunk = new(this, x, z);
            Generator.GenerateChunk(this, chunk);

            return chunk;
        }
    }
}
