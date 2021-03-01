using System;
using System.IO;
using nylium.Extensions;

namespace nylium.Networking.DataTypes {

    class Int : DataType<int> {

        public Int() : base(0) { }
        public Int(int value) : base(value) { }

        public override void Read(Stream stream, out int bytesRead) {
            bytesRead = 0;
            byte[] read = new byte[4];

            stream.Read(read, 0, 4);
            bytesRead += 4;

            Value = (int) ((uint) BitConverter.ToInt32(read)).Swap();
        }

        public override void Write(Stream stream) {
            byte[] bytes = BitConverter.GetBytes(Value);
            Array.Reverse(bytes);

            stream.Write(bytes);
        }
    }
}
