using System.Collections.Generic;
using System.IO;
using Microsoft.IO;
using Starfield.Nbt;
using Starfield.Utilities;
using Starfield.Core.Entity.Inventories;
using Starfield.Core.Networking.DataTypes;
using Identifier = Starfield.Utilities.Identifier;
using Position = Starfield.Utilities.Position;

namespace Starfield.Core.Networking.IO {

    public class MinecraftStream : Stream {

        public RecyclableMemoryStream BaseStream { get; }

        public override bool CanRead => BaseStream.CanRead;
        public override bool CanSeek => BaseStream.CanSeek;
        public override bool CanWrite => BaseStream.CanWrite;
        public override long Length => BaseStream.Length;
        public override long Position { get => BaseStream.Position; set => BaseStream.Position = value; }

        public MinecraftStream() {
            BaseStream = (RecyclableMemoryStream) RMSManager.Get().GetStream();
        }

        public MinecraftStream(RecyclableMemoryStream stream) {
            BaseStream = stream;
        }

        public override void Flush() {
            BaseStream.Flush();
        }

        public override int Read(byte[] buffer, int offset, int count) {
            return BaseStream.Read(buffer, offset, count);
        }

        public override long Seek(long offset, SeekOrigin origin) {
            return BaseStream.Seek(offset, origin);
        }

        public override void SetLength(long value) {
            BaseStream.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count) {
            BaseStream.Write(buffer, offset, count);
        }

        #region Minecraft helper methods
        public int ReadVarInt() {
            return new VarInt(BaseStream).Value;
        }

        public long ReadVarLong() {
            return new VarLong(BaseStream).Value;
        }

        public int ReadInt() {
            return new Int(BaseStream).Value;
        }

        public long ReadLong() {
            return new Long(BaseStream).Value;
        }

        public double ReadDouble() {
            return new Double(BaseStream).Value;
        }

        public float ReadFloat() {
            return new Float(BaseStream).Value;
        }

        public bool ReadBoolean() {
            return new Boolean(BaseStream).Value;
        }

        public short ReadShort() {
            return new Short(BaseStream).Value;
        }

        public byte ReadUnsignedByte() {
            return new UByte(BaseStream).Value;
        }

        public new sbyte ReadByte() {
            return new Byte(BaseStream).Value;
        }

        public sbyte[] ReadByteArray(int length) {
            ByteArray byteArray = new(length);
            byteArray.Read(BaseStream);

            return byteArray.Value;
        }

        public ushort ReadUnsignedShort() {
            return new UShort(BaseStream).Value;
        }

        public string ReadString() {
            return new String(BaseStream).Value;
        }

        public dynamic ReadChat() {
            return new Chat(BaseStream).Value;
        }

        public Position.Int ReadPosition() {
            return new DataTypes.Position(BaseStream).Value;
        }

        public DaanV2.UUID.UUID ReadUuid() {
            return new UUID(BaseStream).Value;
        }

        public float ReadAngle() {
            return new Angle(BaseStream).Value;
        }

        public Inventory.Slot ReadSlot() {
            return new Slot(BaseStream).Value;
        }

        /// <typeparam name="I">class/primitive which the data type represents (e.g. int)</typeparam>
        /// <typeparam name="T">the Data type (e.g. nylium.Networking.DataTypes.Int)</typeparam>
        public I[] ReadArray<I, T>(int count) where T : DataType<I> {
            return new Array<I, T>(count, BaseStream).Value;
        }

        public Identifier ReadIdentifier() {
            return new DataTypes.Identifier(BaseStream).Value;
        }

        public NBTFile ReadNBT() {
            return new NBT(BaseStream).Value;
        }

        public List<EntityMetadata.Entry> ReadEntityMetadata() {
            return new EntityMetadata(BaseStream).Value;
        }

        public int WriteVarInt(int value) {
            new VarInt(value).Write(BaseStream);
            return value;
        }

        public long WriteVarLong(long value) {
            new VarLong(value).Write(BaseStream);
            return value;
        }

        public int WriteInt(int value) {
            new Int(value).Write(BaseStream);
            return value;
        }

        public long WriteLong(long value) {
            new Long(value).Write(BaseStream);
            return value;
        }

        public double WriteDouble(double value) {
            new Double(value).Write(BaseStream);
            return value;
        }

        public float WriteFloat(float value) {
            new Float(value).Write(BaseStream);
            return value;
        }

        public bool WriteBoolean(bool value) {
            new Boolean(value).Write(BaseStream);
            return value;
        }

        public short WriteShort(short value) {
            new Short(value).Write(BaseStream);
            return value;
        }

        public byte WriteUnsignedByte(byte value) {
            new UByte(value).Write(BaseStream);
            return value;
        }

        public sbyte WriteByte(sbyte value) {
            new Byte(value).Write(BaseStream);
            return value;
        }

        public sbyte[] WriteByteArray(sbyte[] value) {
            new ByteArray(value).Write(BaseStream);
            return value;
        }

        public ushort WriteUnsignedShort(ushort value) {
            new UShort(value).Write(BaseStream);
            return value;
        }

        public string WriteString(string value) {
            new String(value).Write(BaseStream);
            return value;
        }

        public dynamic WriteChat(dynamic value) {
            new Chat(value).Write(BaseStream);
            return value;
        }

        public Position.Int WritePosition(Position.Int value) {
            new DataTypes.Position(value).Write(BaseStream);
            return value;
        }

        public DaanV2.UUID.UUID WriteUuid(DaanV2.UUID.UUID value) {
            new UUID(value).Write(BaseStream);
            return value;
        }

        public float WriteAngle(float value) {
            new Angle(value).Write(BaseStream);
            return value;
        }

        public Inventory.Slot WriteSlot(Inventory.Slot value) {
            new Slot(value).Write(BaseStream);
            return value;
        }

        /// <typeparam name="I">class/primitive which the data type represents (e.g. int)</typeparam>
        /// <typeparam name="T">the Data type (e.g. nylium.Networking.DataTypes.Int)</typeparam>
        public I[] WriteArray<I, T>(I[] value) where T : DataType<I> {
            new Array<I, T>(value).Write(BaseStream);
            return value;
        }

        public Identifier WriteIdentifier(Identifier value) {
            new DataTypes.Identifier(value).Write(BaseStream);
            return value;
        }

        public NBTFile WriteNBT(NBTFile value) {
            new NBT(value).Write(BaseStream);
            return value;
        }

        public List<EntityMetadata.Entry> WriteEntityMetadata(List<EntityMetadata.Entry> value) {
            new EntityMetadata(value).Write(BaseStream);
            return value;
        }
        #endregion
    }
}
