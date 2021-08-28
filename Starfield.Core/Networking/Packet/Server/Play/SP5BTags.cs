using Starfield.Core.Networking.DataTypes;
using Starfield.Core.Tags;

namespace Starfield.Core.Networking.Packet.Server.Play {

    [Packet(0x5B, ProtocolState.Play, PacketSide.Server)]
    public class SP5BTags : MinecraftPacket {

        public Tag[] BlockTags { get; }
        public Tag[] ItemTags { get; }
        public Tag[] FluidTags { get; }
        public Tag[] EntityTags { get; }

        public SP5BTags(MinecraftClient client, Tag[] blockTags, Tag[] itemTags, Tag[] fluidTags, Tag[] entityTags) : base(client) {
            BlockTags = blockTags;
            ItemTags = itemTags;
            FluidTags = fluidTags;
            EntityTags = entityTags;

            Data.WriteVarInt(blockTags.Length);

            for(int i = 0; i < blockTags.Length; i++) {
                Tag tag = blockTags[i];

                Identifier name = new(tag.Name);
                Array<int, VarInt> entries = new(tag.Entries);

                name.Write(Data);
                Data.WriteVarInt(tag.Entries.Length);
                entries.Write(Data);
            }

            Data.WriteVarInt(itemTags.Length);

            for(int i = 0; i < itemTags.Length; i++) {
                Tag tag = itemTags[i];

                Identifier name = new(tag.Name);
                Array<int, VarInt> entries = new(tag.Entries);

                name.Write(Data);
                Data.WriteVarInt(tag.Entries.Length);
                entries.Write(Data);
            }

            Data.WriteVarInt(fluidTags.Length);

            for(int i = 0; i < fluidTags.Length; i++) {
                Tag tag = fluidTags[i];

                Identifier name = new(tag.Name);
                Array<int, VarInt> entries = new(tag.Entries);

                name.Write(Data);
                Data.WriteVarInt(tag.Entries.Length);
                entries.Write(Data);
            }

            Data.WriteVarInt(entityTags.Length);

            for(int i = 0; i < entityTags.Length; i++) {
                Tag tag = entityTags[i];

                Identifier name = new(tag.Name);
                Array<int, VarInt> entries = new(tag.Entries);

                name.Write(Data);
                Data.WriteVarInt(tag.Entries.Length);
                entries.Write(Data);
            }
        }
    }
}