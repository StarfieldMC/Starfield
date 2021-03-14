using System;
using System.Collections.Generic;
using System.IO;
using nylium.Utilities;

namespace nylium.Core.DataTypes {

    public class EntityMetadataEntry {

        public byte Index { get; }
        public DataType Type { get; }
        public dynamic Value { get; }

        public EntityMetadataEntry(byte index, DataType type, dynamic value) {
            Index = index;
            Type = type;
            Value = value;
        }

        public enum DataType : int {
            Unknown = -1,
            Byte,
            VarInt,
            Float,
            String,
            Chat,
            OptChat,
            Slot,
            Boolean,
            Rotation,
            Position,
            OptPosition,
            Direction,
            OptUUID,
            OptBlockID,
            NBT,
            Particle,
            VillagerData,
            OptVarInt,
            Pose
        }
    }

    public class EntityMetadata : DataType<List<EntityMetadataEntry>> {

        public EntityMetadata() : base(new List<EntityMetadataEntry> { new EntityMetadataEntry(0xff, EntityMetadataEntry.DataType.Unknown, null) }) { }
        public EntityMetadata(List<EntityMetadataEntry> value) : base(value) { }
        public EntityMetadata(Stream stream) : base(new List<EntityMetadataEntry> { new EntityMetadataEntry(0xff, EntityMetadataEntry.DataType.Unknown, null) }) { Read(stream); }

