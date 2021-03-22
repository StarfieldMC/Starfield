using System;
using System.Collections;
using nylium.Extensions;

namespace nylium.Utilities {

    public class SectionUtils {

        // TODO find a better way to do this
        // i probably won't even know what this does in a few days
        public static long[] ToCompactedLongArray(ushort[] ids, int bitsPerBlock) {
            //                                   64 bits per long
            int blocksPerLong = (int) Math.Floor(64d / bitsPerBlock);

            //                       section size
            long[] array = new long[(16 * 16 * 16) / blocksPerLong];
            int longArrayIndex = array.Length - 1;
            byte longIndex = 0;

            for(int i = 0; i < ids.Length; i++) {
                if(longIndex >= (bitsPerBlock * blocksPerLong)) {
                    longArrayIndex--;
                    longIndex = 0;
                }

                BitArray id = new(ids[i].WriteLittleEndian());

                bool[] bits = new bool[bitsPerBlock];
                bool removing = true;

                int k = 0;

                // please don't ask me what this does because i don't even know
                for(int j = id.Count - 1; j >= 0; j--) {
                    bool bit = id.Get(j);

                    if(removing) {
                        if(j - 1 < 0) break;

                        if(id.Get(j - 1)) {
                            removing = false;
                        }
                    } else {
                        if(k > 14 - 1) break;

                        bits[j] = bit;
                        k++;
                    }
                }

                Array.Reverse(bits);
                id = new BitArray(bits);

                for(int j = id.Count - 1; j >= 0; j--) {
                    if(id.Get(j)) {
                        array[longArrayIndex].SetBit(longIndex);
                    } else {
                        array[longArrayIndex].ClearBit(longIndex);
                    }

                    longIndex++;
                }
            }

            Array.Reverse(array); // reverse, otherwise the Y coordinate will be flipped
            return array;
        }
    }
}