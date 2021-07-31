using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Ionic.Zlib;
using Jil;
using nylium.Utilities;

namespace nylium.Core.Block {

    public abstract class BlockBase {
        
        // TODO we don't want this
        private static readonly Dictionary<string, (ushort, ushort, int)> blocks = new();

        public abstract string Id { get; }

        public abstract ushort MinimumState { get; }
        public abstract ushort MaximumState { get; }
        public abstract ushort DefaultState { get; }

        public abstract ushort State { get; set; }
        
        // TODO we don't want this
        static BlockBase() {
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

                            blocks.Add(namedId, ((ushort) minState, (ushort) maxState, id));
                        }
                    }
                }
            }
        }
        
        // TODO we don't want this
        public static int GetBlockProtocolId(string namedId) {
            return blocks.ContainsKey(namedId.Replace("minecraft:", "")) ?
                blocks[namedId.Replace("minecraft:", "")].Item3 : -1;
        }
    }
}