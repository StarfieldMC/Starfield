using System.Collections.Generic;
using System.IO;
using System.Linq;
using nylium.Nbt.Tags;
using nylium.Utilities;

namespace nylium.Nbt {

    public class NBTFile {

        private static readonly List<byte[]> zlibHeaders = new() {
            new byte[2] { 0x78, 0x01 },
            new byte[2] { 0x78, 0x5e },
            new byte[2] { 0x78, 0x9c },
            new byte[2] { 0x78, 0xda }
        };

        private static readonly List<byte[]> gzipHeaders = new() {
            new byte[2] { 0x1f, 0x8b }
        };

        public TagCompound Root { get; set; }

        public NBTFile(TagCompound root = null) {
            Root = root ?? new("");
        }

        public NBTFile Read(Stream stream) {
            byte[] buffer = new byte[2];
            stream.Read(buffer, 0, buffer.Length);
            stream.Position = 0;

            Stream output = RMSManager.Get().GetStream();

            if(zlibHeaders.Any(b => b.SequenceEqual(buffer))) {
                CompressionUtils.ZLibDecompress(stream, output);
                stream = output;
            } else if(gzipHeaders.Any(b => b.SequenceEqual(buffer))) {
                CompressionUtils.GZipDecompress(stream, output);
                stream = output;
            }

            stream.Position = 0;

            Root.Read(stream);
            return this;
        }

        public NBTFile Write(Stream stream, Compression compression = Compression.None) {
            Stream output = RMSManager.Get().GetStream();

            Root.Write(output);
            output.Position = 0;

            switch(compression) {
                case Compression.ZLib:
                    CompressionUtils.ZLibCompress(output, stream);
                    break;
                case Compression.GZip:
                    CompressionUtils.GZipCompress(output, stream);
                    break;
                default:
                    output.CopyTo(stream);
                    break;
            }

            stream.Flush();
            return this;
        }

        public enum Compression {

            GZip,
            ZLib,
            None
        }
    }
}
