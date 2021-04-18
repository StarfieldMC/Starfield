using System.IO;
using Ionic.Zlib;

namespace nylium.Utilities {

    public class CompressionUtils {

        public static void DeflateCompress(Stream input, Stream output) {
            using(DeflateStream deflate = new(output, CompressionMode.Compress, true)) {
                input.CopyTo(deflate);
            }
        }

        public static void DeflateDecompress(Stream input, Stream output) {
            using(DeflateStream deflate = new(input, CompressionMode.Decompress, true)) {
                deflate.CopyTo(output);
            }
        }

        public static void ZLibCompress(Stream input, Stream output) {
            using(ZlibStream zlib = new(output, CompressionMode.Compress, true)) {
                input.CopyTo(zlib);
            }
        }

        public static void ZLibDecompress(Stream input, Stream output) {
            using(ZlibStream zlib = new(input, CompressionMode.Decompress, true)) {
                zlib.CopyTo(output);
            }
        }

        public static void ZLibCompress(byte[] inData, out byte[] outData) {
            using(MemoryStream output = RMSManager.Get().GetStream()) {
                using(MemoryStream input = RMSManager.Get().GetStream(inData)) {
                    ZLibCompress(input, output);
                    outData = output.ToArray();
                }
            }
        }

        public static void ZLibDecompress(byte[] inData, out byte[] outData) {
            using(MemoryStream output = RMSManager.Get().GetStream()) {
                using(MemoryStream input = RMSManager.Get().GetStream(inData)) {
                    ZLibDecompress(input, output);
                    outData = output.ToArray();
                }
            }
        }

        public static void GZipCompress(Stream input, Stream output) {
            using(GZipStream zipStream = new(output, CompressionMode.Compress, true)) {
                input.CopyTo(zipStream);
            }
        }

        public static void GZipDecompress(Stream input, Stream output) {
            using(GZipStream zipStream = new(input, CompressionMode.Decompress, true)) {
                zipStream.CopyTo(output);
            }
        }
    }
}