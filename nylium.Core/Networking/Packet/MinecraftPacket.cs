using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using fNbt;
using nylium.Core.Entity.Inventories;
using nylium.Core.Networking.DataTypes;
using nylium.Utilities;
using Serilog;

// TODO compressed packets
namespace nylium.Core.Networking.Packet {

    public class MinecraftPacket : IDisposable {

        private static readonly Func<Stream, MinecraftPacket>[][] clientPacketConstructors = new Func<Stream, MinecraftPacket>[][] {
            new Func<Stream, MinecraftPacket>[0xff], // Handshaking packets
            new Func<Stream, MinecraftPacket>[0xff], // Status packets
            new Func<Stream, MinecraftPacket>[0xff], // Login packets
            new Func<Stream, MinecraftPacket>[0xff] // Play packets
        };

        public int Length { get; set; }
        public int Id { get; set; }
        public MemoryStream Data { get; set; }

        public bool CompressionEnabled { get; set; }

        public static void Initialize() {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            Type[] packetTypes = Assembly.GetExecutingAssembly().GetTypes()
                      .Where(t => string.Equals(t.Namespace, "nylium.Core.Networking.Packet.Client.Handshake")
                        || string.Equals(t.Namespace, "nylium.Core.Networking.Packet.Client.Status")
                        || string.Equals(t.Namespace, "nylium.Core.Networking.Packet.Client.Login")
                        || string.Equals(t.Namespace, "nylium.Core.Networking.Packet.Client.Play"))
                      .ToArray();

            Type[] ctorParams = new Type[] { typeof(Stream) };

            for(int i = 0; i < packetTypes.Length; i++) {
                Type t = packetTypes[i];

                ConstructorInfo constructor = t.GetConstructor(ctorParams);

                if(constructor == null) {
                    Log.Debug(string.Format("Type [{0}] is probably not a packet, ignoring", t.FullName));
                    continue;
                }

                ParameterExpression parameter = Expression.Parameter(typeof(Stream));
                Func<Stream, MinecraftPacket> ctor = Expression.Lambda<Func<Stream, MinecraftPacket>>(Expression.New(constructor, parameter), parameter).Compile();

                string state = t.Namespace.Substring(t.Namespace.LastIndexOf('.') + 1);

                switch(state) {
                    case "Handshake":
                        clientPacketConstructors[0][t.GetCustomAttribute<PacketAttribute>(false).Id] = ctor;
                        break;
                    case "Status":
                        clientPacketConstructors[1][t.GetCustomAttribute<PacketAttribute>(false).Id] = ctor;
                        break;
                    case "Login":
                        clientPacketConstructors[2][t.GetCustomAttribute<PacketAttribute>(false).Id] = ctor;
                        break;
                    case "Play":
                        clientPacketConstructors[3][t.GetCustomAttribute<PacketAttribute>(false).Id] = ctor;
                        break;
                }
            }

            stopwatch.Stop();
            Log.Debug("Initialized packets in " + Math.Round(stopwatch.Elapsed.TotalMilliseconds, 2) + "ms");
        }

        public MinecraftPacket() {
            PacketAttribute attribute = GetType().GetCustomAttribute<PacketAttribute>(false);

            Id = attribute.Id;
            Data = RMSManager.Get().GetStream(GetType().FullName);
        }

        public MinecraftPacket(Stream stream) {
            Data = RMSManager.Get().GetStream(GetType().FullName);
            CompressionEnabled = stream.ReadByte() == 1;

            Read(stream);
        }

