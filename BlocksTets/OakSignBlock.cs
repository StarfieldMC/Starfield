// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class OakSignBlock : BaseBlock {

        public int Rotation { get; }
        public bool Waterlogged { get; }

        public OakSignBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 155, 3382) { }

        public OakSignBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 155, state) {
            if(state == 3381) {
                Rotation = 0;
                Waterlogged = true;
            } else if(state == 3382) {
                Rotation = 0;
                Waterlogged = false;
            } else if(state == 3383) {
                Rotation = 1;
                Waterlogged = true;
            } else if(state == 3384) {
                Rotation = 1;
                Waterlogged = false;
            } else if(state == 3385) {
                Rotation = 2;
                Waterlogged = true;
            } else if(state == 3386) {
                Rotation = 2;
                Waterlogged = false;
            } else if(state == 3387) {
                Rotation = 3;
                Waterlogged = true;
            } else if(state == 3388) {
                Rotation = 3;
                Waterlogged = false;
            } else if(state == 3389) {
                Rotation = 4;
                Waterlogged = true;
            } else if(state == 3390) {
                Rotation = 4;
                Waterlogged = false;
            } else if(state == 3391) {
                Rotation = 5;
                Waterlogged = true;
            } else if(state == 3392) {
                Rotation = 5;
                Waterlogged = false;
            } else if(state == 3393) {
                Rotation = 6;
                Waterlogged = true;
            } else if(state == 3394) {
                Rotation = 6;
                Waterlogged = false;
            } else if(state == 3395) {
                Rotation = 7;
                Waterlogged = true;
            } else if(state == 3396) {
                Rotation = 7;
                Waterlogged = false;
            } else if(state == 3397) {
                Rotation = 8;
                Waterlogged = true;
            } else if(state == 3398) {
                Rotation = 8;
                Waterlogged = false;
            } else if(state == 3399) {
                Rotation = 9;
                Waterlogged = true;
            } else if(state == 3400) {
                Rotation = 9;
                Waterlogged = false;
            } else if(state == 3401) {
                Rotation = 10;
                Waterlogged = true;
            } else if(state == 3402) {
                Rotation = 10;
                Waterlogged = false;
            } else if(state == 3403) {
                Rotation = 11;
                Waterlogged = true;
            } else if(state == 3404) {
                Rotation = 11;
                Waterlogged = false;
            } else if(state == 3405) {
                Rotation = 12;
                Waterlogged = true;
            } else if(state == 3406) {
                Rotation = 12;
                Waterlogged = false;
            } else if(state == 3407) {
                Rotation = 13;
                Waterlogged = true;
            } else if(state == 3408) {
                Rotation = 13;
                Waterlogged = false;
            } else if(state == 3409) {
                Rotation = 14;
                Waterlogged = true;
            } else if(state == 3410) {
                Rotation = 14;
                Waterlogged = false;
            } else if(state == 3411) {
                Rotation = 15;
                Waterlogged = true;
            } else if(state == 3412) {
                Rotation = 15;
                Waterlogged = false;
            }
        }

        public OakSignBlock(Chunk chunk, int x, int y, int z, int rotation, bool waterlogged) : base(chunk, x, y, z, 155, 3382) {
if(rotation == 0 && waterlogged == true) {
                State = 3381;
            } else if(rotation == 0 && waterlogged == false) {
                State = 3382;
            } else if(rotation == 1 && waterlogged == true) {
                State = 3383;
            } else if(rotation == 1 && waterlogged == false) {
                State = 3384;
            } else if(rotation == 2 && waterlogged == true) {
                State = 3385;
            } else if(rotation == 2 && waterlogged == false) {
                State = 3386;
            } else if(rotation == 3 && waterlogged == true) {
                State = 3387;
            } else if(rotation == 3 && waterlogged == false) {
                State = 3388;
            } else if(rotation == 4 && waterlogged == true) {
                State = 3389;
            } else if(rotation == 4 && waterlogged == false) {
                State = 3390;
            } else if(rotation == 5 && waterlogged == true) {
                State = 3391;
            } else if(rotation == 5 && waterlogged == false) {
                State = 3392;
            } else if(rotation == 6 && waterlogged == true) {
                State = 3393;
            } else if(rotation == 6 && waterlogged == false) {
                State = 3394;
            } else if(rotation == 7 && waterlogged == true) {
                State = 3395;
            } else if(rotation == 7 && waterlogged == false) {
                State = 3396;
            } else if(rotation == 8 && waterlogged == true) {
                State = 3397;
            } else if(rotation == 8 && waterlogged == false) {
                State = 3398;
            } else if(rotation == 9 && waterlogged == true) {
                State = 3399;
            } else if(rotation == 9 && waterlogged == false) {
                State = 3400;
            } else if(rotation == 10 && waterlogged == true) {
                State = 3401;
            } else if(rotation == 10 && waterlogged == false) {
                State = 3402;
            } else if(rotation == 11 && waterlogged == true) {
                State = 3403;
            } else if(rotation == 11 && waterlogged == false) {
                State = 3404;
            } else if(rotation == 12 && waterlogged == true) {
                State = 3405;
            } else if(rotation == 12 && waterlogged == false) {
                State = 3406;
            } else if(rotation == 13 && waterlogged == true) {
                State = 3407;
            } else if(rotation == 13 && waterlogged == false) {
                State = 3408;
            } else if(rotation == 14 && waterlogged == true) {
                State = 3409;
            } else if(rotation == 14 && waterlogged == false) {
                State = 3410;
            } else if(rotation == 15 && waterlogged == true) {
                State = 3411;
            } else if(rotation == 15 && waterlogged == false) {
                State = 3412;
            }
        }
    }
}
