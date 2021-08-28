using System;
using DaanV2.UUID;
using Starfield.Utilities;

namespace Starfield.Core.Networking.Packet.Server.Play {

    [Packet(0x32, ProtocolState.Play, PacketSide.Server)]
    public class SP32PlayerInfo : MinecraftPacket {

        public int Action { get; }
        public UUID Uuid { get; }

        public string Name { get; }
        // TODO property
        public Gamemode Gamemode { get; }
        public int Ping { get; }
        public dynamic DisplayName { get; }

        /// <summary>
        /// add player
        /// </summary>
        public SP32PlayerInfo(MinecraftClient client, UUID uuid, string name, Gamemode gamemode, int ping, dynamic displayName = null) : base(client) {
            Action = Data.WriteVarInt(0);
            Data.WriteVarInt(1);
            Uuid = Data.WriteUuid(uuid);
            Name = Data.WriteString(name);
            Data.WriteVarInt(0);
            Gamemode = (Gamemode) Data.WriteVarInt((int) gamemode);
            Ping = Data.WriteVarInt(ping);

            if(displayName != null) {
                Data.WriteBoolean(true);
                DisplayName = Data.WriteChat(displayName);
            } else {
                Data.WriteBoolean(false);
            }
        }

        /// <summary>
        /// update gamemode
        /// </summary>
        public SP32PlayerInfo(MinecraftClient client, UUID uuid, Gamemode gamemode) : base(client) {
            Action = Data.WriteVarInt(1);
            Data.WriteVarInt(1);
            Uuid = Data.WriteUuid(uuid);
            Gamemode = (Gamemode) Data.WriteVarInt((int) gamemode);
        }

        /// <summary>
        /// update ping
        /// </summary>
        public SP32PlayerInfo(MinecraftClient client, UUID uuid, int ping) : base(client) {
            Action = Data.WriteVarInt(2);
            Data.WriteVarInt(1);
            Uuid = Data.WriteUuid(uuid);
            Ping = Data.WriteVarInt(ping);
        }

        /// <summary>
        /// update display name
        /// </summary>
        public SP32PlayerInfo(MinecraftClient client, UUID uuid, dynamic displayName = null) : base(client) {
            Action = Data.WriteVarInt(3);
            Data.WriteVarInt(1);
            Uuid = Data.WriteUuid(uuid);

            if(displayName != null) {
                Data.WriteBoolean(true);
                DisplayName = Data.WriteChat(displayName);
            } else {
                Data.WriteBoolean(false);
            }
        }

        /// <summary>
        /// remove player
        /// </summary>
        public SP32PlayerInfo(MinecraftClient client, UUID uuid) : base(client) {
            Action = Data.WriteVarInt(4);
            Data.WriteVarInt(1);
            Uuid = Data.WriteUuid(uuid);
        }
    }
}