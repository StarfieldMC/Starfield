using System;
using System.IO;

namespace nylium.DataTypes {

    class Boolean {

        public static bool Read(byte read) {
            bool result;

            if (read == 0x00) result = false;
            else if (read == 0x01) result = true;
            else throw new ArgumentException("Invalid value for Boolean data type");

            return result;
        }

        public static void Write(Stream stream, bool value) {
            stream.WriteByte(value == true ? (byte)0x01 : (byte)0x00);
        }
    }
}
