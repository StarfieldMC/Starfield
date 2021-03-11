using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using nylium.Networking.DataTypes;
using nylium.Utilities;

// TODO compressed packets
namespace nylium.Networking.Packets {

    public class Packet : IDisposable {

        private static readonly Func<Stream, Packet>[][] clientPacketConstructors = new Func<Stream, Packet>[][] {
            new Func<Stream, Packet>[0xff], // Handshaking packets
            new Func<Stream, Packet>[0xff], // Status packets
            new Func<Stream, Packet>[0xff], // Login packets
            new Func<Stream, Packet>[0xff] // Play packets
        };

        public int Length { get; set; }
        public int Id { get; set; }
        public MemoryStream Data { get; set; }

        public static void Initialize() {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            Type[] packetTypes = Assembly.GetExecutingAssembly().GetTypes()
                      .Where(t => string.Equals(t.Namespace, "nylium.Networking.Packets.Client.Handshake")
                        || string.Equals(t.Namespace, "nylium.Networking.Packets.Client.Status")
                        || string.Equals(t.Namespace, "nylium.Networking.Packets.Client.Login")
                        || string.Equals(t.Namespace, "nylium.Networking.Packets.Client.Play"))
                      .ToArray();

            Type[] ctorParams = new Type[] { typeof(Stream) };

            for(int i = 0; i < packetTypes.Length; i++) {
                Type t = packetTypes[i];

                ConstructorInfo constructor = t.GetConstructor(ctorParams);

                if(constructor == null) {
                    Console.WriteLine(string.Format("Type [{0}] is probably not a packet, ignoring", t.FullName));
                    continue;
                }

                ParameterExpression parameter = Expression.Parameter(typeof(Stream));
                Func<Stream, Packet> ctor = Expression.Lambda<Func<Stream, Packet>>(Expression.New(constructor, parameter), parameter).Compile();

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
            Console.WriteLine("Initialized packets in " + Math.Round(stopwatch.Elapsed.TotalMilliseconds, 2) + "ms");
            stopwatch = null;
        }

        public Packet() {
            PacketAttribute attribute = GetType().GetCustomAttribute<PacketAttribute>(false);

            Id = attribute.Id;
            Data = RMSManager.Get().GetStream(GetType().FullName);
        }

        public Packet(Stream stream) {
            Data = RMSManager.Get().GetStream(GetType().FullName);
            Read(stream);
        }

        public static Packet CreateClientPacket(Stream stream, ProtocolState state) {
            VarInt varInt = new();
            varInt.Read(stream);
            varInt.Read(stream);

            int id = varInt.Value;
            stream.Seek(0, SeekOrigin.Begin);

            Func<Stream, Packet> ctor;

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
        }
    }
}
