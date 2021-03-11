using System;

namespace nylium.Extensions {

    public static class ByteExtensions {

        public static bool IsBitSet(this byte b, int pos) {
            return (b & (1 << pos)) != 0;
        }

        public static byte SetBit(this byte b, int pos, bool set) {
            b |= (byte) (1 << pos);
            return b;
        }

        public static byte ClearBit(this byte b, int pos, bool set) {
            b &= (byte) ~(1 << pos);
            return b;
        }
    }
}