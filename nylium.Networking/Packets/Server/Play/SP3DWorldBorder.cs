using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Server.Play {

    [Packet(0x3D, ProtocolState.Play, PacketSide.Server)]
    public class SP3DWorldBorder : Packet {

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

            VarInt varInt = new(Action);
            varInt.Write(Data);

            Double @double = new(diameter);
            @double.Write(Data);
        }

        /// <summary>
        /// lerp size
        /// </summary>
        public SP3DWorldBorder(double oldDiameter, double newDiameter, long speed) {
            Action = 1;
            OldDiameter = oldDiameter;
            NewDiameter = newDiameter;
            Speed = speed;

            VarInt varInt = new(Action);
            varInt.Write(Data);

            Double @double = new(oldDiameter);
            @double.Write(Data);

            @double.Value = newDiameter;
            @double.Write(Data);

            VarLong varLong = new(speed);
            varLong.Write(Data);
        }

        /// <summary>
        /// set center
        /// </summary>
        public SP3DWorldBorder(double x, double z) {
            Action = 2;
            X = x;
            Z = z;

            VarInt varInt = new(Action);
            varInt.Write(Data);

            Double @double = new(x);
            @double.Write(Data);

            @double.Value = z;
            @double.Write(Data);
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

            VarInt varInt = new(Action);
            varInt.Write(Data);

            Double @double = new(x);
            @double.Write(Data);

            @double.Value = z;
            @double.Write(Data);

            @double.Value = oldDiameter;
            @double.Write(Data);

            @double.Value = newDiameter;
            @double.Write(Data);

            VarLong varLong = new(speed);
            varLong.Write(Data);

            varInt.Value = portalTeleportBoundary;
            varInt.Write(Data);

            varInt.Value = warningBlocks;
            varInt.Write(Data);

            varInt.Value = warningTime;
            varInt.Write(Data);
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

            VarInt varInt = new(Action);
            varInt.Write(Data);

            varInt.Value = warning;
            varInt.Write(Data);
        }
    }
}