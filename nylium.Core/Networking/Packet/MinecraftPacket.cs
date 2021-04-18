using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.IO;
using nylium.Core.Networking.DataTypes;
using nylium.Core.Networking.IO;
using nylium.Utilities;
using Serilog;

namespace nylium.Core.Networking.Packet {

    public class MinecraftPacket : IDisposable {

        private static readonly Func<MinecraftClient, Stream, MinecraftPacket>[][] clientPacketConstructors = new Func<MinecraftClient, Stream, MinecraftPacket>[][] {
            new Func<MinecraftClient, Stream, MinecraftPacket>[0xff], // Handshaking packets
            new Func<MinecraftClient, Stream, MinecraftPacket>[0xff], // Status packets
            new Func<MinecraftClient, Stream, MinecraftPacket>[0xff], // Login packets
            new Func<MinecraftClient, Stream, MinecraftPacket>[0xff] // Play packets
        };

        private MinecraftClient Client { get; }

        public int Length { get; set; }
        public int Id { get; set; }
        public MinecraftStream Data { get; set; }

        public static void Initialize() {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            Type[] packetTypes = Assembly.GetExecutingAssembly().GetTypes()
                      .Where(t => string.Equals(t.Namespace, "nylium.Core.Networking.Packet.Client.Handshake")
                        || string.Equals(t.Namespace, "nylium.Core.Networking.Packet.Client.Status")
                        || string.Equals(t.Namespace, "nylium.Core.Networking.Packet.Client.Login")
                        || string.Equals(t.Namespace, "nylium.Core.Networking.Packet.Client.Play"))
                      .ToArray();

            Type[] ctorParams = new Type[] { typeof(MinecraftClient), typeof(Stream) };

            for(int i = 0; i < packetTypes.Length; i++) {
                Type t = packetTypes[i];

                ConstructorInfo constructor = t.GetConstructor(ctorParams);

                if(constructor == null) {
                    Log.Debug(string.Format("Type [{0}] is probably not a packet, ignoring", t.FullName));
                    continue;
                }

                ParameterExpression parameter0 = Expression.Parameter(typeof(MinecraftClient));
                ParameterExpression parameter1 = Expression.Parameter(typeof(Stream));
                Func<MinecraftClient, Stream, MinecraftPacket> ctor = Expression.Lambda<Func<MinecraftClient, Stream, MinecraftPacket>>(Expression.New(constructor, parameter0, parameter1), parameter0, parameter1).Compile();

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

        public MinecraftPacket(MinecraftClient client, MinecraftPacket packet) {
            Client = client;
            Length = packet.Length;
            Id = packet.Id;
            Data = packet.Data;
        }

        public MinecraftPacket(MinecraftClient client) {
            Client = client;
            PacketAttribute attribute = GetType().GetCustomAttribute<PacketAttribute>(false);

            Id = attribute.Id;
            Data = new((RecyclableMemoryStream) RMSManager.Get().GetStream(GetType().FullName));
        }

        public MinecraftPacket(MinecraftClient client, Stream stream) {
            Client = client;
            Data = new((RecyclableMemoryStream) RMSManager.Get().GetStream(GetType().FullName));

            Length = Client.CompressionEnabled ? (int) stream.Length : new VarInt(stream).Value;

            long _pos = stream.Position;
            Id = new VarInt(stream).Value;

            byte[] data = new byte[Length - (stream.Position - _pos)];
            stream.Read(data, 0, data.Length);

            Data.Write(data);
            Data.Seek(0, SeekOrigin.Begin);
        }

        public static MinecraftPacket CreateClientPacket(MinecraftClient client, MemoryStream stream, ProtocolState state) {
            int id = -1;

            if(client.EncryptionEnabled) {
                byte[] decrypted = client.Decryptor.ProcessBytes(stream.ToArray(), 0, (int) stream.Length);

                stream.Position = 0;
                stream.SetLength(0);
                stream.Write(decrypted);
                stream.Position = 0;
            }

            if(!client.CompressionEnabled) {
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

            Func<MinecraftClient, Stream, MinecraftPacket> ctor;

            switch(state) {
                case ProtocolState.Handshaking:
                    ctor = clientPacketConstructors[0][id];

                    if(ctor == null) return null;
                    return ctor(client, stream);
                case ProtocolState.Status:
                    ctor = clientPacketConstructors[1][id];

                    if(ctor == null) return null;
                    return ctor(client, stream);
                case ProtocolState.Login:
                    ctor = clientPacketConstructors[2][id];

                    if(ctor == null) return null;
                    return ctor(client, stream);
                case ProtocolState.Play:
                    ctor = clientPacketConstructors[3][id];

                    if(ctor == null) return null;
                    return ctor(client, stream);
            }

            return null;
        }

        public byte[] ToArray() {
            using(MemoryStream temp = RMSManager.Get().GetStream()) {
                if(!Client.CompressionEnabled) {
                    VarInt varInt = new(Id);

                    if(Length <= 0) {
                        varInt.Write(temp);
                        Data.BaseStream.WriteTo(temp);

                        Length = (int) temp.Length;

                        temp.Position = 0;
                        temp.SetLength(0);
                    }

                    varInt.Value = Length;
                    varInt.Write(temp);

                    varInt.Value = Id;
                    varInt.Write(temp);

                    Data.BaseStream.WriteTo(temp);
                } else {
                    byte[] output;
                    int dataLength;

                    using(MemoryStream input = RMSManager.Get().GetStream()) {
                        new VarInt(Id).Write(input);
                        Data.BaseStream.WriteTo(input);

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

                if(Client.EncryptionEnabled) {
                    return Client.Encryptor.ProcessBytes(temp.ToArray(), 0, (int) temp.Length);
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
