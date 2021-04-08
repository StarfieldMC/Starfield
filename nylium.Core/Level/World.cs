﻿using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using NetCoreServer;
using nylium.Core.Blocks;
using nylium.Core.Entity;
using nylium.Core.Entity.Entities;
using nylium.Core.Level.Generation;
using nylium.Core.Level.Storage;
using nylium.Core.Level.Storage.Formats;
using nylium.Core.Networking;
using nylium.Core.Networking.Packet.Server.Play;
using nylium.Utilities.Caching;
using Serilog;

namespace nylium.Core.Level {

    public class World {

        private const int initializationChunks = 2; // how big of a chunk grid (square) to generate on initialization
        private int lastEntityId = 0;

        public MinecraftServer Server { get; }

        public string Name { get; }
        public long Age { get; set; }
        public long Seed { get; set; }

        //public Dictionary<(int, int), Chunk> Chunks { get; }
        public TimedCache<Chunk> Chunks { get; }

        public List<PlayerEntity> PlayerEntities { get; }
        public List<BaseEntity> Entities { get; }

        public AbstractWorldFormat Format { get; set; }
        public AbstractWorldGenerator Generator { get; set; }

        private Thread WorldThread { get; }

        public World(MinecraftServer server, string name, AbstractWorldGenerator generator, object generatorArgs) {
            Server = server;
            Name = name;

            byte[] buffer = new byte[8];
            new Random().NextBytes(buffer);

            Seed = BinaryPrimitives.ReadInt64LittleEndian(buffer);

            Chunks = new("Chunk cache", TimeSpan.FromMinutes(5));
            PlayerEntities = new();
            Entities = new();

            Generator = generator;
            generator.Initialize(this, generatorArgs);

            if(!Directory.Exists(GetDirectory())) {
#if !DEBUG
                Directory.CreateDirectory(GetDirectory());
                Format = new WaterWorldFormat(this);
#endif

                // world does not exist - generate
                int a = (int) Math.Floor(initializationChunks / 2d);
                int i = 0;

                Stopwatch chunkStopwatch = new();
                double chunkAvg = 0;

                Stopwatch totalStopwatch = new();
                totalStopwatch.Start();

                for(int x = -a; x <= a; x++) {
                    for(int z = -a; z <= a; z++) {
                        chunkStopwatch.Start();
                        LoadChunk(x, z);
                        chunkStopwatch.Stop();

                        chunkAvg += Math.Round(chunkStopwatch.Elapsed.TotalMilliseconds, 2);
                        chunkStopwatch.Reset();

                        i++;
                    }
                }

                chunkAvg /= i;

                totalStopwatch.Stop();
                Log.Information(string.Format("Finished generating world! ({0} chunks, {1}ms/chunk avg) Took {2}ms",
                    i, Math.Round(chunkAvg, 3), Math.Round(totalStopwatch.Elapsed.TotalMilliseconds, 2)));

#if !DEBUG
                Format.Save();
#endif
            } else {
                Format = new WaterWorldFormat(this);
                Format.Load();
            }

            WorldThread = new(Update);
            WorldThread.Name = "World update thread";
            WorldThread.Start();
        }

        private void Update() {
            long now;
            long last = Stopwatch.GetTimestamp() / TimeSpan.TicksPerMillisecond;

            do {
                now = Stopwatch.GetTimestamp() / TimeSpan.TicksPerMillisecond;

                if(now - last >= 1000 / MinecraftServer.TARGET_TPS) {
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
            Server.MulticastAsync(timeUpdate);

            if(Age % 24000 == 0) {
                if(Format != null) Task.Run(() => Format.Save());
            }
        }

        // TODO better way to do this?
        public int GetNextEntityId(BaseEntity entity) {
            return ++lastEntityId;
        }

        public Blocks.Block GetBlock(int x, int y, int z) {
            Chunk chunk = GetChunk((int) Math.Floor(x / (double) Chunk.X_SIZE), (int) Math.Floor(z / (double) Chunk.Z_SIZE));

            // of course C# has to be different and have a remainder operator instead of modulo
            int Mod(int x, int m) {
                return ((x % m) + m) % m;
            }

            return chunk.GetBlock(Mod(x, Chunk.X_SIZE), y, Mod(z, Chunk.Z_SIZE));
        }

        public void SetBlock(Block block, int x, int y, int z) {
            Chunk chunk = GetChunk((int) Math.Floor(x / (double) Chunk.X_SIZE), (int) Math.Floor(z / (double) Chunk.Z_SIZE));

            // of course C# has to be different and have a remainder operator instead of modulo
            int Mod(int x, int m) {
                return ((x % m) + m) % m;
            }

            chunk.SetBlock(block, Mod(x, Chunk.X_SIZE), y, Mod(z, Chunk.Z_SIZE));
        }

        public Chunk GetChunk(int chunkX, int chunkZ) {
            string key = chunkX.ToString() + chunkZ.ToString();
            return Chunks.Contains(key) ? Chunks.Get(key) : LoadChunk(chunkX, chunkZ);
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

        public List<MinecraftClient> GetClientsWithChunkLoaded(int chunkX, int chunkZ) {
            List<MinecraftClient> clients = new();

            Chunk chunk = GetChunk(chunkX, chunkZ);

            foreach(TcpSession session in Server.GetSessions()) {
                if(session is MinecraftClient client) {
                    if(client.GameState == MinecraftClient.State.Playing) {
                        if(client.LoadedChunks.Contains(chunk)) {
                            clients.Add(client);
                        }
                    }
                }
            }

            return clients;
        }

        public Chunk LoadChunk(int x, int z) {
            Chunk chunk = new(this, x, z);

            if(Format != null) {
                if(!Format.Load(chunk)) Generator.GenerateChunk(chunk);
            } else {
                Generator.GenerateChunk(chunk);
            }

            Chunks.Set(x.ToString() + z.ToString(), chunk);
            return chunk;
        }

        public string GetDirectory() {
            return Path.Combine(Nylium.WORLDS_DIRECTORY, Name);
        }
    }
}
