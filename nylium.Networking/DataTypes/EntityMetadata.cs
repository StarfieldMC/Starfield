using System.Collections.Generic;
using System.IO;
using nylium.Utilities;

namespace nylium.Networking.DataTypes {

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

        public override void Read(Stream stream, out int bytesRead) {
            bytesRead = 0;
            byte[] read = new byte[1];

            bytesRead += stream.Read(read, 0, 1);

            while(read[0] != 0xff) {
                byte index = read[0];

                VarInt varInt = new VarInt();
                varInt.Read(stream, out _);

                EntityMetadataEntry.DataType type = (EntityMetadataEntry.DataType) varInt.Value;
                dynamic value = null;

                int _bytesRead = 0;

                switch(type) {
                    case EntityMetadataEntry.DataType.Byte: {
                            Byte @byte = new Byte();
                            @byte.Read(stream, out _bytesRead);
                            value = @byte.Value;
                            break;
                        }
                    case EntityMetadataEntry.DataType.VarInt: {
                            varInt.Read(stream, out _bytesRead);
                            value = varInt.Value;
                            break;
                        }
                    case EntityMetadataEntry.DataType.Float: {
                            Float @float = new Float();
                            @float.Read(stream, out _bytesRead);
                            value = @float.Value;
                            break;
                        }
                    case EntityMetadataEntry.DataType.String: {
                            String @string = new String();
                            @string.Read(stream, out _bytesRead);
                            value = @string.Value;
                            break;
                        }
                    case EntityMetadataEntry.DataType.Chat: {
                            Chat chat = new Chat();
                            chat.Read(stream, out _bytesRead);
                            value = chat.Value;
                            break;
                        }
                    case EntityMetadataEntry.DataType.OptChat: {
                            Boolean boolean = new Boolean();
                            boolean.Read(stream, out _bytesRead);

                            if(boolean.Value) {
                                bytesRead += _bytesRead;

                                Chat chat = new Chat();
                                chat.Read(stream, out _bytesRead);
                                value = chat.Value;
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.Slot: {
                            // TODO read slot
                            break;
                        }
                    case EntityMetadataEntry.DataType.Boolean: {
                            Boolean boolean = new Boolean();
                            boolean.Read(stream, out _bytesRead);
                            value = boolean.Value;
                            break;
                        }
                    case EntityMetadataEntry.DataType.Rotation: {
                            // TODO read rotation
                            break;
                        }
                    case EntityMetadataEntry.DataType.Position: {
                            // TODO read position
                            break;
                        }
                    case EntityMetadataEntry.DataType.OptPosition: {
                            Boolean boolean = new Boolean();
                            boolean.Read(stream, out _bytesRead);

                            if(boolean.Value) {
                                bytesRead += _bytesRead;

                                // TODO read position
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.Direction: {
                            varInt.Read(stream, out _bytesRead);
                            value = (Direction) varInt.Value;
                            break;
                        }
                    case EntityMetadataEntry.DataType.OptUUID: {
                            Boolean boolean = new Boolean();
                            boolean.Read(stream, out _bytesRead);

                            if(boolean.Value) {
                                bytesRead += _bytesRead;

                                UUID uuid = new UUID();
                                uuid.Read(stream, out _bytesRead);
                                value = uuid.Value;
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.OptBlockID: {
                            Boolean boolean = new Boolean();
                            boolean.Read(stream, out _bytesRead);

                            if(boolean.Value) {
                                bytesRead += _bytesRead;

                                // TODO read blockid
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.NBT: {
                            Boolean boolean = new Boolean();
                            boolean.Read(stream, out _bytesRead);

                            if(boolean.Value) {
                                bytesRead += _bytesRead;

                                NBT nbt = new NBT();
                                nbt.Read(stream, out _bytesRead);
                                value = nbt.Value;
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.Particle: {
                            Boolean boolean = new Boolean();
                            boolean.Read(stream, out _bytesRead);

                            if(boolean.Value) {
                                bytesRead += _bytesRead;

                                // TODO read particle
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.VillagerData: {
                            // TODO read villagerdata
                            break;
                        }
                    case EntityMetadataEntry.DataType.OptVarInt: {
                            Boolean boolean = new Boolean();
                            boolean.Read(stream, out _bytesRead);

                            if(boolean.Value) {
                                bytesRead += _bytesRead;

                                varInt.Read(stream, out _bytesRead);
                                value = varInt.Value;
                            }
                            break;
                        }
                    case EntityMetadataEntry.DataType.Pose: {
                            // TODO read pose
                            break;
                        }
                }

                Value.Add(new EntityMetadataEntry(index, type, value));

                bytesRead += _bytesRead;
                bytesRead += stream.Read(read, 0, 1);
            }
        }

        public override void Write(Stream stream) {

        }
    }
}