        public static MinecraftPacket CreateClientPacket(bool compressed, Stream stream, ProtocolState state) {
            int id = -1;

            if(!compressed) {
                VarInt varInt = new();
                varInt.Read(stream);
                varInt.Read(stream);

                id = varInt.Value;

                stream.Position = 0;
            } else {
                int packetLength = new VarInt(stream).Value;

                long _pos = stream.Position;
                int length = new VarInt(stream).Value;

                if(length == 0) { // packet is uncompressed
                    id = new VarInt(stream).Value;

                    byte[] data = new byte[packetLength - 1];
                    stream.Read(data, 0, data.Length);

                    stream.Position = 0;
                    stream.SetLength(0);
                    new VarInt(id).Write(stream);
                    stream.Write(data);
                    stream.Position = 0;
                } else {
                    byte[] compressedData = new byte[packetLength - _pos];
                    stream.Read(compressedData, 0, compressedData.Length);

                    CompressionUtils.ZLibDecompress(compressedData, out byte[] data);

                    using(MemoryStream output = RMSManager.Get().GetStream(data)) {
                        _pos = output.Position;
                        id = new VarInt(output).Value;
                    }

                    stream.Position = 0;
                    stream.SetLength(0);
                    stream.Write(data);
                    stream.Position = 0;
                }
            }

            MemoryStream mem = RMSManager.Get().GetStream();
            mem.WriteByte(compressed ? (byte) 1 : (byte) 0);
            stream.CopyTo(mem);
            mem.Position = 0;

            Func<Stream, MinecraftPacket> ctor;

            switch(state) {
                case ProtocolState.Handshaking:
                    ctor = clientPacketConstructors[0][id];

                    if(ctor == null) return null;
                    return ctor(mem);
                case ProtocolState.Status:
                    ctor = clientPacketConstructors[1][id];

                    if(ctor == null) return null;
                    return ctor(mem);
                case ProtocolState.Login:
                    ctor = clientPacketConstructors[2][id];

                    if(ctor == null) return null;
                    return ctor(mem);
                case ProtocolState.Play:
                    ctor = clientPacketConstructors[3][id];

                    if(ctor == null) return null;
                    return ctor(mem);
            }

            return null;
        }

        private void Read(Stream stream) {
            if(!CompressionEnabled) {
                Length = new VarInt(stream).Value;

                long _pos = stream.Position;
                Id = new VarInt(stream).Value;

                byte[] data = new byte[Length - (stream.Position - _pos)];
                stream.Read(data, 0, data.Length);

                Data.Write(data);
                Data.Seek(0, SeekOrigin.Begin);
            } else {
                Length = (int) stream.Length;

                long _pos = stream.Position;
                Id = new VarInt(stream).Value;

                byte[] data = new byte[Length - (stream.Position - _pos)];
                stream.Read(data, 0, data.Length);

                Data.Write(data);
                Data.Seek(0, SeekOrigin.Begin);
            }
        }

        protected int ReadVarInt() {
            return new VarInt(Data).Value;
        }

        protected long ReadVarLong() {
            return new VarLong(Data).Value;
        }

        protected int ReadInt() {
            return new Int(Data).Value;
        }

        protected long ReadLong() {
            return new Long(Data).Value;
        }

        protected double ReadDouble() {
            return new DataTypes.Double(Data).Value;
        }

        protected float ReadFloat() {
            return new Float(Data).Value;
        }

        protected bool ReadBoolean() {
            return new DataTypes.Boolean(Data).Value;
        }

        protected short ReadShort() {
            return new Short(Data).Value;
        }

        protected byte ReadUnsignedByte() {
            return new UByte(Data).Value;
        }

        protected sbyte ReadByte() {
            return new DataTypes.Byte(Data).Value;
        }

        protected sbyte[] ReadByteArray(int length) {
            ByteArray byteArray = new(length);
            byteArray.Read(Data);

            return byteArray.Value;
        }

        protected ushort ReadUnsignedShort() {
            return new UShort(Data).Value;
        }

        protected string ReadString() {
            return new DataTypes.String(Data).Value;
        }

        protected dynamic ReadChat() {
            return new Chat(Data).Value;
        }

        protected Utilities.Position.Int ReadPosition() {
            return new DataTypes.Position(Data).Value;
        }

        protected DaanV2.UUID.UUID ReadUuid() {
            return new UUID(Data).Value;
        }

        protected float ReadAngle() {
            return new Angle(Data).Value;
        }

        protected Inventory.Slot ReadSlot() {
            return new Slot(Data).Value;
        }

        /// <typeparam name="I">class/primitive which the data type represents (e.g. int)</typeparam>
        /// <typeparam name="T">the Data type (e.g. nylium.Networking.DataTypes.Int)</typeparam>
        protected I[] ReadArray<I, T>(int count) where T : DataType<I> {
            return new Array<I, T>(count, Data).Value;
        }

        protected Utilities.Identifier ReadIdentifier() {
            return new DataTypes.Identifier(Data).Value;
        }

        protected NbtFile ReadNBT() {
            return new NBT(Data).Value;
        }

