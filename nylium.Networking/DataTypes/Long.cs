using System;
using System.IO;
using nylium.Extensions;

namespace nylium.Networking.DataTypes {

    class Long : DataType<long> {

        public Long() : base(0) { }
        public Long(long value) : base(value) { }

        public override void Read(Stream stream, out int bytesRead) {
            bytesRead = 0;
            byte[] read = new byte[8];

            stream.Read(read, 0, 8);
            bytesRead += 8;

            Value = (long) ((ulong) BitConverter.ToInt64(read)).Swap(); 
        }

        public override void Write(Stream stream) {
            byte[] bytes = BitConverter.GetBytes(Value);
            Array.Reverse(bytes);

            stream.Write(bytes);
        }
    }
}
