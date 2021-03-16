using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text;
using Jil;
using nylium.Core.World;
using nylium.Utilities;

namespace nylium.Core.Block {

    public class GameBlock {

        //                                 id      state id range; protocol id
        private static readonly Dictionary<string, (int, int,      int)> blocks = new();

        //                                             state id
        private static readonly Dictionary<(GameWorld, int),    GameBlock> blockCache = new();

        public static int bitsPerBlock = 0;

        public GameWorld Parent { get; }
        public int StateId { get; set; }

        private GameBlock(GameWorld parent, int stateId) {
            Parent = parent;
            StateId = stateId;
        }

        public static (int, int) GetBlockStateIdRange(string namedId) {
            return blocks.ContainsKey(namedId.Replace("minecraft:", "")) ?
                (blocks[namedId.Replace("minecraft:", "")].Item1, blocks[namedId.Replace("minecraft:", "")].Item2) : (-1, -1);
        }

        public static string GetBlockNamedId(int stateId) {
            foreach(KeyValuePair<string, (int, int, int)> entry in blocks) {
                if(entry.Value.Item1 <= stateId && entry.Value.Item2 >= stateId) {
                    return entry.Key;
                }
            }

            return null;
        }

        public static int GetBlockProtocolId(string namedId) {
            return blocks.ContainsKey(namedId.Replace("minecraft:", "")) ?
                blocks[namedId.Replace("minecraft:", "")].Item3 : -1;
        }

        public static GameBlock Create(GameWorld parent, string namedId) {
            int stateId = GetBlockStateIdRange(namedId).Item1;

            (GameWorld, int) key = (parent, stateId);

            if(blockCache.ContainsKey(key)) {
                return blockCache[key];
            }

            GameBlock block = new(parent, stateId);
            blockCache.Add(key, block);

            return block;
        }

        public static GameBlock Create(GameWorld parent, int stateId) {
            (GameWorld, int) key = (parent, stateId);

            if(blockCache.ContainsKey(key)) {
                return blockCache[key];
            }

            GameBlock block = new(parent, stateId);
            blockCache.Add(key, block);

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
                            int minState = block.Value.min_state_id;
                            int maxState = block.Value.max_state_id;
                            
                            if(maxState > maxStateId) {
                                maxStateId = maxState;
                            }

                            blocks.Add(namedId, (minState, maxState, id));
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
