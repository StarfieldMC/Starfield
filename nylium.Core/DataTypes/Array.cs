using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;

namespace nylium.Core.DataTypes {

    // class/primitive which the data type represents (e.g. int)      the Data type (e.g. nylium.Networking.DataTypes.Int)
    //                 |                                                                         |
    //                 |  +----------------------------------------------------------------------+
    //                 |  |
    public class Array<I, T> : DataType<I[]> where T : DataType<I> {

        private static readonly Func<T> defaultCtor;
        private static readonly Func<I, T> valueCtor;

        public int Count { get; }

        static Array() {
            ConstructorInfo constructor = typeof(T).GetConstructor(Type.EmptyTypes);
            defaultCtor = Expression.Lambda<Func<T>>(Expression.New(constructor)).Compile();

            constructor = typeof(T).GetConstructor(new Type[] { typeof(I) });
            ParameterExpression parameter = Expression.Parameter(typeof(I));
            valueCtor = Expression.Lambda<Func<I, T>>(Expression.New(constructor, parameter), parameter).Compile();
        }

        public Array(int count) : base(new I[count]) {
            Count = count;
        }

        public Array(I[] value) : base(value) {
            Count = value.Length;
        }

        public Array(int count, Stream stream) : base(new I[count]) {
            Read(stream);
        }

        public override int Read(Stream stream) {
            int bytesRead = 0;
            I[] arr = new I[Count];

            for(int i = 0; i < Count; i++) {
                T t = defaultCtor();
                bytesRead += t.Read(stream);

                arr[i] = t.Value;
            }

            Value = arr;
            return bytesRead;
        }

        public override void Write(Stream stream) {
            for(int i = 0; i < Count; i++) {
                T t = valueCtor(Value[i]);
                t.Write(stream);
            }
        }
    }
}
