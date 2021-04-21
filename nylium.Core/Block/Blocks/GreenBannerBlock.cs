// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class GreenBannerBlock : BaseBlock {

        public int Rotation { get; }

        public GreenBannerBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 429, 8109) { }

        public GreenBannerBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 429, state) {
            if(state == 8109) {
                Rotation = 0;
            } else if(state == 8110) {
                Rotation = 1;
            } else if(state == 8111) {
                Rotation = 2;
            } else if(state == 8112) {
                Rotation = 3;
            } else if(state == 8113) {
                Rotation = 4;
            } else if(state == 8114) {
                Rotation = 5;
            } else if(state == 8115) {
                Rotation = 6;
            } else if(state == 8116) {
                Rotation = 7;
            } else if(state == 8117) {
                Rotation = 8;
            } else if(state == 8118) {
                Rotation = 9;
            } else if(state == 8119) {
                Rotation = 10;
            } else if(state == 8120) {
                Rotation = 11;
            } else if(state == 8121) {
                Rotation = 12;
            } else if(state == 8122) {
                Rotation = 13;
            } else if(state == 8123) {
                Rotation = 14;
            } else if(state == 8124) {
                Rotation = 15;
            }
        }

        public GreenBannerBlock(Chunk chunk, int x, int y, int z, int rotation) : base(chunk, x, y, z, 429, 8109) {
if(rotation == 0) {
                State = 8109;
            } else if(rotation == 1) {
                State = 8110;
            } else if(rotation == 2) {
                State = 8111;
            } else if(rotation == 3) {
                State = 8112;
            } else if(rotation == 4) {
                State = 8113;
            } else if(rotation == 5) {
                State = 8114;
            } else if(rotation == 6) {
                State = 8115;
            } else if(rotation == 7) {
                State = 8116;
            } else if(rotation == 8) {
                State = 8117;
            } else if(rotation == 9) {
                State = 8118;
            } else if(rotation == 10) {
                State = 8119;
            } else if(rotation == 11) {
                State = 8120;
            } else if(rotation == 12) {
                State = 8121;
            } else if(rotation == 13) {
                State = 8122;
            } else if(rotation == 14) {
                State = 8123;
            } else if(rotation == 15) {
                State = 8124;
            }
        }
    }
}
