using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Jil;
using nylium.Core.Block;
using nylium.Core.Entity.Entities;
using nylium.Core.Entity.Inventories;
using nylium.Core.Networking.DataTypes;
using nylium.Extensions;
using nylium.Nbt.Tags;
using nylium.Utilities;
using Serilog;

namespace nylium.Core.Level.Storage.Formats {

    public class WaterWorldFormat : AbstractWorldFormat {

        private readonly string chunksDir;
        private readonly string playersDir;

        //                  X    Z    section; pos   size
        private Dictionary<(int, int, int),   (long, long)> ChunkLookup { get; set; }

        private FileStream LookupStream { get; set; }
        private BinaryReader ChunkReader { get; set; }
        private BinaryWriter ChunkWriter { get; set; }

        private BinaryFormatter Formatter { get; }

        public WaterWorldFormat(World world) : base(world) {
            chunksDir = Path.Combine(world.GetDirectory(), "chunks");
            playersDir = Path.Combine(world.GetDirectory(), "player-data");

            Directory.CreateDirectory(chunksDir);
            Directory.CreateDirectory(playersDir);

            LookupStream = new(Path.Combine(chunksDir, "lookup.bin"),
                FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            ChunkReader = new(new FileStream(Path.Combine(chunksDir, "chunks.bin"),
                FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite));
            ChunkWriter = new(new FileStream(Path.Combine(chunksDir, "chunks.bin"),
                FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite));

            ChunkLookup = new();
            Formatter = new();
        }

        public override bool Load() {
            Stopwatch sw = new();
            sw.Start();

            int bytesRead;
            byte[] buffer = new byte[32];

            while((bytesRead = LookupStream.Read(buffer, 0, buffer.Length)) > 0) {
                LookupStream.Position -= bytesRead;

                // varints and varlongs because why not
                int x = new VarInt(LookupStream).Value;
                int z = new VarInt(LookupStream).Value;
                int section = new VarInt(LookupStream).Value;
                long pos = new VarLong(LookupStream).Value;
                long size = new VarLong(LookupStream).Value;

                ChunkLookup.Add((x, z, section), (pos, size));
            }

            sw.Stop();
            Log.Information("Loaded world in " + Math.Round(sw.Elapsed.TotalMilliseconds, 2) + "ms");
            return true;
        }

        public override bool Save() {
            Stopwatch sw = new();
            sw.Start();

            World.Chunks.Iterate(chunk => Save(chunk));
            ChunkWriter.Flush();
            LookupStream.Flush();

            sw.Stop();
            Log.Information("Saved world in " + Math.Round(sw.Elapsed.TotalMilliseconds, 2) + "ms");
            return true;
        }

        public override bool Load(Chunk chunk) {
            int err = 0;

            for(int id = 0; id < Chunk.SECTION_COUNT; id++) {
                (int, int, int) key = (chunk.X, chunk.Z, id);

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
                                    section.SetBlock(BlockRepository.Create(BitConverter.ToUInt16(data, i * sizeof(ushort))),
                                        x, y, z);
                                }

                                i++;
                            }
                        }
                    }

