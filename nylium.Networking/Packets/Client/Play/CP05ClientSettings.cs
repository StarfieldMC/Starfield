using System.IO;
using nylium.Extensions;
using nylium.Networking.DataTypes;

namespace nylium.Networking.Packets.Client.Play {

    [Packet(0x05, ProtocolState.Play, PacketSide.Client)]
    public class CP05ClientSettings : Packet {

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
            String @string = new(Data);
            Locale = @string.Value;

            Byte @byte = new(Data);
            ViewDistance = @byte.Value;

            VarInt varInt = new(Data);
            ChatMode = (ChatModeSetting) varInt.Value;

            Boolean boolean = new(Data);
            ChatColors = boolean.Value;

            UByte ubyte = new(Data);
            byte displayedSkinParts = ubyte.Value;

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

            varInt.Read(Data);
            MainHand = (MainHandSetting) varInt.Value;
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
