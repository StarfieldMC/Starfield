// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class WitherSkeletonSkullBlock : BaseBlock {

        public int Rotation { get; }

        public WitherSkeletonSkullBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 316, 6514) { }

        public WitherSkeletonSkullBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 316, state) {
            if(state == 6514) {
                Rotation = 0;
            } else if(state == 6515) {
                Rotation = 1;
            } else if(state == 6516) {
                Rotation = 2;
            } else if(state == 6517) {
                Rotation = 3;
            } else if(state == 6518) {
                Rotation = 4;
            } else if(state == 6519) {
                Rotation = 5;
            } else if(state == 6520) {
                Rotation = 6;
            } else if(state == 6521) {
                Rotation = 7;
            } else if(state == 6522) {
                Rotation = 8;
            } else if(state == 6523) {
                Rotation = 9;
            } else if(state == 6524) {
                Rotation = 10;
            } else if(state == 6525) {
                Rotation = 11;
            } else if(state == 6526) {
                Rotation = 12;
            } else if(state == 6527) {
                Rotation = 13;
            } else if(state == 6528) {
                Rotation = 14;
            } else if(state == 6529) {
                Rotation = 15;
            }
        }

        public WitherSkeletonSkullBlock(Chunk chunk, int x, int y, int z, int rotation) : base(chunk, x, y, z, 316, 6514) {
if(rotation == 0) {
                State = 6514;
            } else if(rotation == 1) {
                State = 6515;
            } else if(rotation == 2) {
                State = 6516;
            } else if(rotation == 3) {
                State = 6517;
            } else if(rotation == 4) {
                State = 6518;
            } else if(rotation == 5) {
                State = 6519;
            } else if(rotation == 6) {
                State = 6520;
            } else if(rotation == 7) {
                State = 6521;
            } else if(rotation == 8) {
                State = 6522;
            } else if(rotation == 9) {
                State = 6523;
            } else if(rotation == 10) {
                State = 6524;
            } else if(rotation == 11) {
                State = 6525;
            } else if(rotation == 12) {
                State = 6526;
            } else if(rotation == 13) {
                State = 6527;
            } else if(rotation == 14) {
                State = 6528;
            } else if(rotation == 15) {
                State = 6529;
            }
        }
    }
}
