using System;
using System.IO;

namespace nylium.Networking.DataTypes {

    public class Angle : DataType<double> {

        public Angle() : base(0) { }
        public Angle(double value) : base(value) { }

        public override int Read(Stream stream) {
            byte[] read = new byte[1];
            int bytesRead = stream.Read(read, 0, 1);

            Value = (360 / 256) * read[0];
            return bytesRead;
        }

        public override void Write(Stream stream) {
            stream.Write(new byte[1] { (byte) Math.Round((256 / 360) * Value, MidpointRounding.AwayFromZero) }); ;
        }
    }
}
