// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class OrangeBannerBlock : BaseBlock {

        public int Rotation { get; }

        public OrangeBannerBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 417, 7917) { }

        public OrangeBannerBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 417, state) {
            if(state == 7917) {
                Rotation = 0;
            } else if(state == 7918) {
                Rotation = 1;
            } else if(state == 7919) {
                Rotation = 2;
            } else if(state == 7920) {
                Rotation = 3;
            } else if(state == 7921) {
                Rotation = 4;
            } else if(state == 7922) {
                Rotation = 5;
            } else if(state == 7923) {
                Rotation = 6;
            } else if(state == 7924) {
                Rotation = 7;
            } else if(state == 7925) {
                Rotation = 8;
            } else if(state == 7926) {
                Rotation = 9;
            } else if(state == 7927) {
                Rotation = 10;
            } else if(state == 7928) {
                Rotation = 11;
            } else if(state == 7929) {
                Rotation = 12;
            } else if(state == 7930) {
                Rotation = 13;
            } else if(state == 7931) {
                Rotation = 14;
            } else if(state == 7932) {
                Rotation = 15;
            }
        }

        public OrangeBannerBlock(Chunk chunk, int x, int y, int z, int rotation) : base(chunk, x, y, z, 417, 7917) {
if(rotation == 0) {
                State = 7917;
            } else if(rotation == 1) {
                State = 7918;
            } else if(rotation == 2) {
                State = 7919;
            } else if(rotation == 3) {
                State = 7920;
            } else if(rotation == 4) {
                State = 7921;
            } else if(rotation == 5) {
                State = 7922;
            } else if(rotation == 6) {
                State = 7923;
            } else if(rotation == 7) {
                State = 7924;
            } else if(rotation == 8) {
                State = 7925;
            } else if(rotation == 9) {
                State = 7926;
            } else if(rotation == 10) {
                State = 7927;
            } else if(rotation == 11) {
                State = 7928;
            } else if(rotation == 12) {
                State = 7929;
            } else if(rotation == 13) {
                State = 7930;
            } else if(rotation == 14) {
                State = 7931;
            } else if(rotation == 15) {
                State = 7932;
            }
        }
    }
}
