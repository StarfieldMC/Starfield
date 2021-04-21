// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class YellowBannerBlock : BaseBlock {

        public int Rotation { get; }

        public YellowBannerBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 420, 7965) { }

        public YellowBannerBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 420, state) {
            if(state == 7965) {
                Rotation = 0;
            } else if(state == 7966) {
                Rotation = 1;
            } else if(state == 7967) {
                Rotation = 2;
            } else if(state == 7968) {
                Rotation = 3;
            } else if(state == 7969) {
                Rotation = 4;
            } else if(state == 7970) {
                Rotation = 5;
            } else if(state == 7971) {
                Rotation = 6;
            } else if(state == 7972) {
                Rotation = 7;
            } else if(state == 7973) {
                Rotation = 8;
            } else if(state == 7974) {
                Rotation = 9;
            } else if(state == 7975) {
                Rotation = 10;
            } else if(state == 7976) {
                Rotation = 11;
            } else if(state == 7977) {
                Rotation = 12;
            } else if(state == 7978) {
                Rotation = 13;
            } else if(state == 7979) {
                Rotation = 14;
            } else if(state == 7980) {
                Rotation = 15;
            }
        }

        public YellowBannerBlock(Chunk chunk, int x, int y, int z, int rotation) : base(chunk, x, y, z, 420, 7965) {
if(rotation == 0) {
                State = 7965;
            } else if(rotation == 1) {
                State = 7966;
            } else if(rotation == 2) {
                State = 7967;
            } else if(rotation == 3) {
                State = 7968;
            } else if(rotation == 4) {
                State = 7969;
            } else if(rotation == 5) {
                State = 7970;
            } else if(rotation == 6) {
                State = 7971;
            } else if(rotation == 7) {
                State = 7972;
            } else if(rotation == 8) {
                State = 7973;
            } else if(rotation == 9) {
                State = 7974;
            } else if(rotation == 10) {
                State = 7975;
            } else if(rotation == 11) {
                State = 7976;
            } else if(rotation == 12) {
                State = 7977;
            } else if(rotation == 13) {
                State = 7978;
            } else if(rotation == 14) {
                State = 7979;
            } else if(rotation == 15) {
                State = 7980;
            }
        }
    }
}