        public override int Read(Stream stream) {
            byte[] read = new byte[1];
            int bytesRead = stream.Read(read, 0, 1);

            while(read[0] != 0xff) {
                byte index = read[0];

                VarInt varInt = new();
                bytesRead += varInt.Read(stream);

                EntityMetadataEntry.DataType type = (EntityMetadataEntry.DataType) varInt.Value;
                dynamic value = null;

                switch(type) {
                    case EntityMetadataEntry.DataType.Byte: {
                            Byte @byte = new();
                            bytesRead += @byte.Read(stream);
                            value = @byte.Value;
                            break;
                        }
                    case EntityMetadataEntry.DataType.VarInt: {
                            bytesRead += varInt.Read(stream);
                            value = varInt.Value;
                            break;
                        }
                    case EntityMetadataEntry.DataType.Float: {
                            Float @float = new();
                            bytesRead += @float.Read(stream);
                            value = @float.Value;
                            break;
                        }
                    case EntityMetadataEntry.DataType.String: {
                            String @string = new();
                            bytesRead += @string.Read(stream);
                            value = @string.Value;
                            break;
                        }
                    case EntityMetadataEntry.DataType.Chat: {
                            Chat chat = new();
                            bytesRead += chat.Read(stream);
                            value = chat.Value;
                            break;
                        }
                    case EntityMetadataEntry.DataType.OptChat: {
                            Boolean boolean = new();
                            bytesRead += boolean.Read(stream);

                            if(boolean.Value) {
                                Chat chat = new();
                                bytesRead += chat.Read(stream);
                                value = chat.Value;
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.Slot: {
                            Slot slot = new();
                            bytesRead += slot.Read(stream);
                            value = slot.Value;
                            break;
                        }
                    case EntityMetadataEntry.DataType.Boolean: {
                            Boolean boolean = new();
                            bytesRead += boolean.Read(stream);
                            value = boolean.Value;
                            break;
                        }
                    case EntityMetadataEntry.DataType.Rotation: {
                            // TODO read rotation
                            break;
                        }
                    case EntityMetadataEntry.DataType.Position: {
                            Position pos = new();
                            bytesRead += pos.Read(stream);
                            value = pos.Value;
                            break;
                        }
                    case EntityMetadataEntry.DataType.OptPosition: {
                            Boolean boolean = new();
                            bytesRead += boolean.Read(stream);

                            if(boolean.Value) {
                                Position pos = new();
                                bytesRead += pos.Read(stream);
                                value = pos.Value;
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.Direction: {
                            bytesRead += varInt.Read(stream);
                            value = (Direction) varInt.Value;
                            break;
                        }
                    case EntityMetadataEntry.DataType.OptUUID: {
                            Boolean boolean = new();
                            bytesRead += boolean.Read(stream);

                            if(boolean.Value) {
                                UUID uuid = new();
                                bytesRead += uuid.Read(stream);
                                value = uuid.Value;
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.OptBlockID: {
                            bytesRead += varInt.Read(stream);

                            if(varInt.Value != 0) {
                                value = varInt.Value;
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.NBT: {
                            Boolean boolean = new();
                            bytesRead += boolean.Read(stream);

                            if(boolean.Value) {
                                NBT nbt = new();
                                bytesRead += nbt.Read(stream);
                                value = nbt.Value;
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.Particle: {
                            Boolean boolean = new();
                            bytesRead += boolean.Read(stream);

                            if(boolean.Value) {
                                // TODO read particle
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.VillagerData: {
                            // TODO read villagerdata
                            break;
                        }
                    case EntityMetadataEntry.DataType.OptVarInt: {
                            Boolean boolean = new();
                            bytesRead += boolean.Read(stream);

                            if(boolean.Value) {
                                bytesRead += varInt.Read(stream);
                                value = varInt.Value;
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.Pose: {
                            // TODO read pose
                            break;
                        }
                }

                if(value != null) Value.Add(new EntityMetadataEntry(index, type, value));

                bytesRead += stream.Read(read, 0, 1);
            }

            return bytesRead;
        }

        public override void Write(Stream stream) {
            UByte ubyte = new();
            VarInt varInt = new();

            for(int i = 0; i < Value.Count; i++) {
                EntityMetadataEntry entry = Value[i];

                ubyte.Value = entry.Index;
                ubyte.Write(stream);

                varInt.Value = (int) entry.Type;
                varInt.Write(stream);

                switch(entry.Type) {
                    case EntityMetadataEntry.DataType.Byte: {
                            Byte @byte = new(entry.Value);
                            @byte.Write(stream);
                            break;
                        }
                    case EntityMetadataEntry.DataType.VarInt: {
                            varInt.Value = entry.Value;
                            varInt.Write(stream);
                            break;
                        }
                    case EntityMetadataEntry.DataType.Float: {
                            Float @float = new(entry.Value);
                            @float.Write(stream);
                            break;
                        }
                    case EntityMetadataEntry.DataType.String: {
                            String @string = new(entry.Value);
                            @string.Write(stream);
                            break;
                        }
                    case EntityMetadataEntry.DataType.Chat: {
                            Chat chat = new(entry.Value);
                            chat.Write(stream);
                            break;
                        }
                    case EntityMetadataEntry.DataType.OptChat: {
                            Boolean boolean = new(entry.Value != null);
                            boolean.Write(stream);

                            if(boolean.Value) {
                                Chat chat = new(entry.Value);
                                chat.Write(stream);
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.Slot: {
                            Slot slot = new(entry.Value);
                            slot.Write(stream);
                            break;
                        }
                    case EntityMetadataEntry.DataType.Boolean: {
                            Boolean boolean = new(entry.Value);
                            boolean.Write(stream);
                            break;
                        }
                    case EntityMetadataEntry.DataType.Rotation: {
                            // TODO write rotation
                            break;
                        }
                    case EntityMetadataEntry.DataType.Position: {
                            Position pos = new(entry.Value);
                            pos.Write(stream);
                            break;
                        }
                    case EntityMetadataEntry.DataType.OptPosition: {
                            Boolean boolean = new(entry.Value != null);
                            boolean.Write(stream);

                            if(boolean.Value) {
                                Position pos = new(entry.Value);
                                pos.Write(stream);
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.Direction: {
                            varInt.Value = entry.Value;
                            varInt.Write(stream);
                            break;
                        }
                    case EntityMetadataEntry.DataType.OptUUID: {
                            Boolean boolean = new(entry.Value != null);
                            boolean.Write(stream);

                            if(boolean.Value) {
                                UUID uuid = new(entry.Value);
                                uuid.Write(stream);
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.OptBlockID: {
                            varInt.Value = entry.Value == null ? 0 : entry.Value;
                            varInt.Write(stream);
                            break;
                        }
                    case EntityMetadataEntry.DataType.NBT: {
                            Boolean boolean = new(entry.Value != null);
                            boolean.Write(stream);

                            if(boolean.Value) {
                                NBT nbt = new(entry.Value);
                                nbt.Write(stream);
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.Particle: {
                            Boolean boolean = new(entry.Value != null);
                            boolean.Write(stream);

                            if(boolean.Value) {
                                // TODO write particle
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.VillagerData: {
                            // TODO write villagerdata
                            break;
                        }
                    case EntityMetadataEntry.DataType.OptVarInt: {
                            Boolean boolean = new(entry.Value != null);
                            boolean.Write(stream);

                            if(boolean.Value) {
                                varInt.Value = entry.Value;
                                varInt.Write(stream);
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.Pose: {
                            // TODO write pose
                            break;
                        }
                }
            }

            stream.WriteByte(0xff);
        }
    }
}
