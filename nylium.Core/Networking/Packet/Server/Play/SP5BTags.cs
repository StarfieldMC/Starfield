using nylium.Core.Tags;
using nylium.Core.DataTypes;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x5B, ProtocolState.Play, PacketSide.Server)]
    public class SP5BTags : NetworkPacket {

        public Tag[] BlockTags { get; }
        public Tag[] ItemTags { get; }
        public Tag[] FluidTags { get; }
        public Tag[] EntityTags { get; }

        public SP5BTags(Tag[] blockTags, Tag[] itemTags, Tag[] fluidTags, Tag[] entityTags) {
            BlockTags = blockTags;
            ItemTags = itemTags;
            FluidTags = fluidTags;
            EntityTags = entityTags;

            WriteVarInt(blockTags.Length);

            for(int i = 0; i < blockTags.Length; i++) {
                Tag tag = blockTags[i];

                Identifier name = new(tag.Name);
                Array<int, VarInt> entries = new(tag.Entries);

                name.Write(Data);
                WriteVarInt(tag.Entries.Length);
                entries.Write(Data);
            }

            WriteVarInt(itemTags.Length);

            for(int i = 0; i < itemTags.Length; i++) {
                Tag tag = itemTags[i];

                Identifier name = new(tag.Name);
                Array<int, VarInt> entries = new(tag.Entries);

                name.Write(Data);
                WriteVarInt(tag.Entries.Length);
                entries.Write(Data);
            }

            WriteVarInt(fluidTags.Length);

            for(int i = 0; i < fluidTags.Length; i++) {
                Tag tag = fluidTags[i];

                Identifier name = new(tag.Name);
                Array<int, VarInt> entries = new(tag.Entries);

                name.Write(Data);
                WriteVarInt(tag.Entries.Length);
                entries.Write(Data);
            }

            WriteVarInt(entityTags.Length);

            for(int i = 0; i < entityTags.Length; i++) {
                Tag tag = entityTags[i];

                Identifier name = new(tag.Name);
                Array<int, VarInt> entries = new(tag.Entries);

                name.Write(Data);
                WriteVarInt(tag.Entries.Length);
                entries.Write(Data);
            }
        }
    }
}