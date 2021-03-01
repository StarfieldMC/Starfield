using System.IO;
using nylium.Networking.DataTypes;

// TODO compressed packets
namespace nylium.Networking.Packets {

    public class Packet {

        public int Length { get; set; }
        public int Id { get; set; }
        public MemoryStream Data { get; set; }

        public Packet() {
            Data = new MemoryStream();
        }

        public Packet(int id) {
            Id = id;
            Data = new MemoryStream();
        }

        public Packet(int id, byte[] data) {
            Id = id;
            Data = new MemoryStream();

            if(data.Length != 0) Data.Write(data);
        }

        public void Read(Stream stream) {
            VarInt varInt = new VarInt();
            varInt.Read(stream, out _);

            Length = varInt.Value;

            varInt.Read(stream, out _);

            Id = varInt.Value;

            byte[] data = new byte[Length];

            stream.Read(data, 0, Length);
            Data.Write(data);
        }

        public byte[] GetBytes() {
            byte[] bytes;

            using(MemoryStream temp = new MemoryStream()) {
                VarInt varInt = new VarInt(Id);
                varInt.Write(temp);

                temp.Write(Data.ToArray());

                Length = (int) temp.Length;

                temp.Seek(0, SeekOrigin.Begin);
                temp.SetLength(0);

                varInt.Value = Length;
                varInt.Write(temp);

                varInt.Value = Id;
                varInt.Write(temp);

                temp.Write(Data.ToArray());
                bytes = temp.ToArray();
            }

            return bytes;
        }
    }
}
