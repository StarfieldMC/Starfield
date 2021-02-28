using nylium.DataTypes;
using System;
using System.Collections.Generic;
using System.IO;
using nylium.Extensions;
using System.Text;
using System.Net.Sockets;

// TODO compressed packets
namespace nylium.Packets {

    class Packet {

        public int Length { get; set; }
        public int Id { get; set; }
        public MemoryStream Data { get; set; }

        public Packet() {
            Data = new MemoryStream();
        }

        public Packet(int id, byte[] data) {
            Id = id;
            Data = new MemoryStream();
            
            if(data.Length != 0) Data.Write(data);
        }

        public void Read(Stream stream) {
            int lengthBytes;
            int bytesRead;

            VarInt varInt = new VarInt();
            varInt.Read(stream, out bytesRead);

            Length = varInt.Value;
            lengthBytes = bytesRead;

            varInt.Read(stream, out bytesRead);

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
