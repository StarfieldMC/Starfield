using System.IO;
using nylium.Extensions;

namespace nylium.Core.Networking.Packet.Client.Play {

    [Packet(0x05, ProtocolState.Play, PacketSide.Client)]
    public class CP05ClientSettings : MinecraftPacket {

        public string Locale { get; }
        public sbyte ViewDistance { get; }
        public ChatModeSetting ChatMode { get; }
        public bool ChatColors { get; }
        
        // displayed skin parts
        public bool CapeEnabled { get; }
        public bool JacketEnabled { get; }
        public bool LeftSleeveEnabled { get; }
        public bool RightSleeveEnabled { get; }
        public bool LeftPantsLegEnabled { get; }
        public bool RightPantsLegEnabled { get; }
        public bool HatEnabled { get; }

        public MainHandSetting MainHand { get; }

        public CP05ClientSettings(MinecraftClient client, Stream stream) : base(client, stream) {
            Locale = Data.ReadString();
            ViewDistance = Data.ReadByte();
            ChatMode = (ChatModeSetting) Data.ReadVarInt();
            ChatColors = Data.ReadBoolean();

            byte displayedSkinParts = Data.ReadUnsignedByte();

            if(displayedSkinParts.IsBitSet(0)) {
                CapeEnabled = true;
            }

            if(displayedSkinParts.IsBitSet(1)) {
                JacketEnabled = true;
            }

            if(displayedSkinParts.IsBitSet(2)) {
                LeftSleeveEnabled = true;
            }

            if(displayedSkinParts.IsBitSet(3)) {
                RightSleeveEnabled = true;
            }

            if(displayedSkinParts.IsBitSet(4)) {
                LeftPantsLegEnabled = true;
            }

            if(displayedSkinParts.IsBitSet(5)) {
                RightPantsLegEnabled = true;
            }

            if(displayedSkinParts.IsBitSet(6)) {
                HatEnabled = true;
            }

            MainHand = (MainHandSetting) Data.ReadVarInt();
        }

        public enum ChatModeSetting : int {

            Enabled,
            CommandsOnly,
            Hidden
        }

        public enum MainHandSetting : int {

            Left,
            Right
        }
    }
}
