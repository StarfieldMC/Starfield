using nylium.Core.Tags;
using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Server.Play {

    [Packet(0x5B, ProtocolState.Play, PacketSide.Server)]
    public class SP5BTags : Packet {

        public Tag[] BlockTags { get; }
        public Tag[] ItemTags { get; }
        public Tag[] FluidTags { get; }
        public Tag[] EntityTags { get; }

        public SP5BTags(Tag[] blockTags, Tag[] itemTags, Tag[] fluidTags, Tag[] entityTags) {
            BlockTags = blockTags;
            ItemTags = itemTags;
            FluidTags = fluidTags;
            EntityTags = entityTags;

            VarInt varInt = new(blockTags.Length);
            varInt.Write(Data);

            for(int i = 0; i < blockTags.Length; i++) {
                Tag tag = blockTags[i];

                Identifier name = new(tag.Name);
                varInt.Value = tag.Entries.Length;
                Array<int, VarInt> entries = new(tag.Entries);

                name.Write(Data);
                varInt.Write(Data);
                entries.Write(Data);
            }

            varInt.Value = itemTags.Length;
            varInt.Write(Data);

            for(int i = 0; i < itemTags.Length; i++) {
                Tag tag = itemTags[i];

                Identifier name = new(tag.Name);
                varInt.Value = tag.Entries.Length;
                Array<int, VarInt> entries = new(tag.Entries);

                name.Write(Data);
                varInt.Write(Data);
                entries.Write(Data);
            }

            varInt.Value = fluidTags.Length;
            varInt.Write(Data);

            for(int i = 0; i < fluidTags.Length; i++) {
                Tag tag = fluidTags[i];

                Identifier name = new(tag.Name);
                varInt.Value = tag.Entries.Length;
                Array<int, VarInt> entries = new(tag.Entries);

                name.Write(Data);
                varInt.Write(Data);
                entries.Write(Data);
            }

            varInt.Value = entityTags.Length;
            varInt.Write(Data);

            for(int i = 0; i < entityTags.Length; i++) {
                Tag tag = entityTags[i];

                Identifier name = new(tag.Name);
                varInt.Value = tag.Entries.Length;
                Array<int, VarInt> entries = new(tag.Entries);

                name.Write(Data);
                varInt.Write(Data);
                entries.Write(Data);
            }
        }
    }
}