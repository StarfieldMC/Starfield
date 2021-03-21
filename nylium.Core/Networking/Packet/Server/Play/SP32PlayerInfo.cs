using System;
using DaanV2.UUID;
using nylium.Utilities;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x32, ProtocolState.Play, PacketSide.Server)]
    public class SP32PlayerInfo : NetworkPacket {

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
        public SP32PlayerInfo(UUID uuid, string name, Gamemode gamemode, int ping, dynamic displayName = null) {
            Action = 0;
            Uuid = uuid;
            Name = name;
            Gamemode = gamemode;
            Ping = ping;
            DisplayName = displayName;

            WriteVarInt(Action);
            WriteVarInt(1);
            WriteUuid(uuid);
            WriteString(name);
            WriteVarInt(0);
            WriteVarInt((int) gamemode);
            WriteVarInt(ping);

            if(displayName != null) {
                WriteBoolean(true);
                WriteChat(displayName);
            } else {
                WriteBoolean(false);
            }
        }

        /// <summary>
        /// update gamemode
        /// </summary>
        public SP32PlayerInfo(UUID uuid, Gamemode gamemode) {
            Action = 1;
            Uuid = uuid;
            Gamemode = gamemode;

            WriteVarInt(Action);
            WriteVarInt(1);
            WriteUuid(uuid);
            WriteVarInt((int) gamemode);
        }

        /// <summary>
        /// update ping
        /// </summary>
        public SP32PlayerInfo(UUID uuid, int ping) {
            Action = 2;
            Uuid = uuid;
            Ping = ping;

            WriteVarInt(Action);
            WriteVarInt(1);
            WriteUuid(uuid);
            WriteVarInt(ping);
        }

        /// <summary>
        /// update display name
        /// </summary>
        public SP32PlayerInfo(UUID uuid, dynamic displayName = null) {
            Action = 3;
            Uuid = uuid;
            DisplayName = displayName;

            WriteVarInt(Action);
            WriteVarInt(1);
            WriteUuid(uuid);

            if(displayName != null) {
                WriteBoolean(true);
                WriteChat(displayName);
            } else {
                WriteBoolean(false);
            }
        }

        /// <summary>
        /// remove player
        /// </summary>
        public SP32PlayerInfo(UUID uuid) {
            Action = 4;
            Uuid = uuid;

            WriteVarInt(Action);
            WriteVarInt(1);
            WriteUuid(uuid);
        }
    }
}