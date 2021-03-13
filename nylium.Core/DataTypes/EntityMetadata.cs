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
            // TODO
            throw new NotImplementedException();
        }
    }
}
