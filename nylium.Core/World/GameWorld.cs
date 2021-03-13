using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using nylium.Core.Packet.Server.Play;
using nylium.Core.World.Generation;
using E = nylium.Core.Entity;

namespace nylium.Core.World {

    public class GameWorld {

        private const int initializationChunks = 32; // how big of a chunk grid (square) to generate on initialization
        private int lastEntityId = 0;

        public string Name { get; }
        public long Age { get; set; }

        public Dictionary<(int, int), Chunk> Chunks { get; }
        public List<E.GameEntity> Entities { get; }
        public IWorldGenerator Generator { get; set; }

        private Thread WorldThread { get; }

        public GameWorld(string name, Dictionary<(int, int), Chunk> chunks, List<E.GameEntity> entities, IWorldGenerator generator) {
            Name = name;

            Chunks = chunks;
            Entities = entities;
            Generator = generator;

            WorldThread = new(Update);
            WorldThread.Name = "World update thread";
            WorldThread.Start();
        }

        public GameWorld(string name, IWorldGenerator generator) {
            Name = name;

            Chunks = new();
            Entities = new();

            Generator = generator;

            int a = (int) Math.Floor(initializationChunks / 2d);
            int i = 0;

            //Stopwatch chunkStopwatch = new();
            Stopwatch totalStopwatch = new();

            totalStopwatch.Start();

            for(int x = -a; x <= a; x++) {
                for(int z = -a; z <= a; z++) {
                    //Console.Write(string.Format("Generating chunk at [{0},{1}] ({2}/{3})... ", x, z, i + 1, Math.Pow(initializationChunks, 2)));

                    //chunkStopwatch.Start();
                    GenerateChunk(x, z);
                    i++;
                    //chunkStopwatch.Stop();

                    //Console.WriteLine(Math.Round(chunkStopwatch.Elapsed.TotalMilliseconds, 4) + "μs");
                    //chunkStopwatch.Reset();
                }
            }

            totalStopwatch.Stop();
            Console.WriteLine(string.Format("Finished generating world! ({0} chunks) Took {1}ms", i, Math.Round(totalStopwatch.Elapsed.TotalMilliseconds, 2)));

            WorldThread = new(Update);
            WorldThread.Name = "World update thread";
            WorldThread.Start();
        }

        private void Update() {
            long now;
            long last = Stopwatch.GetTimestamp() / TimeSpan.TicksPerMillisecond;

            do {
                now = Stopwatch.GetTimestamp() / TimeSpan.TicksPerMillisecond;

                if(now - last >= 1000 / GameServer.TARGET_TPS) {
                    Tick();
                    last = Stopwatch.GetTimestamp() / TimeSpan.TicksPerMillisecond;
                } else {
                    Thread.Sleep(1);
                }
            } while(true);
        }

        private void Tick() {
            Age++;

            SP4ETimeUpdate timeUpdate = new(Age, Age % 24000);
            GameServer.Broadcast(timeUpdate.ToBytes());

            timeUpdate.Dispose();
        }

        // TODO better way to do this?
        public int GetNextEntityId(E.GameEntity entity) {
            return ++lastEntityId;
        }

        public Block.GameBlock GetBlock(int x, int y, int z) {
            Chunk chunk = GetChunk((int) Math.Floor(x / (double) Chunk.X_SIZE), (int) Math.Floor(z / (double) Chunk.Z_SIZE));
            return chunk.GetBlock(x % Chunk.X_SIZE, y, z % Chunk.Z_SIZE);
        }

        public void SetBlock(Block.GameBlock block, int x, int y, int z) {
            Chunk chunk = GetChunk((int) Math.Floor(x / (double) Chunk.X_SIZE), (int) Math.Floor(z / (double) Chunk.Z_SIZE));
            chunk.SetBlock(block, x % Chunk.X_SIZE, y, z % Chunk.Z_SIZE);
        }

        // pisspart u need to remember to repopulate the chunks array when u restart server else it will regenerate the chunks tak tak byczq
        public Chunk GetChunk(int chunkX, int chunkZ) {
            return Chunks.ContainsKey((chunkX, chunkZ)) ? Chunks[(chunkX, chunkZ)] : GenerateChunk(chunkX, chunkZ);
        }

        public Chunk[] GetChunksInViewDistance(int chunkX, int chunkZ, sbyte viewDistance) {
            Chunk[] chunks = new Chunk[(int) Math.Pow((viewDistance * 2) + 1, 2)];
            int i = 0;

            for(int x = chunkX - viewDistance; x <= chunkX + viewDistance; x++) {
                for(int z = chunkZ - viewDistance; z <= chunkZ + viewDistance; z++) {
                    chunks[i] = GetChunk(x, z);
                    i++;
                }
            }

            return chunks;
        }

        public Chunk GenerateChunk(int x, int z) {
            Chunk chunk = new(this, x, z);
            Generator.GenerateChunk(this, chunk);
            Chunks.Add((x, z), chunk);

            return chunk;
        }
    }
}
