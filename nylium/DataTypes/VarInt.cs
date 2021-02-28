using System;
using System.IO;
using nylium.Extensions;

namespace nylium.DataTypes {

    class VarInt {

        public static int Read(byte read) {
            int numRead = 0;
            int result = 0;
            do {
                int value = (read & 0b01111111);
                result |= (value << (7 * numRead));

                numRead++;
                if (numRead > 5) {
                    throw new ArgumentException("VarInt is too big");
                }
            } while ((read & 0b10000000) != 0);

            return result;
        }

        public static void Write(Stream stream, int value) {
            do {
                byte temp = (byte)(value & 0b01111111);

                value.UnsignedRightShift(7);

                if (value != 0) {
                    temp |= 0b10000000;
                }

                stream.WriteByte(temp);
            } while (value != 0);
        }
    }
}
