using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text;
using Jil;
using Starfield.Logging;
using Starfield.Utilities;
using Starfield.Core.Block;
using Starfield.Core.Item;

namespace Starfield.Core.Tags {

    public class Tag {

        public static readonly List<Tag> blockTags = new();
        public static readonly List<Tag> itemTags = new();
        public static readonly List<Tag> fluidTags = new();
        public static readonly List<Tag> entityTags = new();

        public Identifier Name { get; }
        public int[] Entries { get; }

        public Tag(Identifier name, int[] entries) {
            Name = name;
            Entries = entries;
        }

        public static void Initialize() {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            using(MemoryStream compressedStream = RMSManager.Get().GetStream(Properties.Resources.tags)) {
                using(GZipStream zipStream = new(compressedStream, CompressionMode.Decompress)) {
                    using(MemoryStream resultStream = RMSManager.Get().GetStream()) {
                        zipStream.CopyTo(resultStream);

                        dynamic json = JSON.DeserializeDynamic(Encoding.UTF8.GetString(resultStream.ToArray()));

                        foreach(dynamic tag in json[0].tags) {
                            string type = tag.Value.type;
                            string name = tag.Value.name;

                            switch(type) {
                                case "blocks":
                                    int[] ids = new int[tag.Value.values.Length];

                                    for(int i = 0; i < tag.Value.values.Length; i++) {
                                        int id = BlockRepository.Create(new Identifier((string) tag.Value.values[i]))
                                            .ProtocolId;

                                        if(id != -1) {
                                            ids[i] = id;
                                        }
                                    }

                                    blockTags.Add(new Tag(new Identifier(name), ids));
                                    break;
                                case "items":
                                    ids = new int[tag.Value.values.Length];

                                    for(int i = 0; i < tag.Value.values.Length; i++) {
                                        int id = ItemRepository.Create(new Identifier((string) tag.Value.values[i]))
                                            .ProtocolId;

                                        if(id != -1) {
                                            ids[i] = id;
                                        }
                                    }

                                    itemTags.Add(new Tag(new Identifier(name), ids));
                                    break;
                                case "fluids":
                                    ids = new int[tag.Value.values.Length];

                                    for(int i = 0; i < tag.Value.values.Length; i++) {
                                        int id = 0;
                                        string namedId = tag.Value.values[i];

                                        // dumped from the vanilla server
                                        if(namedId == "minecraft:flowing_water") {
                                            id = 1;
                                        } else if(namedId == "minecraft:flowing_lava") {
                                            id = 3;
                                        } else if(namedId == "minecraft:water") {
                                            id = 2;
                                        } else if(namedId == "minecraft:lava") {
                                            id = 4;
                                        }

                                        ids[i] = id;
                                    }

                                    fluidTags.Add(new Tag(new Identifier(name), ids));
                                    break;
                                case "entity_types":
                                    ids = new int[tag.Value.values.Length];

                                    for(int i = 0; i < tag.Value.values.Length; i++) {
                                        int id = Entity.BaseEntity.GetEntityProtocolId((string) tag.Value.values[i]);

                                        if(id != -1) {
                                            ids[i] = id;
                                        }
                                    }

                                    entityTags.Add(new Tag(new Identifier(name), ids));
                                    break;
                            }
                        }
                    }
                }
            }

            stopwatch.Stop();
            Logger.Debug("Initialized tags in " + Math.Round(stopwatch.Elapsed.TotalMilliseconds, 2) + "ms");
        }
    }
}