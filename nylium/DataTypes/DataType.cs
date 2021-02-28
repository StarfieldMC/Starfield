using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace nylium.DataTypes {

    abstract class DataType<T> {

        public T Value { get; set; }

        public DataType(T value) {
            Value = value;
        }

        public abstract void Read(Stream stream, out int bytesRead);
        public abstract void Write(Stream stream);
    }
}
