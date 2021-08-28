using System.IO;
using Starfield.Extensions;

namespace Starfield.Core.Networking.DataTypes {

    public class UUID : DataType<DaanV2.UUID.UUID> {

        public UUID() : base(null) { }
        public UUID(DaanV2.UUID.UUID value) : base(value) { }
        public UUID(Stream stream) : base(null) { Read(stream); }

        public override void Read(Stream stream) {
            byte[] read = new byte[16];
            stream.Read(read, 0, 16);

            string s = read.ToHex();
            char[] ch = new char[32 + 4];

            // :D
            ch[0] = s[0];
            ch[1] = s[1];
            ch[2] = s[2];
            ch[3] = s[3];
            ch[4] = s[4];
            ch[5] = s[5];
            ch[6] = s[6];
            ch[7] = s[7];
            ch[8] = '-';
            ch[9] = s[8];
            ch[10] = s[9];
            ch[11] = s[10];
            ch[12] = s[11];
            ch[13] = '-';
            ch[14] = s[12];
            ch[15] = s[13];
            ch[16] = s[14];
            ch[17] = s[15];
            ch[18] = '-';
            ch[19] = s[16];
            ch[20] = s[17];
            ch[21] = s[18];
            ch[22] = s[19];
            ch[23] = '-';
            ch[24] = s[20];
            ch[25] = s[21];
            ch[26] = s[22];
            ch[27] = s[23];
            ch[28] = s[24];
            ch[29] = s[25];
            ch[30] = s[26];
            ch[31] = s[27];
            ch[32] = s[28];
            ch[33] = s[29];
            ch[34] = s[30];
            ch[35] = s[31];

            Value = new DaanV2.UUID.UUID(ch);
        }

        public override void Write(Stream stream) {
            string s = new(Value.Chars);
            s = s.Replace("-", "");

            stream.Write(s.HexToBytes());
        }
    }
}
