// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class LightBlueBannerBlock : BaseBlock {

        public int Rotation { get; }

        public LightBlueBannerBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 419, 7949) { }

        public LightBlueBannerBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 419, state) {
            if(state == 7949) {
                Rotation = 0;
            } else if(state == 7950) {
                Rotation = 1;
            } else if(state == 7951) {
                Rotation = 2;
            } else if(state == 7952) {
                Rotation = 3;
            } else if(state == 7953) {
                Rotation = 4;
            } else if(state == 7954) {
                Rotation = 5;
            } else if(state == 7955) {
                Rotation = 6;
            } else if(state == 7956) {
                Rotation = 7;
            } else if(state == 7957) {
                Rotation = 8;
            } else if(state == 7958) {
                Rotation = 9;
            } else if(state == 7959) {
                Rotation = 10;
            } else if(state == 7960) {
                Rotation = 11;
            } else if(state == 7961) {
                Rotation = 12;
            } else if(state == 7962) {
                Rotation = 13;
            } else if(state == 7963) {
                Rotation = 14;
            } else if(state == 7964) {
                Rotation = 15;
            }
        }

        public LightBlueBannerBlock(Chunk chunk, int x, int y, int z, int rotation) : base(chunk, x, y, z, 419, 7949) {
if(rotation == 0) {
                State = 7949;
            } else if(rotation == 1) {
                State = 7950;
            } else if(rotation == 2) {
                State = 7951;
            } else if(rotation == 3) {
                State = 7952;
            } else if(rotation == 4) {
                State = 7953;
            } else if(rotation == 5) {
                State = 7954;
            } else if(rotation == 6) {
                State = 7955;
            } else if(rotation == 7) {
                State = 7956;
            } else if(rotation == 8) {
                State = 7957;
            } else if(rotation == 9) {
                State = 7958;
            } else if(rotation == 10) {
                State = 7959;
            } else if(rotation == 11) {
                State = 7960;
            } else if(rotation == 12) {
                State = 7961;
            } else if(rotation == 13) {
                State = 7962;
            } else if(rotation == 14) {
                State = 7963;
            } else if(rotation == 15) {
                State = 7964;
            }
        }
    }
}
