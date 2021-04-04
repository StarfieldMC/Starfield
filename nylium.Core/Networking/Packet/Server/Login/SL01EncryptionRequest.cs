using System;

namespace nylium.Core.Networking.Packet.Server.Login {

    [Packet(0x01, ProtocolState.Login, PacketSide.Server)]
    public class SL01EncryptionRequest : MinecraftPacket {

        public string ServerId { get; }
        public sbyte[] PublicKey { get; }
        public sbyte[] VerifyToken { get; }

        public SL01EncryptionRequest(string serverId, sbyte[] publicKey, sbyte[] verifyToken) {
            ServerId = serverId;
            PublicKey = publicKey;
            VerifyToken = verifyToken;

            WriteString(serverId);
            WriteVarInt(publicKey.Length);
            WriteByteArray(publicKey);
            WriteVarInt(verifyToken.Length);
            WriteByteArray(verifyToken);
        }
    }
}