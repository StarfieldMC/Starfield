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
        public SP3DWorldBorder(double diameter) {
            Action = 0;
            Diameter = diameter;

            WriteVarInt(Action);
            WriteDouble(diameter);
        }

        /// <summary>
        /// lerp size
        /// </summary>
        public SP3DWorldBorder(double oldDiameter, double newDiameter, long speed) {
            Action = 1;
            OldDiameter = oldDiameter;
            NewDiameter = newDiameter;
            Speed = speed;

            WriteVarInt(Action);
            WriteDouble(oldDiameter);
            WriteDouble(newDiameter);
            WriteVarLong(speed);
        }

        /// <summary>
        /// set center
        /// </summary>
        public SP3DWorldBorder(double x, double z) {
            Action = 2;
            X = x;
            Z = z;

            WriteVarInt(Action);
            WriteDouble(x);
            WriteDouble(z);
        }

        /// <summary>
        /// initialize
        /// </summary>
        public SP3DWorldBorder(double x, double z, double oldDiameter, double newDiameter,
            long speed, int portalTeleportBoundary, int warningBlocks, int warningTime) {

            Action = 3;
            X = x;
            Z = z;
            OldDiameter = oldDiameter;
            NewDiameter = newDiameter;
            Speed = speed;
            PortalTeleportBoundary = portalTeleportBoundary;
            WarningBlocks = warningBlocks;
            WarningTime = warningTime;

            WriteVarInt(Action);
            WriteDouble(x);
            WriteDouble(z);
            WriteDouble(oldDiameter);
            WriteDouble(newDiameter);
            WriteVarLong(speed);
            WriteVarInt(portalTeleportBoundary);
            WriteVarInt(warningBlocks);
            WriteVarInt(warningTime);
        }

        /// <summary>
        /// set warning time/blocks
        /// </summary>
        /// <param name="isWarningBlocks">if set to true, indicates that the warning value is warning blocks</param>
        public SP3DWorldBorder(int warning, bool isWarningBlocks = false) {
            if(isWarningBlocks) {
                Action = 5;
                WarningBlocks = warning;
            } else {
                Action = 4;
                WarningTime = warning;
            }

            WriteVarInt(Action);
            WriteVarInt(warning);
        }
    }
}