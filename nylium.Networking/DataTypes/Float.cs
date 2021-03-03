﻿using System.IO;
using nylium.Extensions;

namespace nylium.Networking.DataTypes {

    public class Float : DataType<float> {

        public Float() : base(0) { }
        public Float(float value) : base(value) { }

        public override int Read(Stream stream) {
            byte[] read = new byte[4];
            int bytesRead = stream.Read(read, 0, 4);

            Value = read.ReadBigEndianF();
            return bytesRead;
        }

        public override void Write(Stream stream) {
            byte[] bytes = Value.WriteBigEndian();
            stream.Write(bytes);
        }
    }
}
