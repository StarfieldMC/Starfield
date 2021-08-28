namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x3D, ProtocolState.Play, PacketSide.Server)]
    public class SP3DWorldBorder : MinecraftPacket {

        public int Action { get; }

        // set size
        public double Diameter { get; }

        // lerp size + initialize
        public double OldDiameter { get; }
        public double NewDiameter { get; }
        public long Speed { get; }

        // set center + initialize
        public double X { get; }
        public double Z { get; }

        // initialize
        public int PortalTeleportBoundary { get; }

        // initialize + set warning blocks
        public int WarningBlocks { get; }

        // initialize + set warning time
        public int WarningTime { get; }

        /// <summary>
        /// set size
        /// </summary>
        public SP3DWorldBorder(MinecraftClient client, double diameter) : base(client) {
            Action = Data.WriteVarInt(0);
            Diameter = Data.WriteDouble(diameter);
        }

        /// <summary>
        /// lerp size
        /// </summary>
        public SP3DWorldBorder(MinecraftClient client, double oldDiameter, double newDiameter, long speed) : base(client) {
            Action = Data.WriteVarInt(1);
            OldDiameter = Data.WriteDouble(oldDiameter);
            NewDiameter = Data.WriteDouble(newDiameter);
            Speed = Data.WriteVarLong(speed);
        }

        /// <summary>
        /// set center
        /// </summary>
        public SP3DWorldBorder(MinecraftClient client, double x, double z) : base(client) {
            Action = Data.WriteVarInt(2);
            X = Data.WriteDouble(x);
            Z = Data.WriteDouble(z);
        }

        /// <summary>
        /// initialize
        /// </summary>
        public SP3DWorldBorder(MinecraftClient client, double x, double z, double oldDiameter, double newDiameter,
            long speed, int portalTeleportBoundary, int warningBlocks, int warningTime) : base(client) {

            Action = Data.WriteVarInt(3);
            X = Data.WriteDouble(x);
            Z = Data.WriteDouble(z);
            OldDiameter = Data.WriteDouble(oldDiameter);
            NewDiameter = Data.WriteDouble(newDiameter);
            Speed = Data.WriteVarLong(speed);
            PortalTeleportBoundary = Data.WriteVarInt(portalTeleportBoundary);
            WarningBlocks = Data.WriteVarInt(warningBlocks);
            WarningTime = Data.WriteVarInt(warningTime);
        }

        /// <summary>
        /// set warning time/blocks
        /// </summary>
        /// <param name="isWarningBlocks">if set to true, indicates that the warning value is warning blocks</param>
        public SP3DWorldBorder(MinecraftClient client, int warning, bool isWarningBlocks = false) : base(client) {
            if(isWarningBlocks) {
                Action = 5;
                WarningBlocks = warning;
            } else {
                Action = 4;
                WarningTime = warning;
            }

            Data.WriteVarInt(Action);
            Data.WriteVarInt(warning);
        }
    }
}