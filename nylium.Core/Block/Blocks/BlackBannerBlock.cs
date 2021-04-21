// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class BlackBannerBlock : BaseBlock {

        public int Rotation { get; }

        public BlackBannerBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 431, 8141) { }

        public BlackBannerBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 431, state) {
            if(state == 8141) {
                Rotation = 0;
            } else if(state == 8142) {
                Rotation = 1;
            } else if(state == 8143) {
                Rotation = 2;
            } else if(state == 8144) {
                Rotation = 3;
            } else if(state == 8145) {
                Rotation = 4;
            } else if(state == 8146) {
                Rotation = 5;
            } else if(state == 8147) {
                Rotation = 6;
            } else if(state == 8148) {
                Rotation = 7;
            } else if(state == 8149) {
                Rotation = 8;
            } else if(state == 8150) {
                Rotation = 9;
            } else if(state == 8151) {
                Rotation = 10;
            } else if(state == 8152) {
                Rotation = 11;
            } else if(state == 8153) {
                Rotation = 12;
            } else if(state == 8154) {
                Rotation = 13;
            } else if(state == 8155) {
                Rotation = 14;
            } else if(state == 8156) {
                Rotation = 15;
            }
        }

        public BlackBannerBlock(Chunk chunk, int x, int y, int z, int rotation) : base(chunk, x, y, z, 431, 8141) {
if(rotation == 0) {
                State = 8141;
            } else if(rotation == 1) {
                State = 8142;
            } else if(rotation == 2) {
                State = 8143;
            } else if(rotation == 3) {
                State = 8144;
            } else if(rotation == 4) {
                State = 8145;
            } else if(rotation == 5) {
                State = 8146;
            } else if(rotation == 6) {
                State = 8147;
            } else if(rotation == 7) {
                State = 8148;
            } else if(rotation == 8) {
                State = 8149;
            } else if(rotation == 9) {
                State = 8150;
            } else if(rotation == 10) {
                State = 8151;
            } else if(rotation == 11) {
                State = 8152;
            } else if(rotation == 12) {
                State = 8153;
            } else if(rotation == 13) {
                State = 8154;
            } else if(rotation == 14) {
                State = 8155;
            } else if(rotation == 15) {
                State = 8156;
            }
        }
    }
}
