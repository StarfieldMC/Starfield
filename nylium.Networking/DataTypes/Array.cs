using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;

namespace nylium.Networking.DataTypes {

    public class Array<I, T> : DataType<T[]> where T : DataType<I> {

        private static readonly Func<T> defaultCtor;

        public int Count { get; }

        static Array() {
            ConstructorInfo constructor = typeof(T).GetConstructor(new Type[0]);
            defaultCtor = Expression.Lambda<Func<T>>(Expression.New(constructor)).Compile();
        }

        public Array(int count) : base(new T[count]) {
            Count = count;
        }

        public Array(T[] value) : base(value) {
            Count = value.Length;
        }

        public override int Read(Stream stream) {
            int bytesRead = 0;
            T[] arr = new T[Count];

            for(int i = 0; i < Count; i++) {
                T t = defaultCtor();
                bytesRead += t.Read(stream);

                arr[i] = t;
            }

            return bytesRead;
        }

        public override void Write(Stream stream) {
            for(int i = 0; i < Count; i++) {
                Value[Count].Write(stream);
            }
        }
    }
}
