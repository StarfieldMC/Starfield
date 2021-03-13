﻿using System.IO;
using nylium.Extensions;

namespace nylium.Core.DataTypes {

    public class Int : DataType<int> {

        public Int() : base(0) { }
        public Int(int value) : base(value) { }
        public Int(Stream stream) : base(0) { Read(stream); }

        public override int Read(Stream stream) {
            byte[] read = new byte[4];
            int bytesRead = stream.Read(read, 0, 4);

            Value = read.ReadBigEndianI();
            return bytesRead;
        }

        public override void Write(Stream stream) {
            byte[] bytes = Value.WriteBigEndian();
            stream.Write(bytes);
        }
    }
}