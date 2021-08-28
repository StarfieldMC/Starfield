using System.Collections.Generic;
using System.IO;
using nylium.Utilities;

namespace nylium.Core.Networking.DataTypes {

    public class EntityMetadata : DataType<List<EntityMetadata.Entry>> {

        public EntityMetadata() : base(new List<Entry> { new(0xff, Entry.DataType.Unknown, null) }) { }
        public EntityMetadata(List<Entry> value) : base(value) { }
        public EntityMetadata(Stream stream) : base(new List<Entry> { new(0xff, Entry.DataType.Unknown, null) }) { Read(stream); }

        public override void Read(Stream stream) {
            byte[] read = new byte[1];
            stream.Read(read, 0, 1);

            while(read[0] != 0xff) {
                byte index = read[0];

                VarInt varInt = new(stream);

                Entry.DataType type = (Entry.DataType) varInt.Value;
                dynamic value = null;

                switch(type) {
                    case Entry.DataType.Byte: {
                            Byte @byte = new(stream);
                            value = @byte.Value;
                            break;
                        }
                    case Entry.DataType.VarInt: {
                            varInt.Read(stream);
                            value = varInt.Value;
                            break;
                        }
                    case Entry.DataType.Float: {
                            Float @float = new(stream);
                            value = @float.Value;
                            break;
                        }
                    case Entry.DataType.String: {
                            String @string = new(stream);
                            value = @string.Value;
                            break;
                        }
                    case Entry.DataType.Chat: {
                            Chat chat = new(stream);
                            value = chat.Value;
                            break;
                        }
                    case Entry.DataType.OptChat: {
                            Boolean boolean = new(stream);

                            if(boolean.Value) {
                                Chat chat = new(stream);
                                value = chat.Value;
                            }
                            break;
                        }
                    case Entry.DataType.Slot: {
                            Slot slot = new(stream);
                            value = slot.Value;
                            break;
                        }
                    case Entry.DataType.Boolean: {
                            Boolean boolean = new(stream);
                            value = boolean.Value;
                            break;
                        }
                    case Entry.DataType.Rotation: {
                            // TODO read rotation
                            break;
                        }
                    case Entry.DataType.Position: {
                            Position pos = new(stream);
                            value = pos.Value;
                            break;
                        }
                    case Entry.DataType.OptPosition: {
                            Boolean boolean = new(stream);

                            if(boolean.Value) {
                                Position pos = new(stream);
                                value = pos.Value;
                            }
                            break;
                        }
                    case Entry.DataType.Direction: {
                            varInt.Read(stream);
                            value = (Direction) varInt.Value;
                            break;
                        }
                    case Entry.DataType.OptUUID: {
                            Boolean boolean = new(stream);

                            if(boolean.Value) {
                                UUID uuid = new(stream);
                                value = uuid.Value;
                            }
                            break;
                        }
                    case Entry.DataType.OptBlockID: {
                            varInt.Read(stream);

                            if(varInt.Value != 0) {
                                value = varInt.Value;
                            }
                            break;
                        }
                    case Entry.DataType.NBT: {
                            Boolean boolean = new(stream);

                            if(boolean.Value) {
                                NBT nbt = new(stream);
                                value = nbt.Value;
                            }
                            break;
                        }
                    case Entry.DataType.Particle: {
                            Boolean boolean = new(stream);

                            if(boolean.Value) {
                                // TODO read particle
                            }
                            break;
                        }
                    case Entry.DataType.VillagerData: {
                            // TODO read villagerdata
                            break;
                        }
                    case Entry.DataType.OptVarInt: {
                            Boolean boolean = new(stream);

                            if(boolean.Value) {
                                varInt.Read(stream);
                                value = varInt.Value;
                            }
                            break;
                        }
                    case Entry.DataType.Pose: {
                            // TODO read pose
                            break;
                        }
                }

                if(value != null) Value.Add(new Entry(index, type, value));
                stream.Read(read, 0, 1);
            }
        }

        public override void Write(Stream stream) {
            UByte ubyte = new();
            VarInt varInt = new();

            for(int i = 0; i < Value.Count; i++) {
                Entry entry = Value[i];

                ubyte.Value = entry.Index;
                ubyte.Write(stream);

                varInt.Value = (int) entry.Type;
                varInt.Write(stream);

                switch(entry.Type) {
                    case Entry.DataType.Byte: {
                            new Byte(entry.Value).Write(stream);
                            break;
                        }
                    case Entry.DataType.VarInt: {
                            new VarInt(entry.Value).Write(stream);
                            break;
                        }
                    case Entry.DataType.Float: {
                            new Float(entry.Value).Write(stream);
                            break;
                        }
                    case Entry.DataType.String: {
                            new String(entry.Value).Write(stream);
                            break;
                        }
                    case Entry.DataType.Chat: {
                            new Chat(entry.Value).Write(stream);
                            break;
                        }
                    case Entry.DataType.OptChat: {
                            Boolean boolean = new(entry.Value != null);
                            boolean.Write(stream);

                            if(boolean.Value) {
                                Chat chat = new(entry.Value);
                                chat.Write(stream);
                            }
                            break;
                        }
                    case Entry.DataType.Slot: {
                            new Slot(entry.Value).Write(stream);
                            break;
                        }
                    case Entry.DataType.Boolean: {
                            new Boolean(entry.Value).Write(stream);
                            break;
                        }
                    case Entry.DataType.Rotation: {
                            // TODO write rotation
                            break;
                        }
                    case Entry.DataType.Position: {
                            new Position(entry.Value).Write(stream);
                            break;
                        }
                    case Entry.DataType.OptPosition: {
                            Boolean boolean = new(entry.Value != null);
                            boolean.Write(stream);

                            if(boolean.Value) {
                                new Position(entry.Value).Write(stream);
                            }
                            break;
                        }
                    case Entry.DataType.Direction: {
                            new VarInt(entry.Value).Write(stream);
                            break;
                        }
                    case Entry.DataType.OptUUID: {
                            Boolean boolean = new(entry.Value != null);
                            boolean.Write(stream);

                            if(boolean.Value) {
                                new UUID(entry.Value).Write(stream);
                            }
                            break;
                        }
                    case Entry.DataType.OptBlockID: {
                            new VarInt(entry.Value ?? 0).Write(stream);
                            break;
                        }
                    case Entry.DataType.NBT: {
                            Boolean boolean = new(entry.Value != null);
                            boolean.Write(stream);

                            if(boolean.Value) {
                                new NBT(entry.Value).Write(stream);
                            }
                            break;
                        }
                    case Entry.DataType.Particle: {
                            Boolean boolean = new(entry.Value != null);
                            boolean.Write(stream);

                            if(boolean.Value) {
                                // TODO write particle
                            }
                            break;
                        }
                    case Entry.DataType.VillagerData: {
                            // TODO write villagerdata
                            break;
                        }
                    case Entry.DataType.OptVarInt: {
                            Boolean boolean = new(entry.Value != null);
                            boolean.Write(stream);

                            if(boolean.Value) {
                                new VarInt(entry.Value).Write(stream);
                            }
                            break;
                        }
                    case Entry.DataType.Pose: {
                            // TODO write pose
                            break;
                        }
                }
            }

            stream.WriteByte(0xff);
        }

        public class Entry {

            public byte Index { get; }
            public DataType Type { get; }
            public dynamic Value { get; }

            public Entry(byte index, DataType type, dynamic value) {
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
    }
}
