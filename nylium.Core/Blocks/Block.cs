using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text;
using Jil;
using nylium.Core.Level;
using nylium.Utilities;
using Serilog;

namespace nylium.Core.Blocks {

    public class Block {

        //                                 id      state id range     protocol id
        private static readonly Dictionary<string, (ushort, ushort,      int)> blocks = new();

        //                                             state id
        private static readonly Dictionary<(World, ushort),    Block> blockCache = new();

        public static int bitsPerBlock = 0;

        public World Parent { get; }
        public ushort StateId { get; set; }

        private Block(World parent, ushort stateId) {
            Parent = parent;
            StateId = stateId;
        }

        public static (ushort, ushort) GetBlockStateIdRange(string namedId) {
            return blocks.ContainsKey(namedId.Replace("minecraft:", "")) ?
                (blocks[namedId.Replace("minecraft:", "")].Item1, blocks[namedId.Replace("minecraft:", "")].Item2) : ((ushort) 0, (ushort) 0);
        }

        public static string GetBlockNamedId(ushort stateId) {
            foreach(KeyValuePair<string, (ushort, ushort, int)> entry in blocks) {
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

        public static Block Create(World parent, string namedId) {
            ushort stateId = GetBlockStateIdRange(namedId).Item1;

            (World, ushort) key = (parent, stateId);

            if(blockCache.ContainsKey(key)) {
                return blockCache[key];
            }

            Block block = new(parent, stateId);
            blockCache.Add(key, block);

            return block;
        }

        public static Block Create(World parent, ushort stateId) {
            (World, ushort) key = (parent, stateId);

            if(blockCache.ContainsKey(key)) {
                return blockCache[key];
            }

            Block block = new(parent, stateId);
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

                            blocks.Add(namedId, ((ushort) minState, (ushort) maxState, id));
                        }
                    }
                }
            }

            bitsPerBlock = (int) Math.Ceiling(Math.Log2(maxStateId));

            stopwatch.Stop();
            Log.Debug("Initialized blocks in " + Math.Round(stopwatch.Elapsed.TotalMilliseconds, 2) + "ms");
        }

        public enum Face : sbyte {

            Bottom,
            Top,
            North,
            South,
            West,
            East
        }
    }
}
