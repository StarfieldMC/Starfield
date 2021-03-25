using System;
using System.IO;

namespace nylium.Core.Networking.DataTypes {

    public class ByteArray : DataType<sbyte[]> {

        public int Count { get; }

        public ByteArray(int count) : base(new sbyte[count]) {
            Count = count;
        }

        public ByteArray(sbyte[] value) : base(value) { }

        public ByteArray(int count, Stream stream) : base(new sbyte[count]) {
            Read(stream);
        }

        public override void Read(Stream stream) {
            stream.Read((byte[]) (Array) Value, 0, Count);
        }

        public override void Write(Stream stream) {
            stream.Write((byte[]) (Array) Value);
        }
    }
}
