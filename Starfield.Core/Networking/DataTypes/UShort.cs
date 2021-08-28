using System.IO;
using Starfield.Extensions;

namespace Starfield.Core.Networking.DataTypes {

    public class UShort : DataType<ushort> {

        public UShort() : base(0) { }
        public UShort(ushort value) : base(value) { }
        public UShort(Stream stream) : base(0) { Read(stream); }

        public override void Read(Stream stream) {
            byte[] read = new byte[2];
            stream.Read(read, 0, 2);

            Value = read.ReadBigEndianUS();
        }

        public override void Write(Stream stream) {
            stream.Write(Value.WriteBigEndian());
        }
    }
}
