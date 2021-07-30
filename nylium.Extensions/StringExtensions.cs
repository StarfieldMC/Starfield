using System;
using System.Linq;

namespace nylium.Extensions {

    public static class StringExtensions {

        // https://stackoverflow.com/a/3974535
        public static string ToHex(this byte[] bytes) {
            char[] c = new char[bytes.Length * 2];

            byte b;

            for(int bx = 0, cx = 0; bx < bytes.Length; ++bx, ++cx) {
                b = ((byte) (bytes[bx] >> 4));
                c[cx] = (char) (b > 9 ? b + 0x37 + 0x20 : b + 0x30);

                b = ((byte) (bytes[bx] & 0x0F));
                c[++cx] = (char) (b > 9 ? b + 0x37 + 0x20 : b + 0x30);
            }

            return new string(c);
        }

        public static byte[] HexToBytes(this string str) {
            if(str.Length == 0 || str.Length % 2 != 0)
                return new byte[0];

            byte[] buffer = new byte[str.Length / 2];
            char c;

            for(int bx = 0, sx = 0; bx < buffer.Length; ++bx, ++sx) {
                // Convert first half of byte
                c = str[sx];
                buffer[bx] = (byte) ((c > '9' ? (c > 'Z' ? (c - 'a' + 10) : (c - 'A' + 10)) : (c - '0')) << 4);

                // Convert second half of byte
                c = str[++sx];
                buffer[bx] |= (byte) (c > '9' ? (c > 'Z' ? (c - 'a' + 10) : (c - 'A' + 10)) : (c - '0'));
            }

            return buffer;
        }
        
        // https://stackoverflow.com/a/40169618
        public static string ToPascalCase(this string str) {

            // Replace all non-letter and non-digits with an underscore and lowercase the rest.
            string sample = string.Join("", str?.Select(c => Char.IsLetterOrDigit(c) ? c.ToString().ToLower() : "_").ToArray());

            // Split the resulting string by underscore
            // Select first character, uppercase it and concatenate with the rest of the string
            var arr = sample?
                .Split(new []{'_'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => $"{s.Substring(0, 1).ToUpper()}{s.Substring(1)}");

            // Join the resulting collection
            sample = string.Join("", arr);

            return sample;
        }
    }
}
