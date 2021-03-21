using System;
using nylium.Core.DataTypes;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x28, ProtocolState.Play, PacketSide.Server)]
    public class SP28EntityPositionAndRotation : NetworkPacket {

        public int EntityId { get; }
        public short DeltaX { get; }
        public short DeltaY { get; }
        public short DeltaZ { get; }
        public float Yaw { get; }
        public float Pitch { get; }
        public bool OnGround { get; }

        public SP28EntityPositionAndRotation(int entityId, short deltaX, short deltaY, short deltaZ, float yaw, float pitch, bool onGround) {
            EntityId = entityId;
            DeltaX = deltaX;
            DeltaY = deltaY;
            DeltaZ = deltaZ;
            OnGround = onGround;

            WriteVarInt(entityId);
            WriteShort(deltaX);
            WriteShort(deltaY);
            WriteShort(deltaZ);

            Angle angle = new(yaw);
            angle.Write(Data);

            angle.Value = pitch;
            angle.Write(Data);

            WriteBoolean(onGround);
        }
    }
}