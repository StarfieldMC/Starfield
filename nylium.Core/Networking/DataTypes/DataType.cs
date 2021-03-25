using System.IO;

namespace nylium.Core.Networking.DataTypes {

    public abstract class DataType<T> {

        public T Value { get; set; }

        public DataType(T value) {
            Value = value;
        }

        public abstract void Read(Stream stream);
        public abstract void Write(Stream stream);
    }
}
