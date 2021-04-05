using System;
using nylium.Extensions;

namespace nylium.Utilities {

    public class RandomUtils {

        public static long Long(Random r) {
            byte[] buf = new byte[8];
            r.NextBytes(buf);

            return buf.ReadLittleEndianL();
        }
    }
}