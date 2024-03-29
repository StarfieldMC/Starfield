﻿using System.IO;
using Starfield.Nbt;
using Starfield.Utilities;
using Starfield.Core.Entity.Inventories;

namespace Starfield.Core.Networking.DataTypes {

    public class Slot : DataType<Inventory.Slot> {

        public Slot() : base(null) { }
        public Slot(Inventory.Slot value) : base(value) { }
        public Slot(Stream stream) : base(null) { Read(stream); }

        public override void Read(Stream stream) {
            Boolean boolean = new(stream);
            
            if(boolean.Value) {
                VarInt itemId = new(stream);
                Byte @byte = new(stream);

                NBT nbt = null;

                if(!NBTUtils.IsTagEnd(stream)) {
                    nbt = new NBT(stream);
                }

                Value = new Inventory.Slot(boolean.Value, itemId.Value, @byte.Value, nbt?.Value.Root);
            } else {
                Value = Inventory.Slot.Empty;
            }
        }

        public override void Write(Stream stream) {
            new Boolean(Value.Present).Write(stream);
            
            if(Value.Present) {
                new VarInt(Value.Item.ProtocolId).Write(stream);
                new Byte(Value.Count).Write(stream);
                
                if(Value.NBT == null) {
                    stream.WriteByte(0x00); // TAG_END
                } else {
                    new NBT(new NBTFile(Value.NBT)).Write(stream);
                }
            }
        }
    }
}
