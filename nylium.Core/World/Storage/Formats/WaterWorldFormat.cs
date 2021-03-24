using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using nylium.Core.Block;
using nylium.Extensions;
using nylium.Utilities;
using Serilog;

namespace nylium.Core.World.Storage.Formats {

    public class WaterWorldFormat : AbstractWorldFormat {

        //                  X    Z    section; pos   size
        private Dictionary<(int, int, int),   (long, long)> ChunkLookup { get; set; }

        private FileStream LookupStream { get; }
        private BinaryReader ChunkReader { get; }
        private BinaryWriter ChunkWriter { get; }

        private BinaryFormatter Formatter { get; }

        public WaterWorldFormat(GameWorld world) : base(world) {
            ChunkLookup = new();

            LookupStream = new(Path.Combine(world.GetDirectory(), "lookup.bin"),
                FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            ChunkReader = new(new FileStream(Path.Combine(world.GetDirectory(), "chunks.bin"),
                FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite));
            ChunkWriter = new(new FileStream(Path.Combine(world.GetDirectory(), "chunks.bin"),
                FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite));

            Formatter = new();
        }

        public override void Load() {
            Stopwatch sw = new();
            sw.Start();

            ChunkLookup = (Dictionary<(int, int, int), (long, long)>) Formatter.Deserialize(LookupStream);
            LookupStream.Position = 0;

            List<(int, int)> loaded = new();

            foreach(KeyValuePair<(int, int, int), (long, long)> entry in ChunkLookup) {
                if(!loaded.Contains((entry.Key.Item1, entry.Key.Item2))) {
                    World.Chunks.Add((entry.Key.Item1, entry.Key.Item2), Load(entry.Key.Item1, entry.Key.Item2));
                }
            }

            sw.Stop();
            Log.Information("Loaded world in " + Math.Round(sw.Elapsed.TotalMilliseconds, 2) + "ms");
        }

        public override void Save() {
            Stopwatch sw = new();
            sw.Start();

            foreach(KeyValuePair<(int, int), Chunk> entry in World.Chunks) {
                Save(entry.Value);
            }

            ChunkWriter.Flush();

            Formatter.Serialize(LookupStream, ChunkLookup);
            LookupStream.Flush();
            LookupStream.Position = 0;

            sw.Stop();
            Log.Information("Saved world in " + Math.Round(sw.Elapsed.TotalMilliseconds, 2) + "ms");
        }

        public override Chunk Load(int chunkX, int chunkZ) {
            Chunk chunk = new(World, chunkX, chunkZ);

            int errorCount = 0;

            for(int id = 0; id < Chunk.SECTION_COUNT; id++) {
                (int, int, int) key = (chunkX, chunkZ, id);

                if(ChunkLookup.ContainsKey(key)) {
                    (long, long) info = ChunkLookup[key];

                    ChunkReader.BaseStream.Position = info.Item1;
                    byte[] data = ChunkReader.ReadBytes((int) info.Item2);

                    Chunk.Section section = new(id, chunk);

                    int i = 0;

                    for(int y = 0; y < Chunk.Section.Y_SIZE; y++) {
                        for(int x = 0; x < Chunk.Section.X_SIZE; x++) {
                            for(int z = 0; z < Chunk.Section.Z_SIZE; z++) {
                                ushort blockId = BitConverter.ToUInt16(data, i * sizeof(ushort));
                                
                                if(blockId != 0) {
                                    section.SetBlock(GameBlock.Create(World, BitConverter.ToUInt16(data, i * sizeof(ushort))), x, y, z);
                                }

                                i++;
                            }
                        }
                    }

                    chunk.SetSection(section, id);
                } else {
                    errorCount++;
                }
            }

            return errorCount >= Chunk.SECTION_COUNT ? null : chunk;
        }

        public override void Save(Chunk chunk) {
            long pos = ChunkWriter.BaseStream.Position;

            for(int id = 0; id < 16; id++) {
                byte[] buffer = new byte[Chunk.Section.X_SIZE * Chunk.Section.Y_SIZE * Chunk.Section.Z_SIZE * sizeof(ushort)];
                int i = 0;

                Chunk.Section section = chunk.GetSection(id);

                if(section == null) {
                    continue;
                }

                section.Iterate(block => {
                    if(block != null) {
                        byte[] b = block.StateId.WriteLittleEndian();

                        buffer[i] = b[0];
                        buffer[i + 1] = b[1];
                    } else {
                        buffer[i] = 0;
                        buffer[i + 1] = 0;
                    }

                    i += sizeof(ushort);
                });

                if(!buffer.All(b => b == 0)) {
                    if(ChunkLookup.ContainsKey((chunk.X, chunk.Z, id))) {
                        (long, long) info = ChunkLookup[(chunk.X, chunk.Z, id)];

                        ChunkWriter.BaseStream.Position = info.Item1;
                        ChunkWriter.Write(buffer);
                    } else {
                        ChunkLookup.Add((chunk.X, chunk.Z, id), (pos, buffer.Length));
                        ChunkWriter.Write(buffer);
                    }
                }
            }
        }

        public override void Dispose() {
            LookupStream.Close();
            ChunkReader.Close();
            ChunkWriter.Flush();
            ChunkWriter.Close();
            GC.SuppressFinalize(this);
        }
    }
}