                    chunk.Sections[id] = section;
                } else {
                    err++;
                }
            }

            return err < Chunk.SECTION_COUNT;
        }

        public override bool Save(Chunk chunk) {
            long pos = ChunkWriter.BaseStream.Position;

            for(int id = 0; id < 16; id++) {
                byte[] buffer = new byte[Chunk.Section.X_SIZE * Chunk.Section.Y_SIZE * Chunk.Section.Z_SIZE * sizeof(ushort)];
                int i = 0;

                Chunk.Section section = chunk.Sections[id];

                if(section == null) {
                    continue;
                }

                section.Iterate(block => {
                    if(block != null) {
                        byte[] b = block.State.WriteLittleEndian();

                        buffer[i] = b[0];
                        buffer[i + 1] = b[1];
                    } else {
                        buffer[i] = 0;
                        buffer[i + 1] = 0;
                    }

                    i += sizeof(ushort);
                });

                if(buffer.Any(b => b != 0)) {
                    if(ChunkLookup.ContainsKey((chunk.X, chunk.Z, id))) {
                        (long, long) info = ChunkLookup[(chunk.X, chunk.Z, id)];

                        ChunkWriter.BaseStream.Position = info.Item1;
                        ChunkWriter.Write(buffer);
                    } else {
                        ChunkLookup.Add((chunk.X, chunk.Z, id), (pos, buffer.Length));
                        ChunkWriter.Write(buffer);

                        new VarInt(chunk.X).Write(LookupStream);
                        new VarInt(chunk.Z).Write(LookupStream);
                        new VarInt(id).Write(LookupStream);
                        new VarLong(pos).Write(LookupStream);
                        new VarLong(buffer.Length).Write(LookupStream);
                    }
                }
            }

            return true;
        }

        public override bool Load(PlayerEntity player) {
            if(!File.Exists(Path.Combine(playersDir, player.Uuid + ".dat"))) return false;

            Stopwatch sw = new();
            sw.Start();

            dynamic json;

            using(MemoryStream output = RMSManager.Get().GetStream()) {
                using(FileStream input = new(Path.Combine(playersDir, player.Uuid.ToString() + ".dat"), FileMode.Open)) {
                    CompressionUtils.DeflateDecompress(input, output);
                }

                json = JSON.DeserializeDynamic(Encoding.UTF8.GetString(output.ToArray()));
            }

            player.Gamemode = (Gamemode) (int) json.gamemode;
            player.X = player.LastX = json.x;
            player.Y = player.LastY = json.y;
            player.Z = player.LastZ = json.z;
            player.Yaw = json.yaw;
            player.Pitch = json.pitch;
            player.OnGround = player.LastOnGround = json.onGround;
            player.Inventory.HeldSlot = json.heldSlot;

            foreach(dynamic entry in json.inventory) {
                Inventory.Slot slot;
                bool present = entry.Value.present;

                if(present) {
                    int item = entry.Value.item;
                    sbyte count = entry.Value.count;
                    TagCompound nbt = null;

                    if(entry.Value.ContainsKey("nbt")) {
                        byte[] buffer = Convert.FromBase64String(entry.Value.nbt);

                        nbt = new();
                        
                        using(MemoryStream stream = RMSManager.Get().GetStream(buffer)) {
                            nbt.Read(stream);
                        }
                    }

                    slot = new(present, item, count, nbt);
                } else {
                    slot = Inventory.Slot.Empty;
                }

                player.Inventory.Slots[Convert.ToInt32(entry.Key)] = slot;
            }

            sw.Stop();
            Log.Debug($"Loaded player with UUID {player.Uuid} in " + Math.Round(sw.Elapsed.TotalMilliseconds, 2) + "ms");
            return true;
        }

        public override bool Save(PlayerEntity player) {
            Stopwatch sw = new();
            sw.Start();

            dynamic json = new ExpandoObject();
            json.gamemode = (int) player.Gamemode;
            json.x = player.X;
            json.y = player.Y;
            json.z = player.Z;
            json.yaw = player.Yaw;
            json.pitch = player.Pitch;
            json.onGround = player.OnGround;
            json.heldSlot = player.Inventory.HeldSlot;

            IDictionary<string, object> inventory = new ExpandoObject();

            for(int i = 0; i < player.Inventory.Slots.Length; i++) {
                Inventory.Slot slot = player.Inventory.Slots[i];

                dynamic slotJson = new ExpandoObject();
                slotJson.present = slot.Present;

                if(slot.Present) {
                    slotJson.item = slot.Item.Id;
                    slotJson.count = slot.Count;

                    if(slot.NBT != null) {
                        using(MemoryStream stream = RMSManager.Get().GetStream()) {
                            slot.NBT.Write(stream);
                            slotJson.nbt = Convert.ToBase64String(stream.ToArray());
                        }
                    }
                }

                inventory[i.ToString()] = slotJson;
            }

            json.inventory = inventory;

            using(FileStream output = new(Path.Combine(playersDir, player.Uuid.ToString() + ".dat"), FileMode.OpenOrCreate)) {
                using(MemoryStream input = RMSManager.Get().GetStream(Encoding.UTF8.GetBytes(JSON.SerializeDynamic(json)))) {
                    CompressionUtils.DeflateCompress(input, output);
                }
            }

            sw.Stop();
            Log.Debug($"Saved player with UUID {player.Uuid} in " + Math.Round(sw.Elapsed.TotalMilliseconds, 2) + "ms");

            inventory.Clear();
            return true;
        }

        public override void Dispose() {
            LookupStream.Flush();
            LookupStream.Close();
            ChunkReader.Close();
            ChunkWriter.Flush();
            ChunkWriter.Close();
            GC.SuppressFinalize(this);
        }
    }
}