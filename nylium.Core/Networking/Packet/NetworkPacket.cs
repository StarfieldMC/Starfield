using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using nylium.Core.DataTypes;
using nylium.Utilities;
using Serilog;

// TODO compressed packets
namespace nylium.Core.Networking.Packet {

    public class NetworkPacket : IDisposable {

        private static readonly Func<Stream, NetworkPacket>[][] clientPacketConstructors = new Func<Stream, NetworkPacket>[][] {
            new Func<Stream, NetworkPacket>[0xff], // Handshaking packets
            new Func<Stream, NetworkPacket>[0xff], // Status packets
            new Func<Stream, NetworkPacket>[0xff], // Login packets
            new Func<Stream, NetworkPacket>[0xff] // Play packets
        };

        public int Length { get; set; }
        public int Id { get; set; }
        public MemoryStream Data { get; set; }

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
                Func<Stream, NetworkPacket> ctor = Expression.Lambda<Func<Stream, NetworkPacket>>(Expression.New(constructor, parameter), parameter).Compile();

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

        public NetworkPacket() {
            PacketAttribute attribute = GetType().GetCustomAttribute<PacketAttribute>(false);

            Id = attribute.Id;
            Data = RMSManager.Get().GetStream(GetType().FullName);
        }

        public NetworkPacket(Stream stream) {
            Data = RMSManager.Get().GetStream(GetType().FullName);
            Read(stream);
        }

        public static NetworkPacket CreateClientPacket(Stream stream, ProtocolState state) {
            VarInt varInt = new();
            varInt.Read(stream);
            varInt.Read(stream);

            int id = varInt.Value;
            stream.Seek(0, SeekOrigin.Begin);

            Func<Stream, NetworkPacket> ctor;

            switch(state) {
                case ProtocolState.Handshaking:
                    ctor = clientPacketConstructors[0][id];

                    if(ctor == null) return null;
                    return ctor(stream);
                case ProtocolState.Status:
                    ctor = clientPacketConstructors[1][id];

                    if(ctor == null) return null;
                    return ctor(stream);
                case ProtocolState.Login:
                    ctor = clientPacketConstructors[2][id];

                    if(ctor == null) return null;
                    return ctor(stream);
                case ProtocolState.Play:
                    ctor = clientPacketConstructors[3][id];

                    if(ctor == null) return null;
                    return ctor(stream);
            }

            return null;
        }

        private void Read(Stream stream) {
            VarInt varInt = new();
            varInt.Read(stream);

            Length = varInt.Value;

            int bytesRead = varInt.Read(stream);

            Id = varInt.Value;

            byte[] data = new byte[Length - bytesRead];

            stream.Read(data, 0, data.Length);

            Data.Write(data);
            Data.Seek(0, SeekOrigin.Begin);
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

        public byte[] ToBytes() {
            byte[] bytes;

            using(MemoryStream temp = new()) {
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
                bytes = temp.ToArray();
            }

            return bytes;
        }

        public void Dispose() {
            Data.Close();
            Data = null;

            GC.SuppressFinalize(this);
        }
    }
}
