using System;

namespace nylium.Extensions {

    public static class BitExtensions {

        public static bool IsBitSet(this byte b, byte pos) {
            return (b & (1 << pos)) != 0;
        }

        public static void SetBit(this ref byte b, byte pos) {
            b |= (byte) (1 << pos);
        }

        public static void ClearBit(this ref byte b, byte pos) {
            b &= (byte) ~(1 << pos);
        }

        public static bool IsBitSet(this int b, byte pos) {
            return (b & (1 << pos)) != 0;
        }

        public static void SetBit(this ref int b, byte pos) {
            b |= (1 << pos);
        }

        public static void ClearBit(this ref int b, byte pos) {
            b &= ~(1 << pos);
        }

        public static bool IsBitSet(this long b, byte pos) {
            return (b & (1L << pos)) != 0;
        }

        public static void SetBit(this ref long b, byte pos) {
            b |= (1L << pos);
        }

        public static void ClearBit(this ref long b, byte pos) {
            b &= ~(1L << pos);
        }
    }
}