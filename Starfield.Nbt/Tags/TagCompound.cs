using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Starfield.Extensions;

namespace Starfield.Nbt.Tags {

    public class TagCompound : Tag<IDictionary>, IList {

        public object this[int index] { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }
        public object this[object key] { get => Value[key]; set => Value[key] = value; }

        public bool IsFixedSize => Value.IsFixedSize;
        public bool IsReadOnly => Value.IsReadOnly;
        public int Count => Value.Count;
        public bool IsSynchronized => Value.IsSynchronized;
        public object SyncRoot => Value.SyncRoot;

        public TagCompound() : base(Type.TAG_Compound, null, null) {
            Value = new Dictionary<string, object>();
        }

        public TagCompound(string name) : base(Type.TAG_Compound, name, null) {
            Value = new Dictionary<string, object>();
        }

        public override void Read(Stream stream, bool payloadOnly = false) {
            base.Read(stream, payloadOnly);

            int b;

            while((b = stream.ReadByte()) != -1) {
                stream.Position--;

                switch((Type) b) {
                    case Type.TAG_End:
                        return;
                    case Type.TAG_Byte:
                        TagByte @byte = new();
                        @byte.Read(stream, false);

                        Add(@byte);
                        break;
                    case Type.TAG_Short:
                        TagShort @short = new();
                        @short.Read(stream, false);

                        Add(@short);
                        break;
                    case Type.TAG_Int:
                        TagInt @int = new();
                        @int.Read(stream, false);

                        Add(@int);
                        break;
                    case Type.TAG_Long:
                        TagLong @long = new();
                        @long.Read(stream, false);

                        Add(@long);
                        break;
                    case Type.TAG_Float:
                        TagFloat @float = new();
                        @float.Read(stream, false);

                        Add(@float);
                        break;
                    case Type.TAG_Double:
                        TagDouble @double = new();
                        @double.Read(stream, false);

                        Add(@double);
                        break;
                    case Type.TAG_Byte_Array:
                        TagByteArray byteArray = new();
                        byteArray.Read(stream, false);

                        Add(byteArray);
                        break;
                    case Type.TAG_String:
                        TagString @string = new();
                        @string.Read(stream, false);

                        Add(@string);
                        break;
                    case Type.TAG_List:
                        long oldPos = stream.Position;

                        stream.ReadByte();

                        byte[] buffer = new byte[2];
                        stream.Read(buffer, 0, buffer.Length);

                        ushort nameLength = buffer.ReadBigEndianUS();

                        if(nameLength > 0) {
                            buffer = new byte[nameLength];
                            stream.Read(buffer, 0, buffer.Length);
                        }

                        Type listType = (Type) stream.ReadByte();

                        stream.Position = oldPos;
                        
                        switch(listType) {
                            case Type.TAG_End:
                                TagList<TagEnd> endList = new();
                                endList.Read(stream, false);

                                Add(endList);
                                break;
                            case Type.TAG_Byte:
                                TagList<TagByte> byteList = new();
                                byteList.Read(stream, false);

                                Add(byteList);
                                break;
                            case Type.TAG_Short:
                                TagList<TagShort> shortList = new();
                                shortList.Read(stream, false);

                                Add(shortList);
                                break;
                            case Type.TAG_Int:
                                TagList<TagInt> intList = new();
                                intList.Read(stream, false);

                                Add(intList);
                                break;
                            case Type.TAG_Long:
                                TagList<TagLong> longList = new();
                                longList.Read(stream, false);

                                Add(longList);
                                break;
                            case Type.TAG_Float:
                                TagList<TagFloat> floatList = new();
                                floatList.Read(stream, false);

                                Add(floatList);
                                break;
                            case Type.TAG_Double:
                                TagList<TagDouble> doubleList = new();
                                doubleList.Read(stream, false);

                                Add(doubleList);
                                break;
                            case Type.TAG_Byte_Array:
                                TagList<TagByteArray> byteArrayList = new();
                                byteArrayList.Read(stream, false);

                                Add(byteArrayList);
                                break;
                            case Type.TAG_String:
                                TagList<TagString> stringList = new();
                                stringList.Read(stream, false);

                                Add(stringList);
                                break;
                            case Type.TAG_List:
                                throw new Exception("no");
                            case Type.TAG_Compound:
                                TagList<TagCompound> compoundList = new();
                                compoundList.Read(stream, false);

                                Add(compoundList);
                                break;
                            case Type.TAG_Int_Array:
                                TagList<TagIntArray> intArrayList = new();
                                intArrayList.Read(stream, false);

                                Add(intArrayList);
                                break;
                            case Type.TAG_Long_Array:
                                TagList<TagLongArray> longArrayList = new();
                                longArrayList.Read(stream, false);

                                Add(longArrayList);
                                break;
                        }
                        break;
                    case Type.TAG_Compound:
                        TagCompound compound = new();
                        compound.Read(stream, false);

                        Add(compound);
                        stream.Position++;
                        break;
                    case Type.TAG_Int_Array:
                        TagIntArray intArray = new();
                        intArray.Read(stream, false);

                        Add(intArray);
                        break;
                    case Type.TAG_Long_Array:
                        TagLongArray longArray = new();
                        longArray.Read(stream, false);

                        Add(longArray);
                        break;
                    default:
                        throw new Exception("Unknown tag type: " + b);
                }
            }
        }

