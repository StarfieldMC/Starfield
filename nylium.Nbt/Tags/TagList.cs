using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using nylium.Extensions;

namespace nylium.Nbt.Tags {

    public class TagList<T> : Tag<IList<T>>, IList<T> {

        private Func<T> defaultCtor;

        private Action<T, Stream, bool> read = (Action<T, Stream, bool>) Delegate.CreateDelegate(typeof(Action<T, Stream, bool>), null,
            typeof(T).GetMethod("Read", new System.Type[] { typeof(Stream), typeof(bool) }));
        private Action<T, Stream, bool> write = (Action<T, Stream, bool>) Delegate.CreateDelegate(typeof(Action<T, Stream, bool>), null,
            typeof(T).GetMethod("Write", new System.Type[] { typeof(Stream), typeof(bool) }));

        public T this[int index] { get => Value[index]; set => Value[index] = value; }
        public int Count => Value.Count;
        public bool IsReadOnly => Value.IsReadOnly;

        public TagList() : base(Type.TAG_List) {
            ConstructorInfo constructor = typeof(T).GetConstructor(System.Type.EmptyTypes);
            defaultCtor = Expression.Lambda<Func<T>>(Expression.New(constructor)).Compile();
        }

        public TagList(string name, IList<T> value) : base(Type.TAG_List, name, value) {
            ConstructorInfo constructor = typeof(T).GetConstructor(System.Type.EmptyTypes);
            defaultCtor = Expression.Lambda<Func<T>>(Expression.New(constructor)).Compile();
        }

        public override void Read(Stream stream, bool payloadOnly = false) {
            base.Read(stream, payloadOnly);
            stream.ReadByte();

            byte[] buffer = new byte[4];
            stream.Read(buffer, 0, buffer.Length);

            int length = buffer.ReadBigEndianI();

            if(length <= 0) {
                Value = new List<T>(0);
            } else {
                if(typeof(T) == typeof(TagEnd)) {
                    throw new Exception("Tag type cannot be TAG_End if length is not negative!");
                }

                Value = new List<T>(length);

                for(int i = 0; i < length; i++) {
                    T t = defaultCtor();
                    read(t, stream, true);
                    stream.Position++;

                    Add(t);
                }
            }
        }

        public override void Write(Stream stream, bool payloadOnly = false) {
            base.Write(stream, payloadOnly);
            
            if(Value.Count > 0) {
                stream.WriteByte((byte) (Type) typeof(T).GetProperty("TagType").GetValue(Value[0]));
                stream.Write(Value.Count.WriteBigEndian());

                for(int i = 0; i < Value.Count; i++) {
                    T t = Value[i];
                    write(t, stream, true);
                }
            } else {
                stream.WriteByte((byte) Type.TAG_End);
                stream.Write(0.WriteBigEndian());
            }
        }

        public void Add(T item) {
            Value.Add(item);
        }

        public void Clear() {
            Value.Clear();
        }

        public bool Contains(T item) {
            return Value.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex) {
            Value.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator() {
            return Value.GetEnumerator();
        }

        public int IndexOf(T item) {
            return Value.IndexOf(item);
        }

        public void Insert(int index, T item) {
            Value.Insert(index, item);
        }

        public bool Remove(T item) {
            return Value.Remove(item);
        }

        public void RemoveAt(int index) {
            Value.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return Value.GetEnumerator();
        }
    }
}
