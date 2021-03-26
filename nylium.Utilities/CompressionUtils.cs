using System.IO;
using System.IO.Compression;

namespace nylium.Utilities {

    public class CompressionUtils {

        public static void DeflateCompress(Stream input, Stream output) {
            using(DeflateStream deflate = new(output, CompressionMode.Compress)) {
                input.CopyTo(deflate);
            }
        }

        public static void DeflateDecompress(Stream input, Stream output) {
            using(DeflateStream deflate = new(input, CompressionMode.Decompress)) {
                deflate.CopyTo(output);
            }
        }
    }
}