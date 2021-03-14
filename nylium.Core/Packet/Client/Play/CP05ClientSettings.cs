using System.IO;
using nylium.Extensions;
using nylium.Core.DataTypes;

namespace nylium.Core.Packet.Client.Play {

    [Packet(0x05, ProtocolState.Play, PacketSide.Client)]
    public class CP05ClientSettings : NetworkPacket {

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

        public CP05ClientSettings(Stream stream) : base(stream) {
            Locale = ReadString();
            ViewDistance = ReadByte();
            ChatMode = (ChatModeSetting) ReadVarInt();
            ChatColors = ReadBoolean();

            byte displayedSkinParts = ReadUnsignedByte();

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

            MainHand = (MainHandSetting) ReadVarInt();
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
