using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using fNbt;
using fNbt.Tags;
using NetCoreServer;
using nylium.Core.Block;
using nylium.Core.Entity;
using nylium.Core.Entity.Entities;
using nylium.Core.Networking;
using nylium.Core.Networking.Packet.Server.Play;
using nylium.Core.World.Generation;
using nylium.Core.World.Storage;
using nylium.Core.World.Storage.Formats;

namespace nylium.Core.World {

    public class GameWorld {

        private const int initializationChunks = 32; // how big of a chunk grid (square) to generate on initialization
        private int lastEntityId = 0;

        public GameServer Server { get; }

        public string Name { get; }
        public long Age { get; set; }

        public Dictionary<(int, int), Chunk> Chunks { get; }

        public List<PlayerEntity> PlayerEntities { get; }
        public List<GameEntity> Entities { get; }

        public AbstractWorldFormat Format { get; set; }
        public IWorldGenerator Generator { get; set; }

        private Thread WorldThread { get; }

        public GameWorld(GameServer server, string name, IWorldGenerator generator) {
            Server = server;
            Name = name;

            Chunks = new();
            PlayerEntities = new();
            Entities = new();

            Generator = generator;

            if(!Directory.Exists(GetDirectory()) || !File.Exists(Path.Combine(GetDirectory(), "chunks.bin"))) {
                Directory.CreateDirectory(GetDirectory());
                Format = new WaterWorldFormat(this);

                // world does not exist - generate
                int a = (int) Math.Floor(initializationChunks / 2d);
                int i = 0;

                Stopwatch totalStopwatch = new();
                totalStopwatch.Start();

                for(int x = -a; x <= a; x++) {
                    for(int z = -a; z <= a; z++) {
                        LoadChunk(x, z);
                        i++;
                    }
                }

                totalStopwatch.Stop();
                Console.WriteLine(string.Format("Finished generating world! ({0} chunks) Took {1}ms", i, Math.Round(totalStopwatch.Elapsed.TotalMilliseconds, 2)));

                Format.Save();
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
            Server.MulticastAsync(timeUpdate);

            if(Age % 24000 == 0) {
                Task.Run(() => Format.Save());
            }
        }

        // TODO better way to do this?
        public int GetNextEntityId(GameEntity entity) {
            return ++lastEntityId;
        }

        public GameBlock GetBlock(int x, int y, int z) {
            Chunk chunk = GetChunk((int) Math.Floor(x / (double) Chunk.X_SIZE), (int) Math.Floor(z / (double) Chunk.Z_SIZE));

            // of course C# has to be different and have a remainder operator instead of modulo
            int Mod(int x, int m) {
                return ((x % m) + m) % m;
            }

            return chunk.GetBlock(Mod(x, Chunk.X_SIZE), y, Mod(z, Chunk.Z_SIZE));
        }

        public void SetBlock(GameBlock block, int x, int y, int z) {
            Chunk chunk = GetChunk((int) Math.Floor(x / (double) Chunk.X_SIZE), (int) Math.Floor(z / (double) Chunk.Z_SIZE));

            // of course C# has to be different and have a remainder operator instead of modulo
            int Mod(int x, int m) {
                return ((x % m) + m) % m;
            }

            chunk.SetBlock(block, Mod(x, Chunk.X_SIZE), y, Mod(z, Chunk.Z_SIZE));
        }

        public Chunk GetChunk(int chunkX, int chunkZ) {
            return Chunks.ContainsKey((chunkX, chunkZ)) ? Chunks[(chunkX, chunkZ)] : LoadChunk(chunkX, chunkZ);
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

        public List<GameClient> GetClientsWithChunkLoaded(int chunkX, int chunkZ) {
            List<GameClient> clients = new();

            Chunk chunk = GetChunk(chunkX, chunkZ);

            foreach(TcpSession session in Server.GetSessions()) {
                if(session is GameClient client) {
                    if(client.GameState == GameClient.State.Playing) {
                        if(client.LoadedChunks.Contains(chunk)) {
                            clients.Add(client);
                        }
                    }
                }
            }

            return clients;
        }

        public Chunk LoadChunk(int x, int z) {
            Chunk chunk = Format.Load(x, z);

            if(chunk == null) {
                chunk = new(this, x, z);
                Generator.GenerateChunk(this, chunk);
            }

            Chunks.Add((x, z), chunk);
            return chunk;
        }

        public string GetDirectory() {
            return Path.Combine(Nylium.WORLDS_DIRECTORY, Name);
        }
    }
}
