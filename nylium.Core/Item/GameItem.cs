using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text;
using Jil;
using nylium.Utilities;
using Serilog;

namespace nylium.Core.Item {

    public class GameItem {

        private static readonly Dictionary<string, int> items = new();

        public Entity.GameEntity Parent { get; }
        public int Id { get; }

        public GameItem(Entity.GameEntity parent, int id) {
            Parent = parent;
            Id = id;
        }

        public static int GetItemProtocolId(string sid) {
            return items.ContainsKey(sid.Replace("minecraft:", "")) ? items[sid.Replace("minecraft:", "")] : -1;
        }

        public static void Initialize() {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            using(MemoryStream compressedStream = RMSManager.Get().GetStream(Properties.Resources.items)) {
                using(GZipStream zipStream = new(compressedStream, CompressionMode.Decompress)) {
                    using(MemoryStream resultStream = RMSManager.Get().GetStream()) {
                        zipStream.CopyTo(resultStream);

                        dynamic json = JSON.DeserializeDynamic(Encoding.UTF8.GetString(resultStream.ToArray()));

                        foreach(dynamic item in json[0].items.item) {
                            string namedId = item.Value.text_id;
                            int id = item.Value.numeric_id;

                            items.Add(namedId, id);
                        }
                    }
                }
            }

            stopwatch.Stop();
            Log.Debug("Initialized items in " + Math.Round(stopwatch.Elapsed.TotalMilliseconds, 2) + "ms");
            stopwatch = null;
        }
    }
}