        protected List<EntityMetadata.Entry> ReadEntityMetadata() {
            return new EntityMetadata(Data).Value;
        }

        protected void WriteVarInt(int value) {
            new VarInt(value).Write(Data);
        }

        protected void WriteVarLong(long value) {
            new VarLong(value).Write(Data);
        }

        protected void WriteInt(int value) {
            new Int(value).Write(Data);
        }

        protected void WriteLong(long value) {
            new Long(value).Write(Data);
        }

        protected void WriteDouble(double value) {
            new DataTypes.Double(value).Write(Data);
        }

        protected void WriteFloat(float value) {
            new Float(value).Write(Data);
        }

        protected void WriteBoolean(bool value) {
            new DataTypes.Boolean(value).Write(Data);
        }

        protected void WriteShort(short value) {
            new Short(value).Write(Data);
        }

        protected void WriteUnsignedByte(byte value) {
            new UByte(value).Write(Data);
        }

        protected void WriteByte(sbyte value) {
            new DataTypes.Byte(value).Write(Data);
        }

        protected void WriteByteArray(sbyte[] value) {
            new ByteArray(value).Write(Data);
        }

        protected void WriteUnsignedShort(ushort value) {
            new UShort(value).Write(Data);
        }

        protected void WriteString(string value) {
            new DataTypes.String(value).Write(Data);
        }

        protected void WriteChat(dynamic value) {
            new Chat(value).Write(Data);
        }

        protected void WritePosition(Utilities.Position.Int value) {
            new DataTypes.Position(value).Write(Data);
        }

        protected void WriteUuid(DaanV2.UUID.UUID value) {
            new UUID(value).Write(Data);
        }

        protected void WriteAngle(float value) {
            new Angle(value).Write(Data);
        }

        protected void WriteSlot(Inventory.Slot value) {
            new Slot(value).Write(Data);
        }

        /// <typeparam name="I">class/primitive which the data type represents (e.g. int)</typeparam>
        /// <typeparam name="T">the Data type (e.g. nylium.Networking.DataTypes.Int)</typeparam>
        protected void WriteArray<I, T>(I[] value) where T : DataType<I> {
            new Array<I, T>(value).Write(Data);
        }

        protected void WriteIdentifier(Utilities.Identifier value) {
            new DataTypes.Identifier(value).Write(Data);
        }

        protected void WriteNBT(NbtFile value) {
            new NBT(value).Write(Data);
        }

        protected void WriteEntityMetadata(List<EntityMetadata.Entry> value) {
            new EntityMetadata(value).Write(Data);
        }

        public byte[] ToArray(bool compress) {
            CompressionEnabled = compress;
            return ToArray();
        }

        public byte[] ToArray() {
            using(MemoryStream temp = RMSManager.Get().GetStream()) {
                if(!CompressionEnabled) {
                    VarInt varInt = new(Id);

                    if(Length <= 0) {
                        varInt.Write(temp);

                        temp.Write(Data.ToArray());

                        Length = (int) temp.Length;

                        temp.Seek(0, SeekOrigin.Begin);
                        temp.SetLength(0);
                    }

                    varInt.Value = Length;
                    varInt.Write(temp);

                    varInt.Value = Id;
                    varInt.Write(temp);

                    temp.Write(Data.ToArray());
                } else {
                    byte[] output;
                    int dataLength;

                    using(MemoryStream input = RMSManager.Get().GetStream()) {
                        new VarInt(Id).Write(input);
                        Data.WriteTo(input);

                        dataLength = (int) input.Position;

                        if(dataLength >= Nylium.Server.Configuration.CompressionThreshold) {
                            CompressionUtils.ZLibCompress(input.ToArray(), out output);
                        } else {
                            dataLength = 0;
                            output = input.ToArray();
                        }
                    }

                    new VarInt(dataLength).Write(temp);
                    int dataLengthLength = (int) temp.Position;

                    temp.Position = 0;
                    temp.SetLength(0);

                    new VarInt(output.Length + dataLengthLength).Write(temp);
                    new VarInt(dataLength).Write(temp);
                    temp.Write(output);
                }

                return temp.ToArray();
            }
        }

        public void Dispose() {
            Data.Close();
            Data = null;

            GC.SuppressFinalize(this);
        }
    }
}
