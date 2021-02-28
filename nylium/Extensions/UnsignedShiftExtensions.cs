using System;
using System.Collections.Generic;
using System.Text;

namespace nylium.Extensions {

    public static class UnsignedShiftExtensions {

        public static int UnsignedRightShift(this int signed, int places) {
            unchecked {
                var unsigned = (uint) signed;
                unsigned >>= places;
                return (int) unsigned;
            }
        }

        public static long UnsignedRightShift(this long signed, int places) {
            unchecked {
                var unsigned = (ulong) signed;
                unsigned >>= places;
                return (long) unsigned;
            }
        }

        public static int UnsignedLeftShift(this int signed, int places) {
            unchecked {
                var unsigned = (uint) signed;
                unsigned <<= places;
                return (int) unsigned;
            }
        }

        public static long UnsignedLeftShift(this long signed, int places) {
            unchecked {
                var unsigned = (ulong) signed;
                unsigned <<= places;
                return (long) unsigned;
            }
        }
    }
}
