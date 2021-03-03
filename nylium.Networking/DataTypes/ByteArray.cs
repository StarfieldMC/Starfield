using System;
using System.IO;

namespace nylium.Networking.DataTypes {

    public class ByteArray : DataType<sbyte[]> {

        public int Count { get; }

        public ByteArray(int count) : base(new sbyte[count]) {
            Count = count;
        }

        public ByteArray(sbyte[] value) : base(value) { }

        public override int Read(Stream stream) {
            return stream.Read((byte[]) (Array) Value, 0, Count);
        }

        public override void Write(Stream stream) {
            stream.Write((byte[]) (Array) Value);
        }
    }
}
