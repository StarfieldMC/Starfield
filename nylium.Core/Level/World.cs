using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using NetCoreServer;
using nylium.Core.Block;
using nylium.Core.Entity;
using nylium.Core.Entity.Entities;
using nylium.Core.Level.Generation;
using nylium.Core.Level.Storage;
using nylium.Core.Level.Storage.Formats;
using nylium.Core.Networking;
using nylium.Core.Networking.Packet.Server.Play;
using nylium.Logging;
using nylium.Utilities.Caching;

namespace nylium.Core.Level {

    public class World {

        private const int initializationChunks = 32; // how big of a chunk grid (square) to generate on initialization
        private int lastEntityId = 0;

        public MinecraftServer Server { get; }

        public string Name { get; }
        public long Age { get; set; }

        //public Dictionary<(int, int), Chunk> Chunks { get; }
        public TimedCache<Chunk> Chunks { get; }

        public List<PlayerEntity> PlayerEntities { get; }
        public List<BaseEntity> Entities { get; }

        public AbstractWorldFormat Format { get; set; }
        public IWorldGenerator Generator { get; set; }

        private Thread WorldThread { get; }

        public World(MinecraftServer server, string name, IWorldGenerator generator) {
            Server = server;
            Name = name;

            Chunks = new TimedCache<Chunk>("Chunk cache", TimeSpan.FromMinutes(5));
            PlayerEntities = new List<PlayerEntity>();
            Entities = new List<BaseEntity>();

            Generator = generator;

            if(!Directory.Exists(GetDirectory())) {
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
                Logger.Info(
                    $"Finished generating world! ({i} chunks) Took {Math.Round(totalStopwatch.Elapsed.TotalMilliseconds, 2)}ms");

                Format.Save();
            } else {
                Format = new WaterWorldFormat(this);
                Format.Load();
            }

            WorldThread = new Thread(Update);
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

        private int _timeUpdateCounter = 0;

        // TODO fix time update being sent every tick
        private void Tick() {
            _timeUpdateCounter++;

            if(_timeUpdateCounter == 20) {
                Age++;

                SP4ETimeUpdate timeUpdate = new(null, Age, Age % 24000);
                Server.MulticastAsync(timeUpdate);

                _timeUpdateCounter = 0;
            }
            
            // save world every hour (3 minecraft days)
            /*if(Age % (24000 * 3) == 1) {
                Task.Run(() => Format.Save());
            }*/
        }

        // TODO better way to do this?
        public int GetNextEntityId(BaseEntity entity) {
            return ++lastEntityId;
        }

        public BlockBase GetBlock(int x, int y, int z) {
            Chunk chunk = GetChunk((int) Math.Floor(x / (double) Chunk.X_SIZE), (int) Math.Floor(z / (double) Chunk.Z_SIZE));

            // of course C# has to be different and have a remainder operator instead of modulo
            int Mod(int x, int m) {
                return ((x % m) + m) % m;
            }

            return chunk.GetBlock(Mod(x, Chunk.X_SIZE), y, Mod(z, Chunk.Z_SIZE));
        }

        public void SetBlock(BlockBase block, int x, int y, int z) {
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
                if(session is MinecraftClient { GameState: MinecraftClient.State.Playing } client) {
                    if(client.LoadedChunks.Contains(chunk)) {
                        clients.Add(client);
                    }
                }
            }

            return clients;
        }

        public Chunk LoadChunk(int x, int z) {
            Chunk chunk = new(this, x, z);

            if(!Format.Load(chunk)) {
                chunk = new Chunk(this, x, z);
                Generator.GenerateChunk(this, chunk);
            }

            Chunks.Set(x.ToString() + z.ToString(), chunk);
            return chunk;
        }

        public string GetDirectory() {
            return Path.Combine(Nylium.WORLDS_DIRECTORY, Name);
        }
    }
}
