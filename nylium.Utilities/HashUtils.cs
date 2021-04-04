using System;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace nylium.Utilities {

    public class HashUtils {

        // taken from https://gist.github.com/ammaraskar/7b4a3f73bee9dc4136539644a0f27e63
        // because I am too stupid to figure this out on my own
        public static string MinecraftShaDigest(byte[] input) {
            byte[] hash;

            using(SHA1Managed sha1 = new()) {
                hash = sha1.ComputeHash(input);
            }

            // Reverse the bytes since BigInteger uses little endian
            Array.Reverse(hash);

            BigInteger b = new(hash);

            // very annoyingly, BigInteger in C# tries to be smart and puts in
            // a leading 0 when formatting as a hex number to allow roundtripping 
            // of negative numbers, thus we have to trim it off.
            if(b < 0) {
                // toss in a negative sign if the interpreted number is negative
                return "-" + (-b).ToString("x").TrimStart('0');
            } else {
                return b.ToString("x").TrimStart('0');
            }
        }
    }
}