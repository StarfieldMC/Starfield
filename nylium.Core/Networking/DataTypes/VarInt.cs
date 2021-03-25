using System;
using System.IO;
using nylium.Extensions;

namespace nylium.Core.Networking.DataTypes {

    public class VarInt : DataType<int> {

        public VarInt() : base(0) { }
        public VarInt(int value) : base(value) { }
        public VarInt(Stream stream) : base(0) { Read(stream); }

        public override void Read(Stream stream) {
            int bytesRead = 0;
            int result = 0;
            byte[] read = new byte[1];

            do {
                stream.Read(read, 0, 1);

                int value = (read[0] & 0b01111111);
                result |= (value << (7 * bytesRead));

                bytesRead++;

                if(bytesRead > 5) {
                    throw new ArgumentException("VarInt is too big");
                }
            } while((read[0] & 0b10000000) != 0);

            Value = result;
        }

        public override void Write(Stream stream) {
            int tempVal = Value;

            do {
                byte temp = (byte) (tempVal & 0b01111111);

                tempVal = tempVal.UnsignedRightShift(7);

                if(tempVal != 0) {
                    temp |= 0b10000000;
                }

                stream.WriteByte(temp);
            } while(tempVal != 0);
        }
    }
}
