using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text;
using Jil;
using nylium.Utilities;

namespace nylium.Core.Entity {

    public class Entity {

        private static readonly Dictionary<string, int> entities = new();

        public World.World Parent { get; }

        public string Id { get; }
        public int EntityId { get; }

        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public int Yaw { get; }
        public int Pitch { get; }

        public Entity(World.World parent, string id, double x, double y, double z, int yaw, int pitch) {
            Parent = parent;
            Id = id;
            EntityId = parent.GetNextEntityId(this);

            X = x;
            Y = y;
            Z = z;

            Yaw = yaw;
            Pitch = pitch;
        }

        public static int GetEntityProtocolId(string sid) {
            return entities.ContainsKey(sid.Replace("minecraft:", "")) ? entities[sid.Replace("minecraft:", "")] : -1;
        }

        public static void Initialize() {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            using(MemoryStream compressedStream = RMSManager.Get().GetStream(Properties.Resources.entities)) {
                using(GZipStream zipStream = new(compressedStream, CompressionMode.Decompress)) {
                    using(MemoryStream resultStream = RMSManager.Get().GetStream()) {
                        zipStream.CopyTo(resultStream);

                        dynamic json = JSON.DeserializeDynamic(Encoding.UTF8.GetString(resultStream.ToArray()));

                        foreach(dynamic entity in json[0].entities.entity) {
                            string namedId = entity.Value.name;

                            if(namedId.StartsWith("~abstract")) continue;

                            int id = entity.Value.id;

                            entities.Add(namedId, id);
                        }
                    }
                }
            }

            stopwatch.Stop();
            Console.WriteLine("Initialized entities in " + Math.Round(stopwatch.Elapsed.TotalMilliseconds, 2) + "ms");
            stopwatch = null;
        }
    }
}
