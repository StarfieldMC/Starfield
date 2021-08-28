using System;
using System.IO;

namespace Starfield.Core.Networking.DataTypes {

    public class Boolean : DataType<bool> {

        public Boolean() : base(false) { }
        public Boolean(bool value) : base(value) { }
        public Boolean(Stream stream) : base(false) { Read(stream); }

        public override void Read(Stream stream) {
            bool result;
            byte[] read = new byte[1];

            stream.Read(read, 0, 1);

            if(read[0] == 0x00) result = false;
            else if(read[0] == 0x01) result = true;
            else throw new ArgumentException("Invalid value for Boolean data type");

            Value = result;
        }

        public override void Write(Stream stream) {
            stream.WriteByte(Value == true ? (byte) 0x01 : (byte) 0x00);
        }
    }
}
