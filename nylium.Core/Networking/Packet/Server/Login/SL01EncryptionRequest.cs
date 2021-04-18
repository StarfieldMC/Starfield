namespace nylium.Core.Networking.Packet.Server.Login {

    [Packet(0x01, ProtocolState.Login, PacketSide.Server)]
    public class SL01EncryptionRequest : MinecraftPacket {

        public string ServerId { get; }
        public sbyte[] PublicKey { get; }
        public sbyte[] VerifyToken { get; }

        public SL01EncryptionRequest(MinecraftClient client, string serverId, sbyte[] publicKey, sbyte[] verifyToken) : base(client) {
            ServerId = Data.WriteString(serverId);
            Data.WriteVarInt(publicKey.Length);
            PublicKey = Data.WriteByteArray(publicKey);
            Data.WriteVarInt(verifyToken.Length);
            VerifyToken = Data.WriteByteArray(verifyToken);
        }
    }
}