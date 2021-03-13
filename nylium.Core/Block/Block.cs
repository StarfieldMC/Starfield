using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text;
using Jil;
using nylium.Utilities;

namespace nylium.Core.Block {

    public class Block {

        private static readonly Dictionary<string, int> blocks = new();

        //                                  id   x    y    z
        private static readonly Dictionary<(int, int, int, int), Block> blockCache = new();

        public static int bitsPerBlock = 0;

        public World.World Parent { get; }
        public int Id { get; set; }

        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        private Block(World.World parent, int id, int x, int y, int z) {
            Parent = parent;
            Id = id;

            X = x;
            Y = y;
            Z = z;
        }

        public static int GetBlockProtocolId(string sid) {
            return blocks.ContainsKey(sid.Replace("minecraft:", "")) ? blocks[sid.Replace("minecraft:", "")] : -1;
        }

        public static Block Create(World.World parent, string sid, int x, int y, int z) {
            int id = GetBlockProtocolId(sid);

            (int, int, int, int) t = (id, x, y, z);

            if(blockCache.ContainsKey(t)) {
                return blockCache[t];
            }

            Block block = new(parent, id, x, y, z);
            blockCache.Add(t, block);

            return block;
        }

        public static void Initialize() {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            int maxStateId = 0;

            using(MemoryStream compressedStream = RMSManager.Get().GetStream(Properties.Resources.blockstates)) {
                using(GZipStream zipStream = new(compressedStream, CompressionMode.Decompress)) {
                    using(MemoryStream resultStream = RMSManager.Get().GetStream()) {
                        zipStream.CopyTo(resultStream);

                        dynamic json = JSON.DeserializeDynamic(Encoding.UTF8.GetString(resultStream.ToArray()));

                        foreach(dynamic block in json[0].blocks.block) {
                            string namedId = block.Value.text_id;
                            int id = block.Value.numeric_id;
                            
                            if(block.Value.max_state_id > maxStateId) {
                                maxStateId = block.Value.max_state_id;
                            }

                            blocks.Add(namedId, id);
                        }
                    }
                }
            }

            bitsPerBlock = (int) Math.Ceiling(Math.Log2(maxStateId));

            stopwatch.Stop();
            Console.WriteLine("Initialized blocks in " + Math.Round(stopwatch.Elapsed.TotalMilliseconds, 2) + "ms");
            stopwatch = null;
        }
    }
}
