using System;
using nylium.Core.DataTypes;

namespace nylium.Core.Packet.Server.Play {

    [Packet(0x56, ProtocolState.Play, PacketSide.Server)]
    public class SP56EntityTeleport : NetworkPacket {

        public int EntityId { get; }
        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        public float Yaw { get; }
        public float Pitch { get; }
        public bool OnGround { get; }

        public SP56EntityTeleport(int entityId, double x, double y, double z, float yaw, float pitch, bool onGround) {
            EntityId = entityId;
            X = x;
            Y = y;
            Z = z;
            OnGround = onGround;

            WriteVarInt(entityId);
            WriteDouble(x);
            WriteDouble(y);
            WriteDouble(z);

            Angle angle = new(yaw);
            angle.Write(Data);

            angle.Value = pitch;
            angle.Write(Data);

            WriteBoolean(onGround);
        }
    }
}