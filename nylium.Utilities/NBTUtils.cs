using System;
using System.IO;

namespace nylium.Utilities {

    public class NBTUtils {

        public static bool IsTagEnd(Stream stream) {
            byte[] read = new byte[1];
            stream.Read(read, 0, 1);
            stream.Seek(-1, SeekOrigin.Current);

            if(read[0] == 0x00) { // TAG_End
                return true;
            } else {
                return false;
            }
        }
    }
}
