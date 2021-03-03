using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using nylium.Networking.DataTypes;
using nylium.Utilities;

// TODO compressed packets
namespace nylium.Networking.Packets {

    public class Packet : IDisposable {

        private static readonly Dictionary<PacketAttribute, Type> packets = new Dictionary<PacketAttribute, Type>();

        public int Length { get; set; }
        public int Id { get; set; }
        public MemoryStream Data { get; set; }

        static Packet() {
            Type[] packetTypes = Assembly.GetExecutingAssembly().GetTypes()
                      .Where(t => string.Equals(t.Namespace, "nylium.Networking.Packets.Client")
                        || string.Equals(t.Namespace, "nylium.Networking.Packets.Server"))
                      .ToArray();

            foreach(Type t in packetTypes) {
                packets.Add(t.GetCustomAttribute<PacketAttribute>(false), t);
            }
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

        public static Packet CreatePacket(Stream stream, ProtocolState state, PacketSide side) {
            VarInt varInt = new VarInt();
            varInt.Read(stream);
            varInt.Read(stream);

            int id = varInt.Value;
            stream.Seek(0, SeekOrigin.Begin);

            Type t;

            if(!packets.TryGetValue(new PacketAttribute(id, state, side), out t)) {
                return null;
            }

            if(t.GetConstructor(new Type[] { typeof(Stream) }) == null) {
                return (Packet) Activator.CreateInstance(t);
            } else {
                return (Packet) Activator.CreateInstance(t, stream);
            }
        }

        private void Read(Stream stream) {
            VarInt varInt = new VarInt();
            varInt.Read(stream);

            Length = varInt.Value;

            varInt.Read(stream);

            Id = varInt.Value;

            byte[] data = new byte[Length];

            stream.Read(data, 0, Length);
            Data.Write(data);
        }

        public byte[] ToArray() {
            byte[] bytes;

            using(MemoryStream temp = new MemoryStream()) {
                VarInt varInt = new VarInt(Id);

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
