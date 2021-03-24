using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text;
using Jil;
using nylium.Utilities;
using Serilog;

namespace nylium.Core.Entity {

    public class GameEntity {

        private static readonly Dictionary<string, int> entities = new();

        public World.GameWorld Parent { get; }

        public string Id { get; }
        public int EntityId { get; }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public double LastX { get; set; }
        public double LastY { get; set; }
        public double LastZ { get; set; }

        public float Yaw { get; set; }
        public float Pitch { get; set; }

        public bool OnGround { get; set; }
        public bool LastOnGround { get; set; }

        public GameEntity(World.GameWorld parent, string id, double x, double y, double z, float yaw, float pitch, bool onGround) {
            Parent = parent;
            Id = id;
            EntityId = parent.GetNextEntityId(this);

            X = LastX = x;
            Y = LastY = y;
            Z = LastZ = z;

            Yaw = yaw;
            Pitch = pitch;

            OnGround = LastOnGround = onGround;
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
            Log.Debug("Initialized entities in " + Math.Round(stopwatch.Elapsed.TotalMilliseconds, 2) + "ms");
        }
    }
}