        public override void Write(Stream stream, bool payloadOnly = false) {
            base.Write(stream, payloadOnly);

            foreach(object obj in Value.Values) {
                switch(obj) {
                    case Tag<byte>:
                        ((Tag<byte>) obj).Write(stream, false);
                        break;
                    case Tag<short>:
                        ((Tag<short>) obj).Write(stream, false);
                        break;
                    case Tag<int>:
                        ((Tag<int>) obj).Write(stream, false);
                        break;
                    case Tag<long>:
                        ((Tag<long>) obj).Write(stream, false);
                        break;
                    case Tag<float>:
                        ((Tag<float>) obj).Write(stream, false);
                        break;
                    case Tag<double>:
                        ((Tag<double>) obj).Write(stream, false);
                        break;
                    case Tag<byte[]>:
                        ((Tag<byte[]>) obj).Write(stream, false);
                        break;
                    case Tag<string>:
                        ((Tag<string>) obj).Write(stream, false);
                        break;
                    case Tag<IDictionary>:
                        ((Tag<IDictionary>) obj).Write(stream, false);
                        break;
                    case Tag<IList<TagEnd>>:
                        ((Tag<IList<TagEnd>>) obj).Write(stream, false);
                        break;
                    case Tag<IList<TagByte>>:
                        ((Tag<IList<TagByte>>) obj).Write(stream, false);
                        break;
                    case Tag<IList<TagShort>>:
                        ((Tag<IList<TagShort>>) obj).Write(stream, false);
                        break;
                    case Tag<IList<TagInt>>:
                        ((Tag<IList<TagInt>>) obj).Write(stream, false);
                        break;
                    case Tag<IList<TagLong>>:
                        ((Tag<IList<TagLong>>) obj).Write(stream, false);
                        break;
                    case Tag<IList<TagFloat>>:
                        ((Tag<IList<TagFloat>>) obj).Write(stream, false);
                        break;
                    case Tag<IList<TagDouble>>:
                        ((Tag<IList<TagDouble>>) obj).Write(stream, false);
                        break;
                    case Tag<IList<TagByteArray>>:
                        ((Tag<IList<TagByteArray>>) obj).Write(stream, false);
                        break;
                    case Tag<IList<TagString>>:
                        ((Tag<IList<TagString>>) obj).Write(stream, false);
                        break;
                    case Tag<IList<TagCompound>>:
                        ((Tag<IList<TagCompound>>) obj).Write(stream, false);
                        break;
                    case Tag<IList<TagIntArray>>:
                        ((Tag<IList<TagIntArray>>) obj).Write(stream, false);
                        break;
                    case Tag<IList<TagLongArray>>:
                        ((Tag<IList<TagLongArray>>) obj).Write(stream, false);
                        break;
                    case Tag<int[]>:
                        ((Tag<int[]>) obj).Write(stream, false);
                        break;
                    case Tag<long[]>:
                        ((Tag<long[]>) obj).Write(stream, false);
                        break;
                }
            }

            stream.WriteByte((byte) Type.TAG_End);
        }

        public int Add(object value) {
            Value.Add(value.GetType().GetProperty("Name").GetValue(value), value);
            return -1;
        }

        public void Add<T>(Tag<T> value) {
            Value.Add(value.Name, value);
        }

        public T Get<T>(string name) {
            return (T) Value[name];
        }

        public void Clear() {
            Value.Clear();
        }

        public bool Contains(object value) {
            return Value.Contains(value.GetType().GetProperty("Name").GetValue(value));
        }

        public void CopyTo(Array array, int index) {
            Value.CopyTo(array, index);
        }

        public IEnumerator GetEnumerator() {
            return Value.GetEnumerator();
        }

        public int IndexOf(object value) {
            throw new NotSupportedException();
        }

        public void Insert(int index, object value) {
            throw new NotSupportedException();
        }

        public void Remove(object value) {
            Value.Remove(value.GetType().GetProperty("Name").GetValue(value));
        }

        public void RemoveAt(int index) {
            throw new NotSupportedException();
        }
    }
}
