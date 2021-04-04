using System.IO;

namespace nylium.Core.Networking.Packet.Client.Login {

    [Packet(0x01, ProtocolState.Login, PacketSide.Client)]
    public class CL01EncryptionResponse : MinecraftPacket {

        public sbyte[] SharedSecret { get; }
        public sbyte[] VerifyToken { get; }

        public CL01EncryptionResponse(Stream stream) : base(stream) {
            SharedSecret = ReadByteArray(ReadVarInt());
            VerifyToken = ReadByteArray(ReadVarInt());
        }
    }
}