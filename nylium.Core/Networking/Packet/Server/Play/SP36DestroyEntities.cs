using System;
using nylium.Core.Networking.DataTypes;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x36, ProtocolState.Play, PacketSide.Server)]
    public class SP36DestroyEntities : MinecraftPacket {

        public int[] EntityIds { get; }

        public SP36DestroyEntities(int[] entityIds) {
            EntityIds = entityIds;

            WriteVarInt(entityIds.Length);
            WriteArray<int, VarInt>(entityIds);
        }
    }
}