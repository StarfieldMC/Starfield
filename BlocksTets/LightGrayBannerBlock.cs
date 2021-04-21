// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class LightGrayBannerBlock : BaseBlock {

        public int Rotation { get; }

        public LightGrayBannerBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 424, 8029) { }

        public LightGrayBannerBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 424, state) {
            if(state == 8029) {
                Rotation = 0;
            } else if(state == 8030) {
                Rotation = 1;
            } else if(state == 8031) {
                Rotation = 2;
            } else if(state == 8032) {
                Rotation = 3;
            } else if(state == 8033) {
                Rotation = 4;
            } else if(state == 8034) {
                Rotation = 5;
            } else if(state == 8035) {
                Rotation = 6;
            } else if(state == 8036) {
                Rotation = 7;
            } else if(state == 8037) {
                Rotation = 8;
            } else if(state == 8038) {
                Rotation = 9;
            } else if(state == 8039) {
                Rotation = 10;
            } else if(state == 8040) {
                Rotation = 11;
            } else if(state == 8041) {
                Rotation = 12;
            } else if(state == 8042) {
                Rotation = 13;
            } else if(state == 8043) {
                Rotation = 14;
            } else if(state == 8044) {
                Rotation = 15;
            }
        }

        public LightGrayBannerBlock(Chunk chunk, int x, int y, int z, int rotation) : base(chunk, x, y, z, 424, 8029) {
if(rotation == 0) {
                State = 8029;
            } else if(rotation == 1) {
                State = 8030;
            } else if(rotation == 2) {
                State = 8031;
            } else if(rotation == 3) {
                State = 8032;
            } else if(rotation == 4) {
                State = 8033;
            } else if(rotation == 5) {
                State = 8034;
            } else if(rotation == 6) {
                State = 8035;
            } else if(rotation == 7) {
                State = 8036;
            } else if(rotation == 8) {
                State = 8037;
            } else if(rotation == 9) {
                State = 8038;
            } else if(rotation == 10) {
                State = 8039;
            } else if(rotation == 11) {
                State = 8040;
            } else if(rotation == 12) {
                State = 8041;
            } else if(rotation == 13) {
                State = 8042;
            } else if(rotation == 14) {
                State = 8043;
            } else if(rotation == 15) {
                State = 8044;
            }
        }
    }
}
