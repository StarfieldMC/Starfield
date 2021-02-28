using System;
using System.IO;
using nylium.Extensions;

namespace nylium.DataTypes {

    class VarLong : DataType<long> {

        public VarLong() : base(0) { }
        public VarLong(long value) : base(value) { }

        public override void Read(Stream stream, out int bytesRead) {
            bytesRead = 0;
            long result = 0;
            byte[] read = new byte[1];

            do {
                stream.Read(read, 0, 1);

                long value = (read[0] & 0b01111111);
                result |= (value << (7 * bytesRead));

                bytesRead++;

                if (bytesRead > 10) {
                    throw new ArgumentException("VarLong is too big");
                }

            } while ((read[0] & 0b10000000) != 0);

            Value = result;
        }

        public override void Write(Stream stream) {
            long tempVal = Value;

            do {
                byte temp = (byte)(tempVal & 0b01111111);

                tempVal = tempVal.UnsignedRightShift(7);

                if (tempVal != 0) {
                    temp |= 0b10000000;
                }

                stream.WriteByte(temp);
            } while (tempVal != 0);
        }
    }
}
