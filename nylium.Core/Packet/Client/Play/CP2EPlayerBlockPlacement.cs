﻿using System.IO;
using nylium.Core.Block;
using nylium.Utilities;

namespace nylium.Core.Packet.Client.Play {

    [Packet(0x2E, ProtocolState.Play, PacketSide.Client)]
    public class CP2EPlayerBlockPlacement : NetworkPacket {

        public bool MainHand { get; }
        public Position.Int Location { get; }
        public GameBlock.Face Face { get; }
        public float CursorPositionX { get; }
        public float CursorPositionY { get; }
        public float CursorPositionZ { get; }
        public bool InsideBlock { get; }

        public CP2EPlayerBlockPlacement(Stream stream) : base(stream) {
            MainHand = ReadVarInt() == 0;
            Location = ReadPosition();
            Face = (GameBlock.Face) ReadVarInt();
            CursorPositionX = ReadFloat();
            CursorPositionY = ReadFloat();
            CursorPositionZ = ReadFloat();
            InsideBlock = ReadBoolean();
        }
    }
}