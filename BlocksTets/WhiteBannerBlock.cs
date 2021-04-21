// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class WhiteBannerBlock : BaseBlock {

        public int Rotation { get; }

        public WhiteBannerBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 416, 7901) { }

        public WhiteBannerBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 416, state) {
            if(state == 7901) {
                Rotation = 0;
            } else if(state == 7902) {
                Rotation = 1;
            } else if(state == 7903) {
                Rotation = 2;
            } else if(state == 7904) {
                Rotation = 3;
            } else if(state == 7905) {
                Rotation = 4;
            } else if(state == 7906) {
                Rotation = 5;
            } else if(state == 7907) {
                Rotation = 6;
            } else if(state == 7908) {
                Rotation = 7;
            } else if(state == 7909) {
                Rotation = 8;
            } else if(state == 7910) {
                Rotation = 9;
            } else if(state == 7911) {
                Rotation = 10;
            } else if(state == 7912) {
                Rotation = 11;
            } else if(state == 7913) {
                Rotation = 12;
            } else if(state == 7914) {
                Rotation = 13;
            } else if(state == 7915) {
                Rotation = 14;
            } else if(state == 7916) {
                Rotation = 15;
            }
        }

        public WhiteBannerBlock(Chunk chunk, int x, int y, int z, int rotation) : base(chunk, x, y, z, 416, 7901) {
if(rotation == 0) {
                State = 7901;
            } else if(rotation == 1) {
                State = 7902;
            } else if(rotation == 2) {
                State = 7903;
            } else if(rotation == 3) {
                State = 7904;
            } else if(rotation == 4) {
                State = 7905;
            } else if(rotation == 5) {
                State = 7906;
            } else if(rotation == 6) {
                State = 7907;
            } else if(rotation == 7) {
                State = 7908;
            } else if(rotation == 8) {
                State = 7909;
            } else if(rotation == 9) {
                State = 7910;
            } else if(rotation == 10) {
                State = 7911;
            } else if(rotation == 11) {
                State = 7912;
            } else if(rotation == 12) {
                State = 7913;
            } else if(rotation == 13) {
                State = 7914;
            } else if(rotation == 14) {
                State = 7915;
            } else if(rotation == 15) {
                State = 7916;
            }
        }
    }
}
